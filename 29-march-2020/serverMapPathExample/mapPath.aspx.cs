using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverMapPathExample
{
    public partial class mapPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath("/default5.aspx"));
            Response.Write("<br>");
            Response.Write(Server.MapPath(Request.ServerVariables.Get("PATH_INFO")));


        }
    }
}