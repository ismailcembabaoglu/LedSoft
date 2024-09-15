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

namespace LedSoft.Persistence.Features.Stok.Commands
{
    public class UpdateStokTanimHandler : IRequestHandler<UpdateStokTanimRequest, ServiceResponse<StokTanimDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UpdateStokTanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<StokTanimDTO>> Handle(UpdateStokTanimRequest request, CancellationToken cancellationToken)
        {
           var dbStokTanim= await _context.Stoktanims.AsNoTracking().Where(c=>c.Id==request.Id).FirstOrDefaultAsync();
            Guard.Against.Null(dbStokTanim, message: "Ürün Bulunamadı");
            _mapper.Map(request, dbStokTanim);
            _context.Stoktanims.Update(dbStokTanim);
            int result = await _context.SaveChangesAsync();
            return new ServiceResponse<StokTanimDTO>()
            {
                Value = _mapper.Map<StokTanimDTO>(dbStokTanim)
            };
        }
    }
}
