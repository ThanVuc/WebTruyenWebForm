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
            if (ModelState.IsValid)
            {
                string userName = Request.Form["username"];
                string password = Request.Form["password"];
                string confirm = Request.Form["Confirm"];
                string fullName = Request.Form["fullname"];
                string birth = Request.Form["birth"];
                if (password == confirm && password != "" && userName != "" && fullName != "")
                {
                    _Connection cnt = new _Connection();

                    try
                    {
                        cnt.Cmd.CommandText = "select 1 from StoryUser where UserName = @UserName";
                        cnt.Cmd.Parameters.AddWithValue("@UserName", userName);
                        if (cnt.Cmd.ExecuteScalar() != null)
                        {
                            Page_Load(sender, e);
                            err.InnerText = "Trùng tên đăng nhập";
                        }
                        else
                        {
                            cnt.Cmd.CommandText = "insert into StoryUser(UserName,UserPassword,FullName,DateOfBirth,AvatarUrl) values (@userName1,@userPassword,@fullname,@birth,'..\\Image\\UserImg\\Default.png')";
                            cnt.Cmd.Parameters.AddWithValue("@userName1", userName);
                            cnt.Cmd.Parameters.AddWithValue("@userPassword", password);
                            cnt.Cmd.Parameters.AddWithValue("@fullname", fullName);
                            cnt.Cmd.Parameters.AddWithValue("@birth", birth);
                            cnt.Cmd.ExecuteNonQuery();
                            cnt.CloseConnect();
                            Response.Redirect("/Login");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                        err.InnerText = "Đăng kí thất bại";
                    }
                }
            }
        }
    }
}