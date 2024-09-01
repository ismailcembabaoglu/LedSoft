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
    public class CreateStoktanimBarkodHandler : IRequestHandler<CreateStokTanimBarkodRequest, ServiceResponse<StoktanimBarkodDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateStoktanimBarkodHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<StoktanimBarkodDTO>> Handle(CreateStokTanimBarkodRequest request, CancellationToken cancellationToken)
        {
            var dbStokBarkod=await _context.StoktanimBarkods.AsNoTracking().Where(c=>c.Id==request.Id).FirstOrDefaultAsync(cancellationToken);
            if (dbStokBarkod is not null)
                throw new Exception("Barkod Tanımı Zaten var.");
            dbStokBarkod = _mapper.Map<StoktanimBarkod>(request);
           await _context.StoktanimBarkods.AddAsync(dbStokBarkod,cancellationToken);
         int result=   await _context.SaveChangesAsync(cancellationToken);
            return new ServiceResponse<StoktanimBarkodDTO>()
            {
                Value = result > 0 ? _mapper.Map<StoktanimBarkodDTO>(dbStokBarkod) : new StoktanimBarkodDTO()
            };

        }
    }
}
