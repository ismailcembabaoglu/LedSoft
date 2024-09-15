using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using LedSoft.Persistence.Extensions;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Server.Middlewares;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.ConfigureMapping();
builder.Services.AddApplicationServices();
builder.Services.AddDbContext<LafSadikContext>(config =>
{

    config.UseSqlServer(configuration.GetConnectionString("Mssql"));
    config.EnableSensitiveDataLogging();
});
builder.Services.AddSwaggerGen(option =>
{
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "LedSoft", Version = "v1" });
    option.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
});
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true,
        ValidIssuer = configuration["JwtIssuer"],
        ValidAudience = configuration["JwtAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]


        ))
    };
});
builder.Services.AddCors(options =>
     options.AddDefaultPolicy(builder =>
     builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "LedSoft API V1");
});
app.UseHttpsRedirection();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
