using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CMJZ.JZBL.Application.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /****************************************************************************************/
            /*      Study By Blog.Core
            /*                        Ty By LaoZhang (https://www.cnblogs.com/laozhang-is-phi/)
            /****************************************************************************************/

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
