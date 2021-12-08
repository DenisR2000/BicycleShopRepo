using BiicycleShopDb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var servises = scope.ServiceProvider;
                try
                {
                    var contextBicycle = servises.GetRequiredService<BicycleContext>();
                    var contextUser = servises.GetRequiredService<UserContext>();
                   
                    //UserData.Initialize(contextUser);
                    GenerateData.Initialize(contextBicycle);
                }
                catch(Exception ex)
                {
                    var loger = servises.GetRequiredService<ILogger<Program>>();
                    loger.LogDebug(ex, "Db seting error");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
