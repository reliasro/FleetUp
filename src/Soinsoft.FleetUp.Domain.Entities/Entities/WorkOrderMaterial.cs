using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class WorkOrderMaterial
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public int ItemNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

    }
}