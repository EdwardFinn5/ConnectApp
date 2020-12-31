using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ColUsersController : BaseApiController
    {
        private readonly DataContext _context;
        public ColUsersController(DataContext context)
        {
            _context = context;
        }

        // api/colUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColUser>>> GetColUsers()
        {
            // var colUsers = _context.ColUsers.ToList(); these two lines become one

            // return colUsers;
            
            return await _context.ColUsers.ToListAsync();
        }

        // api/colUsers/3
        [HttpGet("{id}")]
        public  async Task<ActionResult<ColUser>> GetColUser(int id)
        {
            return await _context.ColUsers.FindAsync(id);
        }
    }
} 