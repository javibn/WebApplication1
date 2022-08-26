using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features
{
    public class GetAllEjerciciosRequest : IRequest<IEnumerable<GetAllEjerciciosResponse>>
    {
        
    }
}