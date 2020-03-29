using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObjectExecuteMethod
{
    public partial class ExecuteMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br>Home Page Execution (code before calling execute method )");

            Server.Execute("next.aspx");
           Response.Write("<br> (code after calling execute method)");

        }
    }
}