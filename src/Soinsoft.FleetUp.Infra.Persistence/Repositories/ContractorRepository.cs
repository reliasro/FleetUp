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
    public class ContractorRepository : IContractorRepository
    {
        private readonly FleetUpDbContext _context;
        private  Contractor entity;

        public ContractorRepository(FleetUpDbContext context)
        {
            _context = context;
  
        }

        public void Delete(Contractor entity)
        {
            this.entity=entity;
            var item = _context.Contractors.
            Where(p=> p.Id==entity.Id).SingleOrDefault();
            _context.Contractors.Remove(item);
        }

        public async Task<Contractor> GetById(int Id)
        {
            return await (_context.Contractors.
            Where(p=> p.Id==Id)).FirstOrDefaultAsync();
        }

        public async Task<List<Contractor>> GetAll()
        {
             return await _context.Contractors.ToListAsync();
        }

        public async Task Insert(Contractor entity)
        {
            this.entity=entity;
            await _context.Contractors.AddAsync(entity);
        }

        public async Task<int> SaveAsync()
        {
            await _context.SaveChangesAsync();
            return this.entity.Id;
        }

        public void Update(Contractor entity)
        {
           this.entity=entity;
           _context.Entry(entity).State=EntityState.Modified;
        }
    }
}