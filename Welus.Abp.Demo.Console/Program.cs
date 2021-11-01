using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using Volo.Abp.Modularity.PlugIns;

namespace Welus.AbpDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            CreateHostBuilder(args).RunConsoleAsync().Wait();

        }
        internal static IHostBuilder CreateHostBuilder(string[] args)=>
            Host.CreateDefaultBuilder(args).UseAutofac()
            .ConfigureAppConfiguration((context,config)=> { 
            
            })
           .ConfigureServices((hostContext, services) =>
           {
               services.AddApplication<ConsoleModule>(options => {
                   // 1、加载插件
                  // options.PlugInSources.AddFolder(@"D:\work\net-project\ABP专题\1、核心根基模块化\MyPlugIns");
               });

           });
    }
}
