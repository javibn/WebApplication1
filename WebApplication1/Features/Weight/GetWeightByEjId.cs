using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Features.Weight;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features.Weight
{
    public class GetWeightByEjId : IRequestHandler<GetWeightByEjIdRequest, IEnumerable<GetWeightByEjIdResponse>>
    {
        private readonly AppDbContext _dbContext;

        public GetWeightByEjId(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetWeightByEjIdResponse>> Handle(GetWeightByEjIdRequest request, CancellationToken cancellationToken)
        {
            var pesos = await _dbContext.Weights.Where(peso => peso.EjercicioId == request.IdEj).ToListAsync(cancellationToken);


            return pesos.Select(peso => new GetWeightByEjIdResponse
            {
                Id = peso.Id,
                IsOfJavi = peso.IsOfJavi,
                IsMoreRecent = peso.IsMoreRecent,
                Date = peso.Date,
                EjercicioId = peso.EjercicioId,
                Peso = peso.Peso
            });
        }
    }
}