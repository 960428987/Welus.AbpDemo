using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Welus.AbpDemo.ConsoleApp.Common
{
    [Dependency(ServiceLifetime.Transient)]
    public class CommonService
    {
        public void Common()
        {
            System.Console.WriteLine("CommonService 执行");
        }
    }
}
