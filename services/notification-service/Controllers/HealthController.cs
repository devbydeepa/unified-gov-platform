using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Notification Service is running");
    }
}
