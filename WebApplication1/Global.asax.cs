using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            //把当前程序集中的controller都注册
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            //获取相关的程序集,并且Service类中也加上属性注入
            Assembly assembly = Assembly.Load("TestService");
            builder.RegisterAssemblyTypes(assembly).Where(x => !x.IsAbstract).AsImplementedInterfaces()
                .PropertiesAutowired();
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly).PropertiesAutowired();
            ;

            //把Autofac作为一个系统的容器,当MVC框架创建controller等对象的时候全都从它这里获取
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
