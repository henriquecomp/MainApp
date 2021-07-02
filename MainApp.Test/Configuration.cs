using Autofac;
using MainApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Test
{
    public class Configuration
    {

        public static IServiceProvider ServiceProvider { get; set; }

        public Configuration()
        {
            var serviceCollection = new ServiceCollection();

            List<Assembly> assemblyList = new List<Assembly>();
            assemblyList.Add(Assembly.Load("MainApp"));

            serviceCollection.Scan(scan => scan
            .FromAssemblies(assemblyList)
                   .AddClasses(classes => classes.Where(type => type.Name.Contains("Service") ||
                                                        type.Name.Contains("Repository")))
                   .AsImplementedInterfaces()
                   .WithTransientLifetime());

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }

}
