using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Samples.Data;
using StructureMap;
using WebApi.StructureMap;
using Entities = Samples.Entities;

namespace Samples.SimpleOrdering
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IContainer Container { get; private set; }
            
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            Mapper.Initialize(x => x.CreateMissingTypeMaps = true);
        }
    }
}
