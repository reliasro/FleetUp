using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Contracts
{
    public interface IRepository<T> where T: IAggregate
    {
        IEnumerable<T> GetAll();
        T Get();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        int SaveAsync();

    }
}