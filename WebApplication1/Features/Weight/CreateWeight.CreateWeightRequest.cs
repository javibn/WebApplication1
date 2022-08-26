using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication1.Features.Weight
{
    public class CreateWeightRequest : IRequest<CreateWeightResponse>
    {
        public bool IsOfJavi { get; set; }
        public bool IsMoreRecent { get; set; }
        public Guid EjercicioId { get; set; }
        public float Peso { get; set; }

    }
}