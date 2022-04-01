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
    public class BuildingController : ControllerBase
    {
        private readonly rocketelevatorsfoobarContext _context;

        public BuildingController(rocketelevatorsfoobarContext context)
        {
            _context = context;
        }

        // GET: api/Building
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Building>>> Getbuildings()
        {
            return await _context.buildings.ToListAsync();
        }

        // GET: api/Building/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Building>> GetBuilding(long id)
        {
            var building = await _context.buildings.FindAsync(id);

            if (building == null)
            {
                return NotFound();
            }

            return building;
        }
        // GET: api/Building/intervention
        [HttpGet("intervention")]
        public async Task<ActionResult<IEnumerable<Building>>> GetInterventionBuildings()
        {
            // var building = await _context.buildings.FindAsync(id);
            // var battery = await _context.batteries.FindAsync(status);
            // var column = await _context.columns.FindAsync(status);
            // var elevator = await _context.elevators.FindAsync(status);

            List<Battery> interventionBatteries = new List<Battery>();
            List<Battery> batteries = await _context.batteries.ToListAsync();

            List<Column> interventionColumns = new List<Column>();
            List<Column> columns = await _context.columns.ToListAsync();

            List<Elevator> interventionElevators = new List<Elevator>();
            List<Elevator> elevators = await _context.elevators.ToListAsync();

            List<Building> interventionBuildings = new List<Building>();
            List<Building> buildings = await _context.buildings.ToListAsync();
            //_context.buildings.

            // Searching for a status "intervention"
            foreach (Building building in buildings)
            {
                //Console.WriteLine(building.Batteries.Count);
                // List<Battery> interventionBatteries = _context.batteries.Where(b => b.building_id == building.id && b.status == "Intervention").ToList();
                
                // if(interventionBatteries.Count > 0 && !interventionBuildings.Contains(building)) {
                //     interventionBuildings.Add(building);
                //     Console.WriteLine("Building #" + building.id + " added");
                // }

                foreach (Battery battery in building.Batteries)
                {
                    Console.WriteLine("Building #" + building.id + " battery #" + battery.id);
                    if (battery.status == "Intervention" && !interventionBuildings.Contains(building))
                    {
                        interventionBuildings.Add(building); 
                    }
                    foreach (Column column in battery.Columns)
                    {
                        if (column.status == "Intervention" && !interventionBuildings.Contains(building))
                        {
                            interventionBuildings.Add(building);
                        }
                        foreach (Elevator elevator in column.Elevators)
                        {
                            if (elevator.status == "Intervention" && !interventionBuildings.Contains(building))
                            {
                                interventionBuildings.Add(building);
                            }
                        }
                    }
                }

            }

            return interventionBuildings;
        }

        private bool BuildingExists(long id)
        {
            return _context.buildings.Any(e => e.id == id);
        }
    }
}
