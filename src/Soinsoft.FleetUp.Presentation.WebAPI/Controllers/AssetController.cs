using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Soinsoft.FleetUp.Application.Contracts.DTOs;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Queries.GetAll;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Queries.ById;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Update;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Delete;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Create;

namespace Soinsoft.FleetUp.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly IMediator mediator;

        public AssetController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("all")]
        public ActionResult<List<AssetDto>> GetAll(){

           AllAssetsQuery qry = new AllAssetsQuery(); 
           var lista =  mediator.Send(qry).Result;
           return Ok(lista);
        }
        
        [HttpGet("{id}")]
        public ActionResult<AssetDto> GetById(int id){
          
           AssetByIdQuery qry = new(){Id=id}; 
           var item =  mediator.Send(qry).Result;
           return Ok(item);
        }
        
        [HttpPut]
        public  ActionResult Update([FromBody] AssetDto asset){
           
           UpdateAssetCommand cmd =new(){
               Id=asset.Id,
               VIN=asset.VIN,
               Description=asset.Description,
               Model=asset.Model,
               Make=asset.Make,
               Year=asset.Year,
               Color=asset.Color         
           }; 
           mediator.Send(cmd);
           return Ok();            
        }
        
        [HttpPost]
        public  ActionResult<AssetDto> Create([FromBody] AssetDto asset){
           
           CreateAssetCommand cmd =new(){
               VIN=asset.VIN,
               Description=asset.Description,
               CurrentValue=0,
               Model=asset.Model,
               Make=asset.Make,
               Year=asset.Year,
               Color=asset.Color
           }; 
           var id= mediator.Send(cmd).Result;
           return Created("", id);               
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
           
           DeleteAssetCommand cmd = new(){Id=id}; 
           mediator.Send(cmd);
           return Ok();
        }
    }
}