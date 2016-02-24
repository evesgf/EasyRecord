using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.WebApi;
using EasyRecord.Respository;
using EasyRecord.Respository.Category;

namespace EasyRecord.Common
{
    public class IocConfig
    {
        /// <summary>
        /// 注册依赖注入
        /// </summary>
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            var baseType = typeof(IDependency);

            var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToList();

            builder.RegisterApiControllers(assemblys.ToArray());

            builder.RegisterAssemblyTypes(assemblys.ToArray())
                   .Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                   .AsImplementedInterfaces().InstancePerLifetimeScope();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
