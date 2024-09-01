using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using LedSoft.Persistence.Features.Kategori.Query;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.Stok.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            service.AddTransient<IRequestHandler<CreateStokTanimRequest, ServiceResponse<StokTanimDTO>>, CreateStokTanimHandler>();
            service.AddTransient<IRequestHandler<UpdateStokTanimRequest, ServiceResponse<StokTanimDTO>>, UpdateStokTanimHandler>();
            service.AddTransient<IRequestHandler<GetStokTanimByIdRequest, ServiceResponse<StokListDTO>>, GetStokTanimByIdHandeler>();
            service.AddTransient <IRequestHandler<GetallKategoriRequest, ServiceResponse<List<KategoriDTO>>>, GetallKategoriHandler >();

            service.AddTransient<IRequestHandler<GetAllStokTanimRequest, ServiceResponse<List<StokListDTO>>>, GetAllStokTanimHandler>();
            service.AddScoped<LafSadikContext>();
            return service;
        }
    }
}
