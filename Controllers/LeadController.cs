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
    public class LeadController : ControllerBase
    {
        private readonly rocketelevatorsfoobarContext _context;

        public LeadController(rocketelevatorsfoobarContext context)
        {
            _context = context;
        }

        // GET: api/Lead
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lead>>> Getleads()
        {
            return await _context.leads.ToListAsync();
        }

        // GET: api/Lead/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lead>> GetLead(long id)
        {
            var lead = await _context.leads.FindAsync(id);

            if (lead == null)
            {
                return NotFound();
            }

            return lead;
        }

        // GET: api/Lead/email
        [HttpGet("email")]
        public async Task<ActionResult<IEnumerable<Lead>>> GetLeadEmails()
        {
            var lead = await _context.leads
            .Where(l => l.date_of_contact_request == null && (l.created_at >= DateTime.Now.AddDays(-30) && l.created_at
             <= DateTime.Now) && !_context.customers.Any(c => c.email_of_the_company_contact == l.email)).ToListAsync();
             return lead;
        }

        private bool LeadExists(long id)
        {
            return _context.leads.Any(e => e.id == id);
        }
    }
}

