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
            if (Session["logged"] != null)
            {
                Session.Remove("logged");
                Session.Add("logged", 0);
            } else
            {
                Session.Add("logged", 0);
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var user = Request.Form["user"];
            var password = Request.Form["password"];
            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = "Select * from StoryUser Where UserName = @username and UserPassword = @userpassword";
            cnt.Cmd.Parameters.AddWithValue("@username",user);
            cnt.Cmd.Parameters.AddWithValue("@userpassword", password);
            var flag = cnt.Cmd.ExecuteScalar();
            if (flag != null)
            {
                Session.Add("logged",1);
                Response.Redirect("/");
            } else
            {
                err.InnerText = "Tên Đăng Nhập hoặt Mật Khẩu không chính xác";
            }
        }
    }
}