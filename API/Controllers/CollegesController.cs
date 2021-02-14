﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        private readonly DataContext _context;

        public CollegesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Colleges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetColleges()
        {
            return await _context.Colleges.ToListAsync();
        }

        // GET: api/Colleges/5 changed to GetCollegeDetails
        // [HttpGet("GetCollegeDetails/{id}")]
        // public async Task<ActionResult<College>> GetCollegeDetails(int id)
        // {
        //     var college = _context.Colleges
        //         .Include(ff => ff.FactFeatures)
        //         .Include(cm => cm.CollegeMajors)
        //         .Include(cu => cu.ColUser)
        //         .Where(col => col.CollegeId == id)
        //         .FirstOrDefault();

        //     if (college == null)
        //     {
        //         return NotFound();
        //     }

        //     return college;
        // }

       

        // GET: api/Colleges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<College>> GetCollege(int id)
        {
            var college = await _context.Colleges.FindAsync(id);

            if (college == null)
            {
                return NotFound();
            }

            return college;
        }


        // PUT: api/Colleges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege(int id, College college)
        {
            if (id != college.CollegeId)
            {
                return BadRequest();
            }

            _context.Entry(college).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colleges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<College>> PostCollege(College college)
        {
            _context.Colleges.Add(college);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CollegeExists(college.CollegeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCollege", new { id = college.CollegeId }, college);
        }

        // DELETE: api/Colleges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollege(int id)
        {
            var college = await _context.Colleges.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }

            _context.Colleges.Remove(college);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CollegeExists(int id)
        {
            return _context.Colleges.Any(e => e.CollegeId == id);
        }
    }
}
