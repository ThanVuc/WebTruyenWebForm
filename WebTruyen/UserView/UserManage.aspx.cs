using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.UserView
{
    public partial class ChangeAvatar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChangeAvatarBtn_Click(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            try
            {
                var userID = Session["userID"];
                string url = "";
                if (FileUpload.HasFile)
                {
                    string fileName = FileUpload.FileName;
                    url = "../Image/StoryImg/" + fileName;
                    string filePathObsolute = Server.MapPath("~/Image/StoryImg/" + fileName);
                    FileUpload.SaveAs(filePathObsolute);
                    Response.Write(url);
                }
                cnt.Cmd.CommandText = $"Update StoryUser Set AvatarUrl = '{url}' where UserID = {userID}";
                var status1 = cnt.Cmd.ExecuteNonQuery();
                cnt.Cmd.CommandText = $"Update Author Set AuthorAvatar = '{url}' where AuthorID = {userID}";
                var status2 = cnt.Cmd.ExecuteNonQuery();

                if (!string.IsNullOrEmpty(status1.ToString()))
                {
                    Response.Redirect("/");
                } else
                {
                    message.InnerText = "Update Thất Bại";
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cnt.CloseConnect();
            }
        }
        protected void Drop_Account_Click(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            try
            {
                var userID = Session["userID"];

                cnt.Cmd.CommandText = $"Delete from StoryUser where UserID = {userID}";
                var status = cnt.Cmd.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(status.ToString()))
                {
                    Response.Redirect("/Login");
                } else
                {
                    message.InnerText = "Xóa Thất Bại";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cnt.CloseConnect();
            }
        }
    }
}