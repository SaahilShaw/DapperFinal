using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DapperFinal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(

                name: "Menu",
                url:  "Menubar/{action}/{id}",
                defaults: new {controller = "Menu", action = "MenuView", id = UrlParameter.Optional, 
                     } 

                );
            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Menu", action = "MenuView", id = UrlParameter.Optional }
          );
        }

    
    }
}
