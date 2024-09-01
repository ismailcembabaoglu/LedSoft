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

namespace LedSoft.Persistence.Features.Birim.Queries
{
    public class GetAllBirimsRequest : IRequest<ServiceResponse<List<StokTanimBirimDTO>>>
    {

    }
    public class GetAllBirimsHandler : IRequestHandler<GetAllBirimsRequest, ServiceResponse<List<StokTanimBirimDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetAllBirimsHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<List<StokTanimBirimDTO>>> Handle(GetAllBirimsRequest request, CancellationToken cancellationToken)
        {
            var birims = await _context.StoktanimBirims.AsNoTracking().ProjectTo<StokTanimBirimDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            if (birims == null)
                return new ServiceResponse<List<StokTanimBirimDTO>>();
            return new ServiceResponse<List<StokTanimBirimDTO>>
            {
                Value = birims
            };
        }
    }
}
