using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.FleetUp.Application.Contracts.DTOs
{
    public class AssetDto
    {
       public int Id { get; set; }
        public string VIN { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
    }
}