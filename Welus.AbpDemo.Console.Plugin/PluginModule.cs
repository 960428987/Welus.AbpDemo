using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Welus.AbpDemo.ConsoleApp.Plugin
{
   public class PluginModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            System.Console.WriteLine("加载插件模块...........");
        }
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
            var myService = context.ServiceProvider.GetRequiredService<PluginService>();
            myService.Plugin();
        }
    }
}
