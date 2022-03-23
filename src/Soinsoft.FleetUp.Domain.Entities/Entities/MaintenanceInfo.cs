using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class MaintenanceInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TaskDetails { get; set; }    
        public decimal EstimatedCost { get; set; }
    }
}