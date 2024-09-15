using LedSoft.Persistence.Features.StokTanimBarkod.Commands;
using LedSoft.Persistence.Features.User.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
    }
}
