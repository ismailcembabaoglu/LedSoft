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

namespace LedSoft.Persistence.Features.Stok.Queries
{

    public class GetAllStokTanimRequest : IRequest<ServiceResponse<List<StokListDTO>>>
    {

    }
    public class GetAllStokTanimHandler : IRequestHandler<GetAllStokTanimRequest, ServiceResponse<List<StokListDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetAllStokTanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {

            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<List<StokListDTO>>> Handle(GetAllStokTanimRequest request, CancellationToken cancellationToken)
        {
            var fiyat = await _context.Fiyatlistes.AsNoTracking().Join(_context.FiyatlisteDetays, fiyats => fiyats.Id, fiyatDetay => fiyatDetay.Fiyatlisteid, (fiyats, fiyatDetay) => new
            {
                fiyatDetay.Stokid,
                fiyatDetay.Fiyat,
                fiyats.Islemtip,
            }).ToListAsync(cancellationToken);
            var tempResult = await (from st in _context.Stoktanims.AsNoTracking()
                            join k in _context.Kategoris.AsNoTracking() on st.Kategori1id!.Value equals k.Id into kategoris
                             from k in kategoris.DefaultIfEmpty()
                             join b in _context.StoktanimBirims.AsNoTracking() on st.Birimid equals b.Id into birims
                             from b in birims.DefaultIfEmpty()
                             select new
                             {
                                 Birim = b != null ? b.Isim : null,
                                 Birimid = b != null ? b.Id :0,
                                 Id = st.Id,
                                 Isim = st.Isim,
                                 StokKod = st.Kod,
                                 Kategori = k.Isim != null ? k.Isim : null,
                                 Kategori1id = st.Kategori1id!=null? st.Kategori1id : null,
                                 Kisaisim = st.Kisaisim
                             }).ToListAsync();

            var baseData = tempResult;
            var finalResult = baseData.Select(st => new StokListDTO
            {
                Birim = st.Birim,
                Birimid = st.Birimid,
                Id = st.Id,
                Isim = st.Isim,
                StokKod = st.StokKod,
                Kategori = st.Kategori,
                Kategori1id = st.Kategori1id,
                Kisaisim = st.Kisaisim,
                AlisFiyat = fiyat.FirstOrDefault(c => c.Islemtip == "F1" && c.Stokid == st.Id)?.Fiyat ?? 0,
                SatisFiyat = fiyat.FirstOrDefault(c => c.Islemtip == "F2" && c.Stokid == st.Id)?.Fiyat ?? 0
            }).ToList();
            return new ServiceResponse<List<StokListDTO>>()
            {
                Value = finalResult,
            };
        }
    }
}
