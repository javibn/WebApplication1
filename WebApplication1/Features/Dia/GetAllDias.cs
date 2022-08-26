using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features
{
    public class GetAllDias : IRequestHandler<GetAllDiasRequest, IEnumerable<GetAllDiasResponse>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllDias(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetAllDiasResponse>> Handle(GetAllDiasRequest request, CancellationToken cancellationToken)
        {
            var dias = await _dbContext.Dias.ToListAsync(cancellationToken);

            return dias.Select(dia => new GetAllDiasResponse
            {
                Name = dia.Name,
                Type = dia.Type,
                IsFinished = dia.IsFinished
            });
        }

    }
}

