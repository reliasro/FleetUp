using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class WorkOrder:IAggregate
    {
        public int Id { get; set; }
        public int MaintenanceId { get; set; }
        public DateTime DateOfExecution { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int TimeSpent { get; set; }
        public Decimal TotalCost { get; set; }
        public string Notes { get; set; }
        public string TaskExecuted { get; set; }
        public int ContractorID { get; set; }
        public AssetInfo AssetInfo { get; set; }
        public MaintenanceInfo MaintenanceInfo { get; set; }
        public List<WorkOrderMaterial> Materials { get; set; }
    }
}