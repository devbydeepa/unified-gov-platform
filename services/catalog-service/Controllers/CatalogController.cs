using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class CatalogController : ControllerBase
{
    [HttpGet]
    public IActionResult GetServices()
    {
        return Ok("Service catalog endpoint placeholder");
    }
}
