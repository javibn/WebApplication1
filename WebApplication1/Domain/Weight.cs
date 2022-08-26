using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Domain
{
    public class Weight
    {
        public Guid Id { get; set; }
        public bool IsOfJavi { get; set; }
        public DateTime Date { get; set; }
        public bool IsMoreRecent { get; set; }
        public Guid EjercicioId { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public float Peso { get; set; }
    }
}