using AutoMapper;
using LedSoft.Application.DTOs;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.StokTanimBarkod.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Fiyatliste,FiyatlisteDTO>().ReverseMap();
          
                CreateMap<FiyatlisteDetay,FiyatlisteDetayDTO>().ReverseMap();

                CreateMap<Kategori,KategoriDTO>().ReverseMap();

                CreateMap<StoktanimBarkod,StoktanimBarkodDTO>().ReverseMap();
                CreateMap<StoktanimBarkod, CreateStokTanimBarkodRequest>().ReverseMap();
                CreateMap<StoktanimBarkod, UpdateStokStanimBarkodRequest>().ReverseMap();

                CreateMap<StoktanimBarkodsablon,StoktanimBarkodSablonDTO>().ReverseMap();

                CreateMap<StoktanimBirim,StokTanimBirimDTO>().ReverseMap();

                CreateMap<Stoktanim,StokTanimDTO>().ReverseMap();
                CreateMap<CreateStokTanimRequest, Stoktanim>().ReverseMap();
                CreateMap<UpdateStokTanimRequest, Stoktanim>().ReverseMap();
                CreateMap<User, UserDTO>().ReverseMap();

            }
        }
    }
}
