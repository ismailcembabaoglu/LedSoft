using Ardalis.GuardClauses;
using AutoMapper;
using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.StokTanimBarkod.Commands
{
    public class UpdateStokTanimBarkodHandler : IRequestHandler<UpdateStokStanimBarkodRequest, ServiceResponse<StoktanimBarkodDTO>>
    {
       private readonly LafSadikContext _context;
       private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UpdateStokTanimBarkodHandler(LafSadikContext context,IMapper mapper,IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<StoktanimBarkodDTO>> Handle(UpdateStokStanimBarkodRequest request, CancellationToken cancellationToken)
        {
            var dbStokBarkod = await _context.StoktanimBarkods.AsNoTracking().Where(c => c.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            Guard.Against.Null(dbStokBarkod, "Barkod Bulunamadığı için güncelleme işlemi yapılamıyor");
            _mapper.Map(request, dbStokBarkod);
            _context.StoktanimBarkods.Update(dbStokBarkod);
           int result =await _context.SaveChangesAsync(cancellationToken);
            return new ServiceResponse<StoktanimBarkodDTO>()
            {
                Value = _mapper.Map<StoktanimBarkodDTO>(dbStokBarkod)
            };
        }
    }
}
