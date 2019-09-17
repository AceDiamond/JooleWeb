using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JooleWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Search1",
                 url: "Search",
                 defaults: new { controller = "Search", action = "Index", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                 name: "Search2",
                 url: "Search/Search",
                 defaults: new { controller = "Search", action = "Index", id = UrlParameter.Optional }
             );
            routes.MapRoute(name: "Home", url: "Home/Login", 
              defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
