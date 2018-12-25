using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImmoAPI.Models;

namespace ImmoAPI.Controllers
{
    public class BuildingsController : ApiController
    {
        Building[] buildings = new Building[]
        {
            new Building {Id = 1, Name = "EFH Belp", Category = "Wohnen", Price = 800000 },
            new Building {Id = 2, Name = "MFH Zimmerwald", Category = "Wohnen", Price = 1800000 },
            new Building {Id = 3, Name = "EFH Bern", Category = "Wohnen", Price = 900000 },
            new Building {Id = 4, Name = "Lagerhalle Rubigen", Category = "Industrie", Price = 400000 }
        };

        public IEnumerable<Building> GetAllBuildings()
        {
            return buildings;
        }

        public IHttpActionResult GetBuilding(int id)
        {
            var building = buildings.FirstOrDefault((p) => p.Id == id);
            if (building == null)
            {
                return NotFound();
            }
            return Ok(building);
        }
    }
}
