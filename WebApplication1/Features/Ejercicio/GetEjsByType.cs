using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Infraestructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Features.Ejercicio
{
    public class GetEjsByType : IRequestHandler<GetEjsByTypeRequest, IEnumerable<GetEjsByTypeResponse>>
    {
        private readonly AppDbContext _dbContext;

        public GetEjsByType(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetEjsByTypeResponse>> Handle(GetEjsByTypeRequest request, CancellationToken cancellationToken)
        {
            var ejercicios = await _dbContext.Ejercicio.Where(ej => ej.Category == request.Type /*&& ej.IsActive==true*/).ToListAsync(cancellationToken);

            return ejercicios.Select(ej => new GetEjsByTypeResponse
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