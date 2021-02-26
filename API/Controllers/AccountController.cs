using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public AccountController(DataContext context,
                                ITokenService tokenService,
                                IMapper mapper)
        {
            _mapper = mapper;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("registerColPrep")]
        public async Task<ActionResult<UserDto>> RegisterColPrep(RegisterColPrepDto registerColPrepDto)
        {

            if (await UserExists(registerColPrepDto.UserName))
            {
                return BadRequest("Username is taken");
            }

            var user = _mapper.Map<AppUser>(registerColPrepDto);

            using var hmac = new HMACSHA512();

            user.UserName = registerColPrepDto.UserName.ToLower();
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerColPrepDto.Password));
            user.PasswordSalt = hmac.Key;
            user.AppUserType = registerColPrepDto.AppUserType;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto
            {
                UserName = user.UserName,
                Token = _tokenService.CreateToken(user),
                AppUserType = "ColStudent",
                FirstName = user.FirstName
            };
        }

        [HttpPost("registerEmp")]
        public async Task<ActionResult<UserDto>> RegisterEmp(RegisterEmpDto registerEmpDto)
        {
            if (await UserExists(registerEmpDto.UserName))
            {
                return BadRequest("Username is taken");
            }

            using var hmac = new HMACSHA512();

            var user = new AppUser
            {
                UserName = registerEmpDto.UserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerEmpDto.Password)),
                PasswordSalt = hmac.Key,
                AppUserType = registerEmpDto.AppUserType
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto
            {
                UserName = user.UserName,
                Token = _tokenService.CreateToken(user),
                AppUserType = "EmpHr"
            };
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
                .Include(p => p.Photos)
                .SingleOrDefaultAsync(x => x.UserName == loginDto.UserName);

            if (user == null)
            {
                return Unauthorized("Invalid username");
            }

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid password");
                }
            }


            return new UserDto
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                Token = _tokenService.CreateToken(user),
                AppUserType = user.AppUserType,
                StudentUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.StudentUrl,
                LogoUrl = user.Photos.FirstOrDefault(x => x.IsMainLogo)?.LogoUrl,
                HrUrl = user.Photos.FirstOrDefault(x => x.IsMainHr)?.HrUrl
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
    }
}