using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Features.Ejercicio
{
    public class CreateEjercicioResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public int Category { get; set; }
        public bool IsActive { get; set; } 
    }
}