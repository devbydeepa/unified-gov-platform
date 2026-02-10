using Microsoft.AspNetCore.Mvc;

namespace WorkflowService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class WorkflowController : ControllerBase
{
    // GET all applications (placeholder)
    [HttpGet("applications")]
    public IActionResult GetApplications()
    {
        var applications = new[]
        {
            new { Id = 1, ServiceName = "Address Change Certificate", Status = "DRAFT" },
            new { Id = 2, ServiceName = "Passport Renewal", Status = "SUBMITTED" }
        };
        return Ok(applications);
    }

    // POST create application (placeholder)
    [HttpPost("applications")]
    public IActionResult CreateApplication()
    {
        // Placeholder response
        return Ok("Application created (placeholder)");
    }

    // PUT update application status (placeholder)
    [HttpPut("applications/{id}/status")]
    public IActionResult UpdateStatus(int id)
    {
        return Ok($"Application {id} status updated (placeholder)");
    }
}
