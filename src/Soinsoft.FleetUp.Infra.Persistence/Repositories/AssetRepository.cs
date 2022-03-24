using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Infra.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private readonly FleetUpDbContext _context;
        private  Asset entity;
        public AssetRepository(FleetUpDbContext context)
        {
            _context = context;
        }

        public void Delete(Asset entity)
        {
            this.entity=entity;
            var item = _context.Assets.SingleOrDefault(p=> p.Id==entity.Id);
            if (item!=null){
                _context.Assets.Remove(item);
            }
        }

        public async Task<Asset> GetById(int Id)
        {
            var item = await (_context.Assets.Where(p=> p.Id==Id)).FirstOrDefaultAsync();
            return item;
        }

        public async Task<List<Asset>> GetAll()
        {
             return await _context.Assets.ToListAsync();
        }

        public async Task Insert(Asset entity)
        {
           this.entity=entity;
            await _context.Assets.AddAsync(entity);
        }

        public async Task<int> SaveAsync()
        {
            await _context.SaveChangesAsync();
            return this.entity.Id;
        }

        public void Update(Asset entity)
        {
            this.entity=entity;
            _context.Entry(entity).State=EntityState.Modified;
        }
    }
}