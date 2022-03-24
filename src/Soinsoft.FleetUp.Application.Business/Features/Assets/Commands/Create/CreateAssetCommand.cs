using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Create
{
    public class CreateAssetCommand: IRequest<int>
    {
        public string VIN { get; set; }
        public string Description { get; set; }
        public decimal CurrentValue { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
    }
    
}