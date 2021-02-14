using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : BaseApiController
    {
        private readonly DataContext _context;

        public CollegeController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<CollegeController>
        [HttpGet]
        public IEnumerable<College> Get()
        {
            
            College college = _context.Colleges.Where(col => col.CollegeStreet == "Street").FirstOrDefault();
            _context.Colleges.Remove(college);
            _context.SaveChanges();

            return _context.Colleges.Where(col => col.CollegeStreet == "Street").ToList();
        }
    }
}

    //public IEnumerable<AppUser> Get()
    //{
    //    return _context.Users.Where(c => c.FirstName == "Ken").ToList();



    //return _context.Colleges.Where(col => col.CollegeCity == "Sioux City").ToList();

    //AppUser user = new AppUser();

    //user.FirstName = "Tommie";
    //user.LastName = "Spaghetti";

    //_context.Users.Add(user);
    //_context.SaveChanges();

    //return _context.Users
    //    .Include(p => p.Photos)
    //    .Include(c => c.CollegePreps)
    //    .Include(e => e.EmpOpps)
    //    .Where(col => col.FirstName == "Tommie");



        // GET api/<CollegeController>/5
      
