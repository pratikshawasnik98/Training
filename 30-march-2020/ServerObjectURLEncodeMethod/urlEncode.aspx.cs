using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObjectURLEncodeMethod
{
    public partial class urlEncode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text="https://www.google.com";
            Response.Redirect("https://www.google.com");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "https://www.google.com";
        }
    }
}