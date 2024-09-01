using AutoMapper;
using AutoMapper.QueryableExtensions;
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

namespace LedSoft.Persistence.Features.Kategori.Query
{
    public class GetallKategoriRequest : IRequest<ServiceResponse<List<KategoriDTO>>>
    {
        public string? Tip { get; set; } = null;
    }
    public class GetallKategoriHandler : IRequestHandler<GetallKategoriRequest, ServiceResponse<List<KategoriDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetallKategoriHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<List<KategoriDTO>>> Handle(GetallKategoriRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Tip))
            {
                var kategories = await _context.Kategoris.AsNoTracking().ProjectTo<KategoriDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
                if (kategories == null)
                    return new ServiceResponse<List<KategoriDTO>>();
                return new ServiceResponse<List<KategoriDTO>>
                {
                    Value = kategories
                };
            }
            var kategorieses = await _context.Kategoris.AsNoTracking().ProjectTo<KategoriDTO>(_mapper.ConfigurationProvider).Where(c => c.Tip == request.Tip).ToListAsync(cancellationToken);
            if (kategorieses == null)
                return new ServiceResponse<List<KategoriDTO>>();
            return new ServiceResponse<List<KategoriDTO>>
            {
                Value = kategorieses
            };


        }
    }
}
