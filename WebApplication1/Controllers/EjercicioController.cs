using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Features;
using WebApplication1.Features.Ejercicio;

namespace WebApplication1.Controllers
{
    public class EjercicioController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllEjerciciosResponse>>> GetAllEjercicios()
        {
            var ejs = await Mediator.Send(new GetAllEjerciciosRequest());

            return Ok(ejs);
        }

        [HttpPost]
        public async Task<ActionResult<CreateEjercicioResponse>> CreateEjercicio(CreateEjercicioRequest request)
        {
            var newEj = await Mediator.Send(request);

            return Ok(newEj);
        }

        
        [HttpGet]
        [Route("{type:int}")]
        public async Task<ActionResult<IEnumerable<GetEjsByTypeResponse>>> GetEjsByType(int type)
        {
            var dias = await Mediator.Send(new GetEjsByTypeRequest(type));
            
            return Ok(dias);
        }  
        
    }
}