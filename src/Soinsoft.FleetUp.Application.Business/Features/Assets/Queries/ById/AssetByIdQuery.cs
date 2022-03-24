using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Soinsoft.FleetUp.Application.Contracts.DTOs;

namespace Soinsoft.FleetUp.Application.Business.Features.Assets.Queries.ById
{
    public class AssetByIdQuery: IRequest<AssetDto>
    {
        public int Id { get; set; }
    }
}