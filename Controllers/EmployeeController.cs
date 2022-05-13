#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetCoreMySQL.Models;

namespace RocketElevatorsRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly waelContext _context;

        public EmployeeController(waelContext context)
        {
            _context = context;
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            return await _context.employees.ToListAsync();
        }
        
        // GET: api/Employee/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Employee>> GetEmployees(long id)
        // {
        //     var employees = await _context.employees.FindAsync(id);

        //     if (employees == null)
        //     {
        //         return NotFound();
        //     }

        //     return employees;
        // }
        [HttpGet("{employee_email}")]
        public ActionResult<List<Employee>> FindEmployee_Email(string employee_email)
        {
            var email = _context.employees.Where(e => e.email == employee_email).ToList();

            if (email.Count == 0)
            {
                return NotFound();
            }

            return (email);
        }

        // PUT: api/Employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(long id, Employee employees)
        {
            if (id != employees.id)
            {
                return BadRequest();
            }

            _context.Entry(employees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

        // POST: api/Employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employees)
        {
            _context.employees.Add(employees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employees.id }, employees);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(long id)
        {
            var employees = await _context.employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }

            _context.employees.Remove(employees);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(long id)
        {
            return _context.employees.Any(employees => employees.id == id);
        }
    }
}
