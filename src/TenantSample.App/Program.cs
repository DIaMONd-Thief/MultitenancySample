using System;
using TenantSample.Dal.Abstractions;

using Microsoft.Extensions.DependencyInjection;

namespace TenantSample.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = Startup.ConfigureServices();

            Console.WriteLine(provider.GetService<ISomeRepositoryFactory>().Create("console").Read());
            Console.ReadKey();
        }
    }
}
