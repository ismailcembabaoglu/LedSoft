using Ardalis.GuardClauses;
using AutoMapper;
using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.User.Commands
{
    public class UserLoginRequest:IRequest<ServiceResponse<UserloginResponseDTO>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserLoginHandler : IRequestHandler<UserLoginRequest, ServiceResponse<UserloginResponseDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserLoginHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<UserloginResponseDTO>> Handle(UserLoginRequest request, CancellationToken cancellationToken)
        {
            var dbUser = await _context.Users.AsNoTracking().FirstOrDefaultAsync(c => c.Username == request.UserName && c.Password == request.Password,cancellationToken);
            Guard.Against.Null(dbUser, message: "Kullanıcı bulunamadı veya bilgiler yanlış");

            UserloginResponseDTO result = new UserloginResponseDTO();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(int.Parse(_configuration["JwtExpiryInDays"].ToString()));
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, request.UserName),
                new Claim(ClaimTypes.Name, dbUser.Name),
                new Claim(ClaimTypes.UserData, dbUser.Id.ToString())
            };
            var token = new JwtSecurityToken(_configuration["JwtIssuer"], _configuration["JwtAudience"], claims.ToArray(), null,null, creds);
            result.ApiToken = new JwtSecurityTokenHandler().WriteToken(token);
            result.User = _mapper.Map<UserDTO>(dbUser);
            return new ServiceResponse<UserloginResponseDTO>()
            {
                Value = result,
            };
        }
    }
}
