using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IGitRepoService
    {
        IEnumerable<BackupItem> CloneRepository(string repoUrl);
    }
}
