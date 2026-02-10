using Microsoft.AspNetCore.Mvc;

namespace AuditService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuditController : ControllerBase
{
    // GET all audit logs (placeholder)
    [HttpGet]
    public IActionResult GetAuditLogs()
    {
        var auditLogs = new[]
        {
            new { Id = 1, Action = "User login", Timestamp = DateTime.UtcNow },
            new { Id = 2, Action = "Application submitted", Timestamp = DateTime.UtcNow }
        };
        return Ok(auditLogs);
    }

    // POST add audit log (placeholder)
    [HttpPost("log")]
    public IActionResult AddAuditLog()
    {
        // Placeholder response
        return Ok("Audit log added (placeholder)");
    }
}
