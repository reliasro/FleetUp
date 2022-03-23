using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class AssetInfo
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public Decimal CurrentValue { get; set; }
    }
}