using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class AssetRepository : IAssetRepository
    {
 
        public async Task Delete(Asset entity)
        {
            await Task.Run(()=>Console.Write("temporal holder"));
        }

        public Asset Get()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Asset>> GetAll()
        {
             return await Task.Run(()=>
            {
              return new List<Asset>();
            });
        }

        public async Task Insert(Asset entity)
        {
           await Task.Run(()=>Console.Write("temporal holder"));
        }

        public async Task SaveAsync()
        {
            await Task.Run(()=>Console.Write("temporal holder"));
        }

        public async Task Update(Asset entity)
        {
            await Task.Run(()=>Console.Write("temporal holder"));
        }
    }
}