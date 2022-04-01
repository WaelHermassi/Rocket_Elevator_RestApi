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

        [HttpGet("email")]
        public async Task<ActionResult<IEnumerable<Lead>>> GetLeadEmails()
        {
            DateTime today = DateTime.Today;
            DateTime dateLimit = today.AddDays(-30);

            List<Lead> leads = await _context.leads.ToListAsync();
            List<Lead> goodLeads = new List<Lead>();

            List<Customer> customers = await _context.customers.ToListAsync();

            List<User> users = await _context.users.ToListAsync();

            foreach (Lead lead in leads)
            {
                foreach (User user in users)
                {
                    foreach (Customer customer in user.Customers)
                    {
                        if (user.email == lead.email)
                        {
                            if (DateTime.Now > dateLimit)
                            {
                                goodLeads.Add(lead);
                            }
                        }
                    }
                }
            }
            return goodLeads;
        }

        private bool LeadExists(long id)
        {
            return _context.leads.Any(e => e.id == id);
        }
    }
}

