using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            string userName = Request.Form["username"];
            string password = Request.Form["password"];
            string confirm = Request.Form["Confirm"];
            string fullName = Request.Form["fullname"];
            string birth = Request.Form["birth"];
            if (password == confirm && password != "" && userName != "" && fullName!="")
            {
                _Connection cnt = new _Connection();

                cnt.Cmd.CommandText = "select 1 from StoryUser where UserName = @UserName";
                cnt.Cmd.Parameters.AddWithValue("@UserName", userName);
                if (cnt.Cmd.ExecuteScalar() != null)
                {
                    Page_Load(sender, e);
                    err.InnerText = "Trùng tên đăng nhập";
                }
                else
                {

                    cnt.Cmd.CommandText = "insert into StoryUser(UserName,UserPassword,FullName,DateOfBirth) values (@userName,@userPassword,@fullname,@birth)";
                    cnt.Cmd.Parameters.AddWithValue("@userName", userName);
                    cnt.Cmd.Parameters.AddWithValue("@userPassword", password);
                    cnt.Cmd.Parameters.AddWithValue("@fullname", fullName);
                    cnt.Cmd.Parameters.AddWithValue("@birth", birth);
                    cnt.Cmd.ExecuteNonQuery();
                    cnt.CloseConnect();
                    Response.Redirect("/Login");
                }
            } else
            {
                err.InnerText = "Đăng ký thất bại, vui lòng kiểm tra lại thông tin";
            }

        }
    }
}