using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Delete
{
    public class DeleteAssetCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}