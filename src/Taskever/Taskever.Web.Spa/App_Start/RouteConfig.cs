﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Taskever.Web.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //ASP.NET Web API Route Config
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //ASP.NET MVC Route Config
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            //Durandal Views! TODO: Where and how to write this?
            routes.MapRoute(
                name: "AppViews",
                url: "App/{module}/views/{view}.html",
                defaults: new { controller = "DurandalView", action = "GetAppView" }
                );
        }
    }
}