using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Infra.Persistence.Data
{
    public static class FleetUpDbInitializer
    {
        public static  void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>().HasData(
                new List<Asset>(){
                  new Asset(){Id=1,VIN="A55-522",Description="For Production",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=2,VIN="F5588",Description="For Sales Department",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=3,VIN="QE-5426",Description="For Employees",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=4,VIN="W690001",Description="For CEO",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=5,VIN="PA-59977",Description="For Transporting",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=6,VIN="DO1005",Description="For Production 2",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
                  new Asset(){Id=7,VIN="AF97-23",Description="For Events",CurrentValue=555,Model="Masda",Make="Honda",Year="2020", Color="Blue", CreatedOn=DateTime.Today},
             });    

            modelBuilder.Entity<Maintenance>().HasData(
                    new List<Maintenance>(){
                    new Maintenance(){Id=1, Title="Change Tires",TaskDetails="Replace",MilesToExecuteTask=5000,ToolsNeeded="ToolBox A357",EstimatedCost=2500 },
                    new Maintenance(){Id=2,  Title="Change Oil",TaskDetails="Replace",MilesToExecuteTask=5000,ToolsNeeded="ToolBox Q977",EstimatedCost=500 },
                    new Maintenance(){Id=3, Title="Check Engine",TaskDetails="Review",MilesToExecuteTask=5000,ToolsNeeded="ToolBox D-1002",EstimatedCost=350 }
            });

            modelBuilder.Entity<Schedule>().HasData(
                    new List<Schedule>(){
                    new Schedule(){Id=1, AssetId=1, MaintenanceId=3 },
                    new Schedule(){Id=2, AssetId=1, MaintenanceId=2 },
                    new Schedule(){Id=3, AssetId=1, MaintenanceId=1 },
                    new Schedule(){Id=4, AssetId=2, MaintenanceId=3 },
                    new Schedule(){Id=5, AssetId=3, MaintenanceId=2 },
                    new Schedule(){Id=6, AssetId=4, MaintenanceId=1 },
                    new Schedule(){Id=7, AssetId=5, MaintenanceId=2 },
                    new Schedule(){Id=8, AssetId=5, MaintenanceId=3 },
                    new Schedule(){Id=9, AssetId=6, MaintenanceId=2 },
                    new Schedule(){Id=10, AssetId=7, MaintenanceId=3 },
                    new Schedule(){Id=11, AssetId=7, MaintenanceId=2 },
                    new Schedule(){Id=12, AssetId=7, MaintenanceId=1 }

            });

        }
    }
}