using LedSoft.Persistence.Features.Kategori.Query;
using LedSoft.Persistence.Features.Stok.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KategoriController : ControllerBase
    {
        private readonly IMediator _mediator;
        public KategoriController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllKategori")]
        public async Task<IActionResult> GetStokTanimById([FromQuery] GetallKategoriRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
    }
}
