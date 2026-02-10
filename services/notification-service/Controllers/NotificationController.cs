using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class NotificationController : ControllerBase
{
    // GET all notifications (placeholder)
    [HttpGet]
    public IActionResult GetNotifications()
    {
        var notifications = new[]
        {
            new { Id = 1, Message = "Your Address Change Certificate is approved" },
            new { Id = 2, Message = "Passport Renewal submitted" }
        };
        return Ok(notifications);
    }

    // POST send notification (placeholder)
    [HttpPost("send")]
    public IActionResult SendNotification()
    {
        // Placeholder response
        return Ok("Notification sent (placeholder)");
    }
}
