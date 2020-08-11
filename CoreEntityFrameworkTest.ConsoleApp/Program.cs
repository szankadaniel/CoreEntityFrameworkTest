using CoreEntityFrameworkTest.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace CoreEntityFrameworkTest.ConsoleApp
{
    public class Program
    {

        public static IServiceCollection ServiceCollection { get; private set; }

        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Main(string[] args)
        {
            new CatalogContext().Database.Migrate();
            //ConfigureServices();
            //Configure();
        }

        private static void ConfigureServices()
        {
            ServiceCollection =
                new ServiceCollection()
                .AddDbContext<CatalogContext>();
            ServiceProvider = ServiceCollection.BuildServiceProvider();
        }

        private static void Configure()
        {
            ServiceProvider.GetService<CatalogContext>().Database.Migrate();
        }

    }
}
