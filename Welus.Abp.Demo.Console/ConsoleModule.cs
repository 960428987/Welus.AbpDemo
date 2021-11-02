using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Welus.AbpDemo.ConsoleApp.Common;
using Welus.AbpDemo.ConsoleApp.Plugin;

namespace Welus.AbpDemo.ConsoleApp
{
    /*
     Abp是一种基于模块化设计的思想构建的。开发人员可以将自定义的功能以模块（module）的形式集成到ABP中。
    具体的功能都可以设计成一个单独的Module。Abp底层框架提供便捷的方法集成每个Module.
    AbpModule是所有Module的基类，其已经拥有了IIocManager和IAbpStartupConfiguration的受保护的成员，
    从其派生的Module都可以直接获取并使用相关的功能
     */

    [DependsOn(typeof(AbpAutofacModule),
        typeof(CommonModule)
        )]
    public class ConsoleModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Console.WriteLine("加载abpModule");
            context.Services.AddHostedService<ConsoleHostedService>();
            base.ConfigureServices(context);

        }
    }
}
