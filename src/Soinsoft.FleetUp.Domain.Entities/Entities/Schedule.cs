using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soinsoft.FleetUp.Domain.Entities
{
    public class Schedule
    {
       public int Id { get; set; }
       public int AssetId { get; set; } 
       public int MaintenanceId { get; set; }
    }
}