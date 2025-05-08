namespace WebApplication1.Services
{
    public interface IGitRepoService
    {
        string CloneRepository(string repoUrl);
    }
}
