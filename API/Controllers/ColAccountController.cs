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

    [HttpPost("register")]
    public async Task<ActionResult<ColUserDto>> Register(ColRegisterDto colRegisterDto)
    {

        if (await ColUserExists(colRegisterDto.ColUserName))
        {
            return BadRequest("Username is taken");
        }

        using var hmac = new HMACSHA512();

        var colUser = new ColUser
        {
            ColUserName = colRegisterDto.ColUserName.ToLower(),
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(colRegisterDto.Password)),
            PasswordSalt = hmac.Key
        };

        _context.ColUsers.Add(colUser);
        await _context.SaveChangesAsync();

        return new ColUserDto
        {
            ColUserName = colUser.ColUserName,
            Token = _tokenService.CreateColToken(colUser)
        };
    }

    [HttpPost("login")]
    public async Task<ActionResult<ColUserDto>> Login(ColLoginDto colLoginDto)
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
            Token = _tokenService.CreateColToken(colUser)
        };

    }
    private async Task<bool> ColUserExists(string colUserName)
    {
        return await _context.ColUsers.AnyAsync(x => x.ColUserName == colUserName.ToLower());
    }
}
}