using Microsoft.AspNetCore.Mvc;

namespace DocumentService.Controllers;

[ApiController]
[Route("api/documents")]
public class DocumentController : ControllerBase
{
    // GET all documents (placeholder)
    [HttpGet]
    public IActionResult GetDocuments()
    {
        var documents = new[]
        {
            new { Id = 1, Name = "ID Proof" },
            new { Id = 2, Name = "Address Proof" }
        };
        return Ok(documents);
    }

    // GET document by ID (placeholder)
    [HttpGet("{id}")]
    public IActionResult GetDocument(int id)
    {
        var document = new { Id = id, Name = $"Document {id}" };
        return Ok(document);
    }

    // POST upload document (placeholder)
    [HttpPost("upload")]
    public IActionResult UploadDocument()
    {
        // Placeholder response
        return Ok("Document upload placeholder");
    }
}
