using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features.Ejercicio
{
    public class CreateEjercicio : IRequestHandler<CreateEjercicioRequest, CreateEjercicioResponse>
    {
        private readonly AppDbContext _dbContext;

        public CreateEjercicio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateEjercicioResponse> Handle(CreateEjercicioRequest request, CancellationToken cancellationToken)
        {
            var newEj = new WebApplication1.Domain.Ejercicio
            {
                Id = Guid.NewGuid(),
                IsActive = request.IsActive,
                Category = request.Category,
                IsDone = request.IsDone,
                Name = request.Name
            };

            await _dbContext.Ejercicio.AddAsync(newEj, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return new CreateEjercicioResponse
            {
                Id = newEj.Id,
                IsActive = newEj.IsActive,
                Category = newEj.Category,
                IsDone = newEj.IsDone,
                Name = newEj.Name
            };
        }
        
    }
}