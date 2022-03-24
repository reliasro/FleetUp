using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Create
{
    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, int>
    {
        private readonly IMediator mediator; //For sending event notifications 
        private readonly IAssetRepository assetRepo;

        public CreateAssetCommandHandler(IMediator mediator, IAssetRepository assetRepo)
        {
            this.mediator = mediator;
            this.assetRepo = assetRepo;
        }

        public async Task<int> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
           try
           {
             await assetRepo.Insert(new Asset(){
                VIN=request.VIN,
                Description=request.Description,
                CurrentValue=request.CurrentValue,
                Model=request.Model,
                Make=request.Make,
                Year=request.Year,
                Color=request.Color
              });
             return await assetRepo.SaveAsync();
           }
           catch (System.Exception e)
           {
              throw new Exception("An error occurred at Create Asset...",e);
           }  
        }
    }
}