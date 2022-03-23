using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Infra.Persistence.Data;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private readonly FleetUpDbContext _context;
        public AssetRepository(FleetUpDbContext context)
        {
            _context = context;
        }

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
           await _context.Assets.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Asset entity)
        {
            await Task.Run(()=>Console.Write("temporal holder"));
        }
    }
}