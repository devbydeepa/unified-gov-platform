using Microsoft.AspNetCore.Mvc;

namespace WorkflowService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Workflow Service is running");
    }
}
