using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class Maintenance:IAggregate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TaskDetails { get; set; }
        public int MilesToExecuteTask { get; set; }
        public string ToolsNeeded { get; set; }
        public decimal EstimatedCost { get; set; }

    }
}