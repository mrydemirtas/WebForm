using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebFormsIntro.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "home", "~/Default.aspx");
            routes.MapPageRoute("layout", "master", "~/MasterPageOrnek.aspx");
        }
    }
}