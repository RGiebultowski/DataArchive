using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1
{
    internal static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services
            .AddScoped<IGitRepoService, GitRepoService>();
    }
}
