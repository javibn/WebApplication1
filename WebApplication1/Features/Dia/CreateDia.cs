using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features.Dia
{
    public class CreateDia : IRequestHandler<CreateDiaRequest, CreateDiaResponse>
    {
        private readonly AppDbContext _dbContext;

        public CreateDia(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateDiaResponse> Handle(CreateDiaRequest request, CancellationToken cancellationToken)
        {
            var newDia = new WebApplication1.Domain.Dia
            {
                Name = request.Name,
                Type = request.Type,
                IsFinished = request.IsFinished
            };

            await _dbContext.Dias.AddAsync(newDia, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return new CreateDiaResponse
            {
                Name = newDia.Name,
                Type = newDia.Type,
                IsFinished = newDia.IsFinished
            };
        }

    }
}