using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Serverside_statemanagement
{
    public partial class design1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>page load event fire");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("design1.aspx?uname=" + TextBox1.Text);
        }
    }
}