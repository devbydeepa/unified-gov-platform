using Microsoft.AspNetCore.Mvc;

namespace DocumentService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Document Service is running");
    }
}
