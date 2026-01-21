using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class NotificationController : ControllerBase
{
    [HttpGet]
    public IActionResult GetNotifications()
    {
        return Ok("Notification endpoint placeholder");
    }
}
