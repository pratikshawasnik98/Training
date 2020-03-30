using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverProperties
{
    public partial class sessionIDAfter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session.IsNewSession)
            {
                Session["sessionid1"] = Session.SessionID;
                Response.Write("new session<br>");

                Response.Write("<br>");
            }
            else
            {

                Response.Write("continueing with same old seesion");
            }

            Response.Write("<br>session id " + Session["sessionid1"].ToString());
            int to = Session.Timeout;
            Response.Write("time out " + to);
            int lid = Session.LCID;
            Response.Write("lid " + lid);
            int scount = Session.Count;
            Response.Write("no of items in session " + scount.ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon(); // this will abandon the session and we request again it will //start a new session
        }
    }
}