using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Infra.Persistence.Data;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly FleetUpDbContext _context;

        public ContractorRepository(FleetUpDbContext context)
        {
            _context = context;
  
        }

        public async Task Delete(Contractor entity)
        {
            await Task.Run(()=>Console.Write("temporal holder"));
        }

        public Contractor Get()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contractor>> GetAll()
        {
             return await Task.Run(()=>
            {
              return new List<Contractor>();
            });
        }

        public async Task Insert(Contractor entity)
        {
            await _context.Contractors.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Contractor entity)
        {
           await Task.Run(()=>Console.Write("temporal holder"));
        }
    }
}