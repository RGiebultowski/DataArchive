using LibGit2Sharp;

namespace WebApplication1.Services
{
    public class GitRepoService : IGitRepoService
    {
        public string CloneRepository(string repoUrl)
        {
            var path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(path);

            Repository.Clone(repoUrl, path);
            return path;
        }
    }
}
