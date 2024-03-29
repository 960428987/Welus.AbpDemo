﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Welus.AbpDemo.ConsoleApp
{
    /// <summary>
    /// 使用特性注入将HelloService自动注入到容器中
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class HelloService /*: ITransientDependency*/
    {
        public void SayHello()
        {
            Console.WriteLine("天天向上");
        }
    }
}
