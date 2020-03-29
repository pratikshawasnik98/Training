using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObjectHTMLEncodeMethod
{
    public partial class htmlCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text="<h1><u>welcome to Page which are without HTML Code</u></h1>";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Server.HtmlEncode("<h1><u>welcome to Page with HTML Code</u></h1>");
        }
    }
}