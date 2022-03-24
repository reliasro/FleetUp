using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Application.Contracts.DTOs;
using Soinsoft.FleetUp.Domain.Contracts;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Queries.GetAll
{
    public class AllAssetsQueryHandler : IRequestHandler<AllAssetsQuery, List<AssetDto>>
    {
        private readonly IAssetRepository repository;

        public AllAssetsQueryHandler(IAssetRepository repository)
        {
            this.repository = repository;
        }

        public Task<List<AssetDto>> Handle(AllAssetsQuery request, CancellationToken cancellationToken)
        {
            var lista =repository.GetAll().Result;
            return Task.FromResult((from s in lista select new AssetDto(){
                      Id=s.Id,
                      Description=s.Description,
                      VIN=s.VIN,
                      Model=s.Model,
                      Make=s.Make,
                      Year=s.Year,
                      Color=s.Color
                  }
            ).ToList()); 
        }
    }
}