using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features.Weight
{
    public class CreateWeight : IRequestHandler<CreateWeightRequest, CreateWeightResponse>
    {
        private readonly AppDbContext _dbContext;

        public CreateWeight(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateWeightResponse> Handle(CreateWeightRequest request, CancellationToken cancellationToken)
        {
            var newPeso = new WebApplication1.Domain.Weight
            {
                Id = Guid.NewGuid(),
                IsOfJavi = request.IsOfJavi,
                Date = DateTime.Now,
                IsMoreRecent = request.IsMoreRecent,
                EjercicioId = request.EjercicioId,
                Peso = request.Peso
            };

            await _dbContext.Weights.AddAsync(newPeso, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return new CreateWeightResponse
            {
                Id = newPeso.Id,
                IsOfJavi = newPeso.IsOfJavi,
                IsMoreRecent = newPeso.IsMoreRecent,
                Date = newPeso.Date,
                EjercicioId = newPeso.EjercicioId,
                Peso = newPeso.Peso
            };
        }
    }
}