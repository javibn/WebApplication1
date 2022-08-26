using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Features;
using WebApplication1.Features.Dia;

namespace WebApplication1.Controllers
{
    public class DiaContoller : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllDiasResponse>>> GetAllDias()
        {
            var dias = await Mediator.Send(new GetAllDiasRequest());

            return Ok(dias);
        }

        [HttpPost]
        public async Task<ActionResult<CreateDiaResponse>> CreateDias(CreateDiaRequest request)
        {
            var newDia = await Mediator.Send(request);

            return Ok(newDia);
        }

        [HttpGet]
        [Route("{type:int}")]
        public async Task<ActionResult<GetDiaByTypeResponse>> GetDiaByType(int type)
        {
            try
            {
                var dia = await Mediator.Send(new GetDiaByTypeRequest(type));
                return Ok(dia);
            }
            catch
            {
                return NotFound();
            }
        }     
        
    }
}