using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Dia
{
    public class CreateDiaRequest : IRequest<CreateDiaResponse>
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public bool IsFinished { get; set; }

    }
}