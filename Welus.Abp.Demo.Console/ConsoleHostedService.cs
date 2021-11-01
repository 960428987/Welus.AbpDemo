using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Welus.AbpDemo.ConsoleApp.Common;

namespace Welus.AbpDemo.ConsoleApp
{
    public class ConsoleHostedService : IHostedService
    {
        private readonly HelloService _helloWorldService;//构造函数注入
        public CommonService commonService { set; get; }// 属性注入
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="helloWorldService"></param>
        public ConsoleHostedService(HelloService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _helloWorldService.SayHello();
            commonService.Common();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
