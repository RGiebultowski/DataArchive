using System.IO.Compression;
using LibGit2Sharp;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class GitRepoService : IGitRepoService
    {
        public IEnumerable<BackupItem> CloneRepository(string repoUrl)
        {
            var path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            var file = Directory.CreateDirectory(path);

            Repository.Clone(repoUrl, path);

            var zipStream = new MemoryStream();
            ZipFile.CreateFromDirectory(path, zipStream);
            zipStream.Position = 0;

            ChangeFileAttributes(file, path);

            DeleteTempRepo(path);
            yield return new BackupItem("", zipStream); 
        }

        public void ChangeFileAttributes(DirectoryInfo file, string filePath)
        {
            foreach (var info in file.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                info.Attributes = FileAttributes.Normal;
            }

            File.SetAttributes(filePath.ToString(), FileAttributes.Normal);
        }

        void DeleteTempRepo(string path) => Directory.Delete(path, true);
    }
}
