using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Ejercicio
{
    public class CreateEjercicioRequest : IRequest<CreateEjercicioResponse>
    {
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public int Category { get; set; }
        public bool IsActive { get; set; }

    }
}