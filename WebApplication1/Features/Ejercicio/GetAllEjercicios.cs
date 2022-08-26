using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Infraestructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Features
{
    public class GetAllEjercicios : IRequestHandler<GetAllEjerciciosRequest, IEnumerable<GetAllEjerciciosResponse>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllEjercicios(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetAllEjerciciosResponse>> Handle(GetAllEjerciciosRequest request, CancellationToken cancellationToken)
        {
            var ejercicios = await _dbContext.Ejercicio.ToListAsync(cancellationToken);

            return ejercicios.Select(ej => new GetAllEjerciciosResponse
            {
                Id = ej.Id,
                Name = ej.Name,
                IsDone = ej.IsDone,
                Category = ej.Category,
                IsActive = ej.IsActive
            });
        }
    }
}