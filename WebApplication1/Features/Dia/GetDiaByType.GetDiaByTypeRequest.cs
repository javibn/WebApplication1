using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Dia
{
    public class GetDiaByTypeRequest: IRequest<GetDiaByTypeResponse>
    {
        public GetDiaByTypeRequest(int type)
        {
            Type= type;
        }
        public int Type { get; set;}

    }
}