using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Features.Dia
{
    public class CreateDiaResponse
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public bool IsFinished { get; set; }
    }
}