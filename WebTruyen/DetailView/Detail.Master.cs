using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.DetailView
{
    public partial class Detail : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                register.InnerText = "Register";
                login.InnerText = "Login";
            }
            else
            {
                UserManage.InnerText = "Change Avatar";
                logout.InnerText = "Logout";
                var userID = Session["userID"];
                _Connection cnt = new _Connection();

                cnt.Cmd.CommandText = $"select AvatarUrl from StoryUser where UserID = {userID}";
                try
                {
                    Avatar.Src = cnt.Cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    Response.Redirect("/Error");
                }
                cnt.CloseConnect();
            }
        }
    }
}