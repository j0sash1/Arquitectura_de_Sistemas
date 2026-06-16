using Microsoft.AspNetCore.Mvc;
using Shortly.Application.DTOs;
using Shortly.Application.Interfaces;

namespace Shortly.Controllers;

[ApiController]
[Route("api/stats")]
[Produces("application/json", "application/xml", "text/xml")]
public class StatsController : ControllerBase
{
    private readonly ILinkService _linkService;

    public StatsController(ILinkService linkService)
    {
        _linkService = linkService;
    }

    [HttpGet]
    public async Task<ActionResult<StatsResponse>> Get()
    {
        return Ok(await _linkService.GetStats());
    }
}