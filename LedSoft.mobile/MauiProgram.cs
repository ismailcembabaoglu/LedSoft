using Blazored.LocalStorage;
using Blazored.Modal;
using LedSoft.Application.DTOs;
using LedSoft.mobile.Data;
using LedSoft.mobile.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using Morris.Blazor.Validation;
using Radzen;

namespace LedSoft.mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddRadzenComponents();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddHttpClient();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddFormValidation(config => config.AddFluentValidation(typeof(StokTanimDTO).Assembly));

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
          

            return builder.Build();
        }
    }
}
