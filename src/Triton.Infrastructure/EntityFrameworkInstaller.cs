using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Triton.Infrastructure.DataProviders;

namespace Triton.Infrastructure
{
    public static class EntityFrameworkInstaller
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(optionsBuilder
                => optionsBuilder
                    //.UseLazyLoadingProxies() // lazy loading
                    .UseNpgsql(connectionString));
            //.UseSqlServer(connectionString));

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddHealthChecks()
                .AddDbContextCheck<ApplicationDbContext>();

            return services;
        }
    }
}
