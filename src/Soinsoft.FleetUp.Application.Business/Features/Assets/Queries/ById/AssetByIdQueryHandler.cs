using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Application.Contracts.DTOs;
using MediatR;
using Soinsoft.FleetUp.Domain.Contracts;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Queries.ById
{
    public class AssetByIdQueryHandler : IRequestHandler<AssetByIdQuery, AssetDto>
    {
        private readonly IAssetRepository repository;

        public AssetByIdQueryHandler(IAssetRepository repository)
        {
            this.repository = repository;
        }

        public Task<AssetDto> Handle(AssetByIdQuery request, CancellationToken cancellationToken)
        {
            var item=repository.GetById(request.Id).Result;
            return Task.FromResult( new AssetDto(){
                      Id=item.Id,  
                      Description=item.Description,
                      VIN=item.VIN,
                      Model=item.Model,
                      Make=item.Make,
                      Year=item.Year,
                      Color=item.Color
            }); 
        }
    }
}