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
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Stok.Commands
{

    public class CreateStokTanimHandler : IRequestHandler<CreateStokTanimRequest, ServiceResponse<StokTanimDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateStokTanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<StokTanimDTO>> Handle(CreateStokTanimRequest request, CancellationToken cancellationToken)
        {
           var dbStokTanim= await _context.Stoktanims.AsNoTracking().Where(c=>c.Id==request.Id || c.Kod == request.Kod).FirstOrDefaultAsync();
            if (dbStokTanim != null)
                throw new Exception("Stok Tanımı Zaten Bulunmakta");
            request.Resim = null;
            request.Resim2 = null;
            request.Resim3 = null;
            request.PerakendeUrunlisteGorsel = null;
            dbStokTanim=_mapper.Map<Stoktanim>(request);
            await _context.Stoktanims.AddAsync(dbStokTanim);
            int result=await _context.SaveChangesAsync();

            return new ServiceResponse<StokTanimDTO>()
            {
                Value =result>0? _mapper.Map<StokTanimDTO>(dbStokTanim):new StokTanimDTO()
            };
        }
    }
}
