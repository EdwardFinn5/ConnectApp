using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColUsersController : ControllerBase
    {
        private readonly DataContext _context;
        public ColUsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColUser>>> GetColUsers()
        {
           return await _context.ColUsers.ToListAsync();
        } 

         [HttpGet("{coluserid}")]
        public async Task<ActionResult<ColUser>> GetColUser(int colUserId)
        {
            return await  _context.ColUsers.FindAsync(colUserId);
        } 
    }
}