using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var user = Request.Form["user"];
            var password = Request.Form["password"];
            lb1.InnerText = user + password + "asjdh";
            if (user == "abcxyz" && password == "123")
            {
                Response.Redirect("/");
            }
        }
    }
}