using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Backend.Controllers;

[ApiController]
[Route("api/blogs")]
public class BlogsController : Controller
{
    private readonly ILogger _logger;
    public BlogsController(ILogger logger)
    {
        _logger = logger;
    }
    [HttpGet()]
    public async Task<IActionResult> GetCourses()
    {
        throw new NotImplementedException();
    }

    [HttpPost()]
    public async Task<IActionResult> PostCourse()
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteCourse(string id)
    {
        throw new NotImplementedException();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateCourse(string id)
    {
        throw new NotImplementedException();
    }
}