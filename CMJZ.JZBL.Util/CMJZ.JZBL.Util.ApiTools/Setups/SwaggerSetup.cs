using CMJZ.JZBL.Util.ApiTools.Helper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CMJZ.JZBL.Util.Common.Setups
{
    public static class SwaggerSetup
    {
        public static void AddSwaggerSetup(this IServiceCollection service)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));

            var basePath = AppContext.BaseDirectory;

            var ApiName = Appsettings.app(new string[] { "Startup", "ApiName" });

            service.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("V1", new OpenApiInfo
                    {
                        Version = "V1",
                        Title = $"{ApiName} Api Doc By Netcore 3.0",
                        Description = $"{ApiName} HTTP API V1",
                        Contact = new OpenApiContact { Name = ApiName, Email = $"{ApiName}@xxx.com", Url = new Uri("https://www.baidu.com/") },
                        License = new OpenApiLicense { Name = ApiName, Url = new Uri("https://www.baidu.com/") }
                    });
                    c.OrderActionsBy(o => o.RelativePath);

                    var xmlPath = Path.Combine(basePath, $"{ApiName}.Application.Api.xml");//CMJZ.JZBL.Application.Api.xml文件名 ,生产环境需要拷贝到根目类
                    //var xmlPath = Path.Combine(basePath, $"CMJZ.JZBL.Application.Api.xml");//CMJZ.JZBL.Application.Api.xml文件名 ,生产环境需要拷贝到根目类
                    c.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，不然没有用
                });


        }
    }
}
