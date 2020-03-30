using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverProperties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sid = Session.SessionID;
            // Response.Write("session id " + sid);
            Session["sessionid"] = sid;
            Response.Write("session id : " + Session["sessionid"].ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sessionID.aspx");
        }
    }
}