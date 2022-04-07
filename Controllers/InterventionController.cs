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
    public class InterventionController : ControllerBase
    {
        private readonly waelContext _context;

        public InterventionController(waelContext context)
        {
            _context = context;
        }

        // GET: api/Intervention
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetInterventions()
        {
            return await _context.interventions.Where(intervention => intervention.satart_date_and_time_intervention == null && intervention.status == "Pending").ToListAsync();
        }

        // GET: api/Intervention/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> GetIntervention(long id)
        {
            var intervention = await _context.interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }

            return intervention;
        }

        // PUT: api/Intervention/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInterventionCompleted(long id)
        {
            var update = await _context.interventions.FindAsync(id);
             if (update.status == "Pending")
                {   
                    
                    update.satart_date_and_time_intervention = DateTime.UtcNow;
                    update.status = "InProgress";
                }
                _context.interventions.Update(update);
                 await _context.SaveChangesAsync();
                 return Content("Intervention: " + update.id + ", status has been changed to: " + update.status);
             
        }[HttpPut("{id}/{status}")]
        public async Task<IActionResult> PutIntervention([FromRoute] long id, [FromRoute] string status)
        {
            var completed = await _context.interventions.FindAsync(id);
             if (completed.status == "InProgress")
                {   
                    
                    completed.end_date_and_time_intervention = DateTime.UtcNow;
                    completed.status = "Completed";
                }
                _context.interventions.Update(completed);
                 await _context.SaveChangesAsync();
                 return Content("Intervention: " + completed.id + ", status has been changed to: " + completed.status);
             
        }
        // POST: api/Intervention
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Intervention>> PostIntervention(Intervention intervention)
        {
            _context.interventions.Add(intervention);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntervention", new { id = intervention.id }, intervention);
        }

        // DELETE: api/Intervention/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntervention(long id)
        {
            var intervention = await _context.interventions.FindAsync(id);
            if (intervention == null)
            {
                return NotFound();
            }

            _context.interventions.Remove(intervention);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterventionExists(long id)
        {
            return _context.interventions.Any(e => e.id == id);
        }
    }
}
