using Microsoft.AspNetCore.Mvc;

namespace IdentityService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class AuthController : ControllerBase
{
    [HttpGet("placeholder")]
    public IActionResult Get()
    {
        return Ok("Auth endpoint placeholder");
    }
}
