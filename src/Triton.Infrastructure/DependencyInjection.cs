using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Triton.Application.UseCases.Address;
using Triton.Application.UseCases.Customer;
using Triton.Infrastructure.DataProviders;
using Triton.Infrastructure.DataProviders.EF;
using Triton.Infrastructure.UseCases.Address;
using Triton.Infrastructure.UseCases.Customer;

namespace Triton.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
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

            services.InstallRepositories();

            return services;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<ICustomerRepository, CustomerRepository>()
                .AddTransient<IAddressRepository, AddressRepository>();
            return serviceCollection;
        }
    }
}
