using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);

            if (logged == 0)
            {
                Response.Redirect("/login");
            }

            try
            {
                int userID = Convert.ToInt32(Session["userID"]);
                string id = Request.RequestContext.RouteData.Values["id"].ToString();
                _Connection cnt = new _Connection();
                cnt.Cmd.CommandText = $"Select Aliases, AuthorAvatar from Author where AuthorID={userID}";

                var reader = cnt.Cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Aliases.InnerText = reader["Aliases"].ToString();
                    AuthorAvatar.Src = reader["AuthorAvatar"].ToString();
                }

                cnt.CloseConnect();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //Response.Redirect("/Error");
            }
            

        }

        protected void addnew_btn_Click(object sender, EventArgs e)
        {
            var userID = Convert.ToInt32(Session["userID"]);
            Response.Redirect($"/author/addnew/{userID}");
        }

        protected void uploaded_btn_Click(object sender, EventArgs e)
        {
            var userID = Convert.ToInt32(Session["userID"]);
            Response.Redirect($"/author/uploaded/{userID}");
        }
    }
}