using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Serverside_statemanagement
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Companyname"] = "MKPlacement";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["username"] = "abc";
            Response.Write("<br>session is now begining");
            Response.Write("<br>session variable value : " + Session["username"].ToString());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Response.Write("request is now beging");
            Response.Write("<br>Company Name : " + Application["companyname"].ToString());
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}