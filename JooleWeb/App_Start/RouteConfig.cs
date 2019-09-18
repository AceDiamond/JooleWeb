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
                 name: "Search",
                 url: "Search",
                 defaults: new { controller = "Search", action = "Index", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                 name: "Compare",
                 url: "Compare",
                 defaults: new { controller = "Compare", action = "Index", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                 name: "ProductDetails",
                 url: "ProductDetails",
                 defaults: new { controller = "ProductDetails", action = "Index", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                 name: "ProductDetails2",
                 url: "ProductDetails/ProductDetails",
                 defaults: new { controller = "ProductDetails", action = "Index", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
