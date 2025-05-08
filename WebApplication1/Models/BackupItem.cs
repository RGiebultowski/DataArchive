namespace WebApplication1.Models
{
    public record BackupItem(string Name, Stream stream) : IDisposable
    {
        public void Dispose()
        {
            this.stream.Dispose();
        }
    }
}
