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
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings);
            return services.AddSingleton((IConfigurationRoot)configuration)
                //.InstallServices()
                .AddInfrastructure(applicationSettings.ConnectionString)
                .AddWebApi()
                .AddApplication();
        }
    }
}
