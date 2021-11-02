using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Welus.AbpDemo.ConsoleApp.Plugin
{
    [Dependency(ServiceLifetime.Transient)]
   public class PluginService
    {
        public void Plugin()
        {
            System.Console.WriteLine("插件服务");
        }
    }
}
