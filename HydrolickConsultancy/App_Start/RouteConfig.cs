using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HydrolickConsultancy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Home",
              url: "home",
              defaults: new { controller = "Home", action = "Index" }
          );

            routes.MapRoute(
              name: "aboutUs",
              url: "about-us",
              defaults: new { controller = "Home", action = "aboutus" }
          );
            routes.MapRoute(
              name: "ContactUs",
              url: "contact-us",
              defaults: new { controller = "Home", action = "contactUs" }
          );
            routes.MapRoute(
              name: "News",
              url: "news",
              defaults: new { controller = "Home", action = "news" }
          );
            routes.MapRoute(
              name: "Enterpreneur",
              url: "enterpreneur",
              defaults: new { controller = "Home", action = "Enterpreneur" }
          );
            routes.MapRoute(
              name: "Investor",
              url: "investor",
              defaults: new { controller = "Home", action = "Investor" }
          );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
