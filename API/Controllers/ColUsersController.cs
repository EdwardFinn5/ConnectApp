using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using AutoMapper;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // [Authorize]
    public class ColUsersController : BaseApiController
    {
        private readonly IColUserRepository _colUserRepository;
        private readonly IMapper _mapper;

        public ColUsersController(IColUserRepository colUserRepository,
                                    IMapper mapper)
        {
            _mapper = mapper;
            _colUserRepository = colUserRepository;
        }

        // api/colUsers
        [HttpGet]
        // [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ColMemberDto>>> GetColUsers()
        {
            var colUsers = await _colUserRepository.GetColMembersAsync();

            return Ok(colUsers);
        }


        // api/colUsers/3
        // [Authorize]
        [HttpGet("{colusername}")]
        public async Task<ActionResult<ColMemberDto>> GetColUser(string colusername)
        {
            return await _colUserRepository.GetColMemberAsync(colusername);
        }
    }
}