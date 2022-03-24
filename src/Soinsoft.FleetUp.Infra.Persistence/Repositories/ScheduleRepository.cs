using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        public void Delete(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Schedule>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Schedule> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Schedule entity)
        {
            throw new NotImplementedException();
        }
    }
}