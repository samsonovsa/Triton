using Triton.Infrastructure;
using Triton.Infrastructure.UseCases.Address;
using Triton.Infrastructure.UseCases.Customer;
using Triton.WebAPI.Settings;

namespace Triton.WebAPI
{
    public static class RegisterServises
    {
        public static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings);
            return services.AddSingleton((IConfigurationRoot)configuration)
                .InstallServices()
                .ConfigureContext(applicationSettings.ConnectionString)
                .InstallRepositories();
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            //serviceCollection
            //.AddTransient<ICustomerService, CustomerService>()
            //    .AddTransient<IAddressService, AddressService>();
            return serviceCollection;
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
