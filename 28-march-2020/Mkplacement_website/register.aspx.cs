using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mkplacement_website
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cn = Application["companyname"].ToString();
            string ad = Application["address"].ToString();
            int cnt = Convert.ToInt32(Application["counter"].ToString());
            cnt = cnt + 1;
            Application["counter"] = cnt;
            Response.Write("welcome to " + cn + "<Br>");
            Response.Write("at  " + ad + "<Br>");
            Response.Write("no of visitors : " + cnt.ToString() + "<Br>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Label1.Text = "registered successfully";

        }
    }
}