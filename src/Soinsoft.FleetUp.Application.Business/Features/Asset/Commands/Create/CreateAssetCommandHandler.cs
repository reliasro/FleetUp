using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Domain.Contracts;

namespace Soinsoft.FleetUp.Application.Business.Features.Asset.Commands.Create
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
              await assetRepo.SaveAsync();
           }
           catch (System.Exception)
           {
               
               return 0;
           }  
           return 1; 
        }
    }
}