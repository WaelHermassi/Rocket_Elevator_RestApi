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
    public class ElevatorController : ControllerBase
    {
        private readonly waelContext _context;

        public ElevatorController(waelContext context)
        {
            _context = context;
        }

        // GET: api/Elevator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetElevator()
        {
            return await _context.elevators.ToListAsync();
        }

        // GET: api/Elevator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elevator>> GetElevator(long id)
        {
            var elevator = await _context.elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }

            return elevator;
        }
        [HttpGet("invalid")]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetOfflineElevators()
        {
            List<Elevator> allElevators = await _context.elevators.ToListAsync();
            List<Elevator> offlineElevators = new List<Elevator>();
            foreach (Elevator elevator in allElevators) {
                if (elevator.status == "invalid") {
                    offlineElevators.Add(elevator);
                }
            }
            return offlineElevators;
        }

        
        // PUT: api/Elevator/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}/{status}")]
        public async Task<IActionResult> PutElevator([FromRoute] long id, [FromRoute] string status)
        {
             var offline = await _context.elevators.FindAsync(id);
            if (offline.status == "invalid")
            {   
                    
                    offline.status = "Online";
            }
               

            _context.elevators.Update(offline);

            
                await _context.SaveChangesAsync();
            return Content("Status: " + offline.status + ", status has been changed to: " + offline.status);
        }

        // POST: api/elevators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Elevator>> PostElevator(Elevator elevators)
        {
            _context.elevators.Add(elevators);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElevator", new { id = elevators.id }, elevators);
        }

        // DELETE: api/Elevator/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElevator(long id)
        {
            var elevator = await _context.elevators.FindAsync(id);
            if (elevator == null)
            {
                return NotFound();
            }

            _context.elevators.Remove(elevator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElevatorExists(long id)
        {
            return _context.elevators.Any(elevator => elevator.id == id);
        }
    }
}
