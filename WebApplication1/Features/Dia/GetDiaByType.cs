using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Infraestructure.Persistence.DbContexts;

namespace WebApplication1.Features.Dia
{
    public class GetDiaByType : IRequestHandler<GetDiaByTypeRequest, GetDiaByTypeResponse>
    {
        private readonly AppDbContext _dbContext;

        public GetDiaByType(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<GetDiaByTypeResponse> Handle(GetDiaByTypeRequest request, CancellationToken cancellationToken)
        {
            var dia = await _dbContext.Dias.SingleOrDefaultAsync(dia => dia.Type == request.Type, cancellationToken);
            
            if(dia == null){
                throw new Exception();
            }   

            return new GetDiaByTypeResponse{
                Type = dia.Type,
                Name = dia.Name,
                IsFinished = dia.IsFinished
            };
        }
    }
}