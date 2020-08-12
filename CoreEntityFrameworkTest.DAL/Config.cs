using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace CoreEntityFrameworkTest.DAL
{

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// The appsettings.json is defined in both the startup project (ConsoleApp) and referred project (DAL).
    /// The one in the referred project will be overriden. 
    /// 
    /// However, the referred project can't (and shouldn't) access the configuration and service inside the startup project, 
    /// hence we have to instantiate these objects here, in the referred project. 
    /// Maybe it would be more better to move this file into a separate project. 
    /// I leave here for now, just because there is no more project. 
    /// </remarks>
    public static class Config
    {

        private static IConfigurationRoot configuration;

        static Config()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            serviceCollection.AddSingleton<IConfigurationRoot>(configuration);
        }

        public static IEnumerable<IConfigurationProvider> Providers => configuration.Providers;

        public static IEnumerable<IConfigurationSection> GetChildren()
        {
            return configuration.GetChildren();
        }

        public static IChangeToken GetReloadToken()
        {
            return configuration.GetReloadToken();
        }

        public static IConfigurationSection GetSection(string key)
        {
            return configuration.GetSection(key);
        }

        public static void Reload()
        {
            configuration.Reload();
        }

        public static string GetConnectionString(string name)
        {
            return configuration.GetConnectionString(name);
        }
    }

}