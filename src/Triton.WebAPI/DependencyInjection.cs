using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Triton.WebAPI
{
    /// <summary>
    /// Configure container for WebApi
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Configure container UI
        /// </summary>
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {

            return services;
        }

    }
}
