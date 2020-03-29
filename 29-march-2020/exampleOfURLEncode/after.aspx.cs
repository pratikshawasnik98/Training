using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example_Of_URLEncode
{
    public partial class after : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"].ToString() != null)
            {
                string name = Request.QueryString["name"].ToString();
                Response.Write("name = " + name);
            }
            if (Request.QueryString["password"].ToString() != null)
            {
                string pass = Request.QueryString["password"].ToString();
                Response.Write("password  = " + pass);
            }



        }
    }
}