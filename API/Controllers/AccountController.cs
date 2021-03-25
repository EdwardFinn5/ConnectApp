using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager,
                                SignInManager<AppUser> signInManager,
                                ITokenService tokenService,
                                IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        [HttpPost("registerColPrep")]
        public async Task<ActionResult<UserDto>> RegisterColPrep(RegisterColPrepDto registerColPrepDto)
        {

            if (await UserExists(registerColPrepDto.Username))
            {
                return BadRequest("Username is taken");
            }

            var user = _mapper.Map<AppUser>(registerColPrepDto);

            user.UserName = registerColPrepDto.Username.ToLower();
            user.AppUserType = registerColPrepDto.AppUserType;

            var result = await _userManager.CreateAsync(user, registerColPrepDto.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return new UserDto
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                AppUserType = "ColStudent",
                FirstName = user.FirstName,
                College = user.College
            };
        }

        [HttpPost("registerEmp")]
        public async Task<ActionResult<UserDto>> RegisterEmp(RegisterEmpDto registerEmpDto)
        {
            if (await UserExists(registerEmpDto.Username))
            {
                return BadRequest("Username is taken");
            }

            var user = _mapper.Map<AppUser>(registerEmpDto);

            user.UserName = registerEmpDto.Username.ToLower();
            user.AppUserType = registerEmpDto.AppUserType;

            var result = await _userManager.CreateAsync(user, registerEmpDto.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return new UserDto
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                AppUserType = "EmpHr",
                FirstName = user.FirstName,
                Company = user.Company
            };
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.Users
                .Include(p => p.Photos)
                .SingleOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());

            if (user == null)
            {
                return Unauthorized("Invalid username");
            }

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded) return Unauthorized();

            return new UserDto
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                Token = await _tokenService.CreateToken(user),
                AppUserType = user.AppUserType,
                College = user.College,
                Company = user.Company,
                StudentUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.StudentUrl,
                LogoUrl = user.Photos.FirstOrDefault(x => x.IsMainLogo)?.LogoUrl,
                HrUrl = user.Photos.FirstOrDefault(x => x.IsMainHr)?.HrUrl
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await _userManager.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
    }
}