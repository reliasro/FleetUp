using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Soinsoft.FleetUp.Application.Business.Features.Asset.Commands.Create
{
    public class CreateAssetCommand: IRequest<int>
    {
        public int Costo { get; set; }
        public string Usuario { get; set; }
    }
    
}