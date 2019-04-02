using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TenantSample.Common.Abstractions;
using TenantSample.Dal.Abstractions;
using TenantSample.Dal.Implementations;

namespace TenantSample.Dal
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddDal(this IServiceCollection services, string context)
        {
            services.AddSingleton<IDalPrefixFactory, SomePrefixFactory>();
            services.AddScoped<ISomeRepositoryFactory, SomeRepositoryFactory>(sp => new SomeRepositoryFactory(context, sp.GetService<IDalPrefixFactory>()));

            services.AddScoped(sp => sp.GetService<ISomeRepositoryFactory>().Create(sp.GetService<ITenantIdProvider>().GetTenantId()));

            return services;
        }
    }
}
