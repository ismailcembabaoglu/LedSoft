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

namespace LedSoft.Persistence.Features.StokTanimBarkod.Queries
{

    public class GetAllBarkodStokByIdRequest:IRequest<ServiceResponse<List<StoktanimBarkodDTO>>>
    {
        public int StokId { get; set; }
    }
    public class GetAllBarkodStokByIdHandler : IRequestHandler<GetAllBarkodStokByIdRequest, ServiceResponse<List<StoktanimBarkodDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetAllBarkodStokByIdHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<List<StoktanimBarkodDTO>>> Handle(GetAllBarkodStokByIdRequest request, CancellationToken cancellationToken)
        {
            var dbBarkods = await _context.StoktanimBarkods.AsNoTracking().Where(c => c.Stokid == request.StokId).Join(_context.StoktanimBirims,barkod=>barkod.Birimid,birim=>birim.Id,(barkod,birim)=> new
            {
                barkod,
                birim
            }).Select(c=>new StoktanimBarkodDTO
            {
                Id=c.barkod.Id,
                Ambalajbirimid=c.barkod.Ambalajbirimid,
                Ambalajmiktar=c.barkod.Ambalajmiktar,
                Barkod = c.barkod.Barkod,
                Birimid = c.barkod.Birimid,
                Carpan = c.barkod.Carpan,
                Esikdegerkullan = c.barkod.Esikdegerkullan,
                Sablonid = c.barkod.Sablonid,
                Stokid = c.barkod.Stokid,
                Varyasyonid = c.barkod.Varyasyonid,
                BirimName=c.birim.Isim
            }).ToListAsync(cancellationToken);
            if (dbBarkods==null)
                return new ServiceResponse<List<StoktanimBarkodDTO>>()
                {
                    Value = new List<StoktanimBarkodDTO>()
                };
            return new ServiceResponse<List<StoktanimBarkodDTO>>()
            {
                Value = dbBarkods
            };
        }
    }
}
