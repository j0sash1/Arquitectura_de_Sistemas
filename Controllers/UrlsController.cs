using Microsoft.AspNetCore.Mvc;
using Shortly.Application.DTOs;
using Shortly.Application.Interfaces;

namespace Shortly.Controllers;

[ApiController]
[Route("api/urls")]
[Produces("application/json", "application/xml", "text/xml")]
public class UrlsController : ControllerBase
{
    private readonly ILinkService _linkService;

    public UrlsController(ILinkService linkService)
    {
        _linkService = linkService;
    }

    [HttpGet]
    public async Task<ActionResult<List<LinkResponse>>> GetAll()
    {
        return Ok(await _linkService.GetAllLinks());
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<LinkResponse>> Get(long id)
    {
        try
        {
            return Ok(await _linkService.GetLinkById(id));
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPost]
    public async Task<ActionResult<LinkResponse>> Create(
        [FromBody] CreateUrlRequest request)
    {
        var result = await _linkService.CreateLink(
            request.Url,
            1); // usuario admin

        return Created(
            $"/api/urls/{result.Id}",
            result);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            await _linkService.DeleteLink(id);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }
}