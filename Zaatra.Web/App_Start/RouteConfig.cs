using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Zaatra
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "packages",
                url: "Tourpackages",
                defaults: new { controller = "Package", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "destinations",
                url: "Destinations",
                defaults: new { controller = "Destination", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "visa",
                url: "Visa",
                defaults: new { controller = "Visa", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "hotels",
                url: "Hotels",
                defaults: new { controller = "Hotel", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ticket",
                url: "Ticket",
                defaults: new { controller = "Ticket", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}