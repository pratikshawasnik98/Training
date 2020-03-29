using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example_Of_URLEncode
{
    public partial class exampleURL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("John Saunders");
           // Response.Redirect("https://localhost:44394/after.aspx" + name);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("Joh'n /Saunders");
            String password = Server.UrlEncode("king");
            //query string to pass more than one value 
            Response.Redirect("https://localhost:44394/after.aspx" + name + " &password=" + password);

        }
    }
}