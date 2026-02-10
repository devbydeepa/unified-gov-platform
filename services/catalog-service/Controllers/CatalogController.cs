using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class CatalogController : ControllerBase
{
    [HttpGet]
    public IActionResult GetServices()
    {
      var services = new[]
        {
            new { Id = 1, Name = "Passport" },
            new { Id = 2, Name = "Address Change Certificate" },
            new { Id = 3, Name = "Birth Certificate" }
        };
        return Ok(services);
    }
    // GET service by ID
    [HttpGet("{id}")]
    public IActionResult GetService(int id)
    {
        // Placeholder response
        var service = new { Id = id, Name = $"Service {id}" };
        return Ok(service);
    }
}
