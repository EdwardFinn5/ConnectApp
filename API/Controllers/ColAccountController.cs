using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ColAccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public ColAccountController(DataContext context,
                                    ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("registerHs")]
        public async Task<ActionResult<ColUserDto>> RegisterHs(registerHsDto registerHsDto)
        {

            if (await ColUserExists(registerHsDto.ColUserName))
            {
                return BadRequest("Username is taken");
            }

            using var hmac = new HMACSHA512();

            var colUser = new ColUser
            {
                ColUserName = registerHsDto.ColUserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerHsDto.Password)),
                PasswordSalt = hmac.Key,
                ColUserType = registerHsDto.ColUserType
            };

            _context.ColUsers.Add(colUser);
            await _context.SaveChangesAsync();

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateColToken(colUser),
                ColUserType = "ColLead"
            };
        }

        [HttpPost("registerCollege")]
        public async Task<ActionResult<ColUserDto>> RegisterCollege(RegisterCollegeDto registerCollegeDto)
        {

            if (await ColUserExists(registerCollegeDto.ColUserName))
            {
                return BadRequest("Username is taken");
            }

            using var hmac = new HMACSHA512();

            var colUser = new ColUser
            {
                ColUserName = registerCollegeDto.ColUserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerCollegeDto.Password)),
                PasswordSalt = hmac.Key,
                ColUserType = registerCollegeDto.ColUserType
            };

            _context.ColUsers.Add(colUser);
            await _context.SaveChangesAsync();

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateColToken(colUser),
                ColUserType = "College"
            };
        }

        [HttpPost("colLogin")]
        public async Task<ActionResult<ColUserDto>> ColLogin(ColLoginDto colLoginDto)
        {

            var colUser = await _context.ColUsers
                .SingleOrDefaultAsync(x => x.ColUserName == colLoginDto.ColUserName);

            if (colUser == null)
            {
                return Unauthorized("Invalid username");
            }

            using var hmac = new HMACSHA512(colUser.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(colLoginDto.Password));

            for (var i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != colUser.PasswordHash[i]) return Unauthorized("Invalid password");
            }

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateColToken(colUser),
                ColUserType = colUser.ColUserType
            };

        }
        private async Task<bool> ColUserExists(string colUserName)
        {
            return await _context.ColUsers.AnyAsync(x => x.ColUserName == colUserName.ToLower());
        }
    }
}