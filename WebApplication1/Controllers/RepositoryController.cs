using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RepositoryController : ControllerBase
    {
        [HttpPost("archive")]
        public async Task<IActionResult> ArchiveRepository([FromBody] CloneRequest request)
        {
            return Ok();
        }
    }
}
