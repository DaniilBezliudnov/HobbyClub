using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HobbyClub.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
        name: "MainForNonAuthorized",
        url: "",
        defaults: new { controller = "Home", action = "Main" }
    );

            routes.MapRoute(
            name: "Main",
            url: "main",
            defaults: new { controller = "Home", action = "Main" }
        );

            routes.MapRoute(
                name: "Home",
                url: "home",
                defaults: new { controller = "Home", action = "Home" }
            );

            //  routes.MapRoute(
            //    name: "Lists",
            //    url: "{page}/{number}",
            //    defaults: new { controller = "Home", action = "Home", page = @"interests|events|groups", number = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //name: "Interests",
            //url: "interests/{page}",
            //defaults: new { controller = "Home", action = "Interests", page = UrlParameter.Optional }
        //);

            routes.MapRoute(
            name: "Events",
            url: "events/{page}",
            defaults: new { controller = "Home", action = "Events", page = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "Groups",
            url: "groups/{page}",
            defaults: new { controller = "Home", action = "Groups", page = UrlParameter.Optional }
        );

            routes.MapRoute(
                    name: "LogIn",
                    url: "log-in",
                    defaults: new { controller = "Home", action = "" } /// SIGN IN ДОПИСАТЬ!!!!
                );
            routes.MapRoute(
                name : "defaultRoute",
                url : "{controller}/{action}",
                defaults: new { controller = "controller", action = "action" }// by default will always open Index method for any controller (action="action")
                );
        }
    }
}
