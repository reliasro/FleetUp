using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        public void Delete(Maintenance entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Maintenance>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Maintenance> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Maintenance entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Maintenance entity)
        {
            throw new NotImplementedException();
        }
    }
}