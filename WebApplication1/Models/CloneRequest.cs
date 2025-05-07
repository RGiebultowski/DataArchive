using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CloneRequest
    {
        [Required]
        public string RepoUrl { get; set; }
    }
}
