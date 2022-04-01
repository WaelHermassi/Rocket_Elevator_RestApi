#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetCoreMySQL.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly rocketelevatorsfoobarContext _context;

        public ElevatorController(rocketelevatorsfoobarContext context)
        {
            _context = context;
        }

        // GET: api/Elevator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> Getelevators()
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

        // Retrieving a list of Elevators that are not in operation at the time of the request
        // GET: api/invalid
        [HttpGet("invalid")]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetOfflineElevators()
        {
            List<Elevator> allElevators = await _context.elevators.ToListAsync();
            List<Elevator> offlineElevators = new List<Elevator>();
            foreach (Elevator elevator in allElevators){
                if (elevator.status != "valid"){
                    offlineElevators.Add(elevator);
                }
            }
            return offlineElevators;
        }

        // PUT: api/Elevator/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevator(long id, Elevator elevator)
        {
            if (id != elevator.id)
            {
                return BadRequest();
            }

            _context.Entry(elevator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevatorExists(id))
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

        private bool ElevatorExists(long id)
        {
            return _context.elevators.Any(e => e.id == id);
        }
    }
}
