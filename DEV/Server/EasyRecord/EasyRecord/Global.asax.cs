using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using EasyRecord.Common;
using EasyRecord.Respository;

namespace EasyRecord
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //开启跨域
            GlobalConfiguration.Configuration.EnableCors();

            //自动更新migration
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<EasyRecordContext, Configuration>());

            //注册依赖注入
            IocConfig.RegisterAutofac();

            //开启miniProfiler EF
            //StackExchange.Profiling.MiniProfilerEF.Initialize();
        }

        
    }
}
