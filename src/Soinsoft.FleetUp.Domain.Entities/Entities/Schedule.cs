using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class Schedule:IAggregate
    {
       public int Id { get; set; }
       public int AssetId { get; set; } 
       public int MaintenanceId { get; set; }
    }
}