using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using TestIService;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        public IUserService UserService { get; set; }
        public Person Person { get; set; }
        // GET: Default
        public ActionResult Index()
        {
            var svc = DependencyResolver.Current.GetService<IUserService>();
            var b = Person.SayHello();
            //bool b =UserService.CheckLogin("abc","123");
            return Content(b.ToString());
        }
    }
}