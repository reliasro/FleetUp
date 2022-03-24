using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;


namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Delete
{
    public class DeleteAssetCommandHandler : IRequestHandler<DeleteAssetCommand, int>
    {
        private readonly IAssetRepository repository;

        public DeleteAssetCommandHandler(IAssetRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(DeleteAssetCommand request, CancellationToken cancellationToken)
        {
            Asset item = new(){Id=request.Id}; 
            repository.Delete(item);
            return await repository.SaveAsync();
        }
    }
}