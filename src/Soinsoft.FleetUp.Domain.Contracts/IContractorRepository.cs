using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Contracts
{
    public interface IContractorRepository:IRepository<Contractor>, IAggregate
    {
        
    }
}