using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Soinsoft.FleetUp.Infra.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Soinsoft.FleetUp.Infra.Persistence.Container
{
    public static class PersistenceServices
    {
        public static void Register(IServiceCollection services, IConfiguration config){

                services.AddDbContext<FleetUpDbContext>(opt=>{
                    opt.UseSqlite(config.GetConnectionString("FleetUpSqLite"));
                });

        }
        
    }
}