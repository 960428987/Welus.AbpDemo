﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Welus.AbpDemo.ConsoleApp
{
    [Dependency(ServiceLifetime.Transient)]
    public class HelloService /*: ITransientDependency*/
    {
        public void SayHello()
        {
            Console.WriteLine("天天向上");
        }
    }
}