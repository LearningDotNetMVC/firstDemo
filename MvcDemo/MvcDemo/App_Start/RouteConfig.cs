using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcDemo
{
    public class RouteConfig
    {

        //this is not case sensitive
        //the routes are evaluated in order
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Process/
            routes.MapRoute(
                name: "Process",
                url: "Process/{action}/{id}",
                defaults: new { controller = "Process", action = "List", id = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
