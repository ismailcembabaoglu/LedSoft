using Ardalis.GuardClauses;
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

namespace LedSoft.Persistence.Features.Stok.Queries
{
    public class GetStokTanimByIdRequest:IRequest<ServiceResponse<StokTanimDTO>>
    {
        public int StokId { get; set; }
    }
    public class GetStokTanimByIdHandeler : IRequestHandler<GetStokTanimByIdRequest, ServiceResponse<StokTanimDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetStokTanimByIdHandeler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<StokTanimDTO>> Handle(GetStokTanimByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _context.Stoktanims.AsNoTracking().ProjectTo<StokTanimDTO>(_mapper.ConfigurationProvider).Where(c => c.Id == request.StokId).FirstOrDefaultAsync(cancellationToken);
            Guard.Against.Null(result,message:"Ürün Bulunamadı!!");
            return new ServiceResponse<StokTanimDTO>()
            {
                Value = result,
            };

            //var fiyat = await _context.Fiyatlistes.AsNoTracking().Join(_context.FiyatlisteDetays, fiyats => fiyats.Id, fiyatDetay => fiyatDetay.Fiyatlisteid, (fiyats, fiyatDetay) => new
            //{
            //    fiyatDetay.Stokid,
            //    fiyatDetay.Fiyat,
            //    fiyats.Islemtip,
            //}).Where(c=>c.Stokid==request.StokId).ToListAsync(cancellationToken);
            //var tempResult = await(from st in _context.Stoktanims.AsNoTracking()
            //                       join k in _context.Kategoris.AsNoTracking() on st.Kategori1id!.Value equals k.Id into kategoris
            //                       from k in kategoris.DefaultIfEmpty()
            //                       join b in _context.StoktanimBirims.AsNoTracking() on st.Birimid equals b.Id into birims
            //                       from b in birims.DefaultIfEmpty()
            //                       where st.Id==request.StokId
            //                       select new StokListDTO
            //                       {
            //                           Birim = b != null ? b.Isim : null,
            //                           Birimid = b != null ? b.Id : 0,
            //                           Id = st.Id,
            //                           Isim = st.Isim,
            //                           StokKod = st.Kod,
            //                           Kategori = k.Isim != null ? k.Isim : null,
            //                           Kategori1id = st.Kategori1id != null ? st.Kategori1id : null,
            //                           Kisaisim = st.Kisaisim
            //                       }).FirstOrDefaultAsync();
            //tempResult!.AlisFiyat = fiyat.FirstOrDefault(c => c.Islemtip == "F1")?.Fiyat ?? 0;
            //tempResult!.SatisFiyat = fiyat.FirstOrDefault(c => c.Islemtip == "F2")?.Fiyat ?? 0;
            //return new ServiceResponse<StokListDTO>()
            //{
            //    Value = tempResult,
            //};

        }
    }
}
