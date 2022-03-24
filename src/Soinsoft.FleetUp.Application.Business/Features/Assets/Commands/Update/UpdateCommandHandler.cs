using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateAssetCommand, int>
    {
        private readonly IAssetRepository repository;

        public UpdateCommandHandler(IAssetRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(UpdateAssetCommand request, CancellationToken cancellationToken)
        {
             repository.Update(new Asset(){
                Id=request.Id, 
                VIN=request.VIN,
                Description=request.Description,
                Model=request.Model,
                Make=request.Make,
                Year=request.Year,
                Color=request.Color
              });
            return await repository.SaveAsync();
        }
    }
}