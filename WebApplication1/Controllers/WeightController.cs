using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Features.Weight;

namespace WebApplication1.Controllers
{
    public class WeightController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<CreateWeightResponse>> CreateWeight(CreateWeightRequest request)
        {
            var newPeso = await Mediator.Send(request);

            return Ok(newPeso);
        }

        
        [HttpGet]
        [Route("{idEj:guid}")]
        public async Task<ActionResult<GetWeightByEjIdResponse>> GetWeightByEjId(Guid idEj)
        {
            var peso = await Mediator.Send(new GetWeightByEjIdRequest(idEj));
            
            return Ok(peso);
        }  
        
    }
}