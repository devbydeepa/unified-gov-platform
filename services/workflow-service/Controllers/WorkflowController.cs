using Microsoft.AspNetCore.Mvc;

namespace WorkflowService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class WorkflowController : ControllerBase
{
    [HttpGet]
    public IActionResult GetWorkflows()
    {
        return Ok("Workflow endpoint placeholder");
    }
}
