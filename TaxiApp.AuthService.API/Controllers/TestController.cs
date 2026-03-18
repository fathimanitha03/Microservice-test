using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaxiApp.AuthService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult Public()
    {
        return Ok("Public endpoint - no auth needed");
    }

    [HttpGet("protected")]
    [Authorize]
    public IActionResult Protected()
    {
        return Ok("Protected endpoint - valid token required");
    }

    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public IActionResult Admin()
    {
        return Ok("Admin only endpoint");
    }

    [HttpGet("rider")]
    [Authorize(Roles = "Rider")]
    public IActionResult Rider()
    {
        return Ok("Rider only endpoint");
    }
}