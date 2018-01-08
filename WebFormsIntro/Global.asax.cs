using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using WebFormsIntro.App_Start;

namespace WebFormsIntro
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Ziyaretçi"] = 0;
            //Tüm kullanıcıları ilgilendiren veri tutma senaryolarında tercih edilir. 
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["Ziyaretçi"] = (int)Application["Ziyaretçi"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["Ziyaretçi"] = (int)Application["Ziyaretçi"] - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}