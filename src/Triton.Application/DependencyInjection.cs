using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Triton.Application.UseCases.Address;
using Triton.Application.UseCases.Address.Services;

namespace Triton.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddTransient<IAddressService, AddressService>();
            return services;
        }
    }
}
