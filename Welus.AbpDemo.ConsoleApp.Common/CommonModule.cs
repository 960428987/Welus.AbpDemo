using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace Welus.AbpDemo.ConsoleApp.Common
{
   public class CommonModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            System.Console.WriteLine("加载CommonModule模块");

        }
    }
}
