using Triton.Application;
using Triton.Infrastructure;
using Triton.WebAPI.Settings;

namespace Triton.WebAPI
{
    public static class RegisterServises
    {
        public static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Triton");
           // services.AddSingleton(applicationSettings);
            return services.AddSingleton((IConfigurationRoot)configuration)
                .AddInfrastructure(connectionString)
                .AddWebApi()
                .AddApplication();
        }
    }
}
