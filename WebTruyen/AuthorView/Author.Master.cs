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
        public string Aliases { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);

            if (logged == 0)
            {
                Response.Redirect("/login");
            }

            //int userID = Convert.ToInt32(Session["userID"]);
            //string id = Request.RequestContext.RouteData.Values["id"].ToString();
            //_Connection cnt = new _Connection();
            //cnt.Cmd.CommandText = $"Select Aliases from Author where AuthorID={id}";
            //Aliases = cnt.Cmd.ExecuteScalar().ToString();
            //cnt.CloseConnect();

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