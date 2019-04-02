using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TenantSample.Dal;

namespace TenantSample.App
{
    public static class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDal("ConsoleContext");
            return serviceCollection.BuildServiceProvider();
        }
    }
}
