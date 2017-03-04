
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using NLog.Extensions.Logging;
using NLog.Web;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace SUISUVPay
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AppSetting>(Configuration.GetSection("AppSettings"));
            //为NLog.web注入HttpContextAccessor
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "GUISUVPay支付平台",
                    Version = "v1",
                    Description = "GUISUVPay支付平台RESTful API ",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "桂素伟",
                        Email = "axzxs2001@163.com"
                    },
                });
                var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "GUISUVPay.xml");
                c.IncludeXmlComments(filePath);
                c.CustomSchemaIds((type) => type.FullName);                 
            });

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IOptions<AppSetting> appsettingOpt)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            // 添加NLog到.net core框架中
            loggerFactory.AddNLog();
            //添加NLog的中间件
            app.AddNLogWeb();
            // 指定NLog的配置文件
            env.ConfigureNLog("nlog.config");
            //设定微信和支付宝的参数
            BindConfig(appsettingOpt.Value);
            app.UseStaticFiles();
            app.UseMvc();
            //app.UseSwagger();
            app.UseSwagger(c =>
             {
                 c.RouteTemplate = "docs/{documentName}/swagger.json";
             });
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "docs";
                c.SwaggerEndpoint("/docs/v1/swagger.json", "GUISUVPay支付平台V1");
                c.InjectStylesheet("/swagger-ui/custom.css");
                c.InjectOnCompleteJavaScript("/swagger-ui/custom.js");
                //c.ShowJsonEditor();
            });           
        }
        /// <summary>
        /// 设置微信和支付宝参数
        /// </summary>
        /// <param name="appSetting"></param>
        void BindConfig(AppSetting appSetting)
        {
            WxPayConfig.APPID = appSetting.WXAppID;
            WxPayConfig.APPSECRET = appSetting.WXAppSecert;
            WxPayConfig.KEY = appSetting.WXKey;
            WxPayConfig.MCHID = appSetting.WXMchid;
            WxPayConfig.NOTIFY_URL = $"{appSetting.DomainName}/api/wxsm/notify";
            WxPayConfig.SSLCERT_PASSWORD = appSetting.WXSSLCertPassword;
            WxPayConfig.SSLCERT_PATH = appSetting.WXSSLCertPath;
            AlipayConfig.AppId = appSetting.AlipayAppid;
            AlipayConfig.PId = appSetting.AlipayPid;
            AlipayConfig.NotifyUrl = $"{appSetting.DomainName}/api/alipaymdm/notify";
        }
    }
}
