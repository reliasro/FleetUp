using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class Asset:IAggregate
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Description { get; set; }
        public decimal CurrentValue { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}