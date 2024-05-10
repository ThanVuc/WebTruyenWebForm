using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class Edit : System.Web.UI.Page
    {
        public string title { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }

            int userID = Convert.ToInt32(Session["userID"]);
            string id = Request.RequestContext.RouteData.Values["id"].ToString();
            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = $"Select Title from Story where StoryID={id}";
            var reader = cnt.Cmd.ExecuteReader();
            while (reader.Read())
            {
                title = reader["title"].ToString();
            }
            cnt.CloseConnect();
        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["userID"]);
            string id = Request.RequestContext.RouteData.Values["id"].ToString();
            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = $"Delete from Story where StoryID = {id}";

            int numsRow = cnt.Cmd.ExecuteNonQuery();

            if (numsRow > 0)
            {
                Response.Redirect("/author/uploaded");
            }
            else
            {
                message.InnerText = "Không Tìm Thấy ID";
            }
            cnt.CloseConnect();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["userID"]);
            var _title = Request.Form["Title"];
            var _description = Request.Form["description"];
            int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = $"Update Story Set Title = N'{_title}', Description_ = N'{_description}' where StoryID = {id}";

            int numsRow = cnt.Cmd.ExecuteNonQuery();

            if (numsRow > 0)
            {
                message.InnerText = "Cập Nhật Thành Công";
            }
            else
            {
                message.InnerText = "Không Tìm Thấy Truyện";
            }
            cnt.CloseConnect();
        }
    }
}