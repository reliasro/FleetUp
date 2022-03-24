using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Soinsoft.FleetUp.Infra.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Soinsoft.FleetUp.Infra.Persistence.Repositories;
using Soinsoft.FleetUp.Domain.Contracts;

namespace Soinsoft.FleetUp.Infra.Persistence.Container
{
    public static class FleetUpServices
    {
        public static void Register(IServiceCollection services, IConfiguration config){

                services.AddDbContext<FleetUpDbContext>(opt=>{
                    opt.UseSqlite(config.GetConnectionString("FleetUpSqLite"));
                });
                services.AddScoped<IAssetRepository,AssetRepository>();
                services.AddScoped<IContractorRepository,ContractorRepository>();
                services.AddScoped<IWorkOrderRepository,WorkOrderRepository>();
                services.AddScoped<ScheduleRepository,ScheduleRepository>(); 

        }
        
    }
}