using Microsoft.AspNetCore.Mvc;

namespace YourShortener.Controllers;

public class LinksController : ControllerBase
{
    [HttpPost("v1/links")]
    public async Task<IActionResult> CreateLinkAsync()
    {
        throw new NotImplementedException();
    }

    [HttpGet("v1/links/{id}")]
    public async Task<IActionResult> GetLinkAsync(string id)
    {
        throw new NotImplementedException();
    }
}
