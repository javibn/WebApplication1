using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Ejercicio
{
    public class GetEjsByTypeRequest: IRequest<IEnumerable<GetEjsByTypeResponse>>
    {
        public GetEjsByTypeRequest(int type)
        {
            Type= type;
        }
        public int Type { get; set;}

    }
}