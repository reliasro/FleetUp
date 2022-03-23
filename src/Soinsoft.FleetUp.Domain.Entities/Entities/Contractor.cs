using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class Contractor:IAggregate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public Decimal CurrentBalance { get; set; }

    }
}