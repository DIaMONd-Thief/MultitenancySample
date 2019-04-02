using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace TenantSample.BL
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<RepositoryUsingService>();
            services.AddScoped<FactoryUsingService>();

            return services;
        }
    }
}
