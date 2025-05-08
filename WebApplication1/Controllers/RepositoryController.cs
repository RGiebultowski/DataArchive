using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : ControllerBase
    {

        private readonly IGitRepoService gitRepoService;

        public RepositoryController(IGitRepoService gitRepoService)
        {
            this.gitRepoService = gitRepoService;
        }

        [HttpPost("archive")]
        public async Task<IActionResult> ArchiveRepository([FromBody] CloneRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            gitRepoService.CloneRepository(request.RepoUrl);
            await Task.CompletedTask;
            return Ok();
        }
    }
}
