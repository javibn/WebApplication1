using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Weight
{
    public class GetWeightByEjIdRequest: IRequest<IEnumerable<GetWeightByEjIdResponse>>
    {
        public GetWeightByEjIdRequest(Guid idEj)
        {
            IdEj= idEj;
        }
        public Guid IdEj { get; set;}

    }
}