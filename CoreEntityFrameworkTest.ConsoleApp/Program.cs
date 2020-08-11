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

        /**
         * Csak akkor fut le, ha nulláról akarok egy db-t felhúzni. 
         */
        private static void Configure()
        {
            ServiceProvider.GetService<CatalogContext>().Database.Migrate();
        }

    }
}
