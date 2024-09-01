using LedSoft.Persistence.Features.Birim.Queries;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.Stok.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StokController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StokController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateStokTanim(CreateStokTanimRequest request,CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request,cancellationToken));
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateStokTanim(UpdateStokTanimRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpGet("GetStokTanims")]
        public async Task<IActionResult> GetStokTanims(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetAllStokTanimRequest(), cancellationToken));
        }
        [HttpGet("GetStokTanimBirims")]
        public async Task<IActionResult> GetStokTanimBirims(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetAllBirimsRequest(), cancellationToken));
        }
        [HttpGet("GetStokTanimById")]
        public async Task<IActionResult> GetStokTanimById([FromQuery]GetStokTanimByIdRequest request,CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
    }
}
