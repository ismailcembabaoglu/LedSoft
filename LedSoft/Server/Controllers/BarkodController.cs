using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.Stok.Queries;
using LedSoft.Persistence.Features.StokTanimBarkod.Commands;
using LedSoft.Persistence.Features.StokTanimBarkod.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BarkodController : ControllerBase
    {   
        IMediator _mediator;
        public BarkodController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateBarkodTanim(CreateStokTanimBarkodRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateBarkodTanim(UpdateStokStanimBarkodRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpGet("GetStokBarkodsById")]
        public async Task<IActionResult> GetStokBarkodsById([FromQuery] GetAllBarkodStokByIdRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
    }
}
