﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace _0601
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "test1",
            //    url: "{c8763}/{action}/{id}",
            //    defaults: new
            //    {
            //        c8763 = "c8763",
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    constraints: new
            //    {
            //        //c8763 = "[0-9]{4}"
            //    });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}