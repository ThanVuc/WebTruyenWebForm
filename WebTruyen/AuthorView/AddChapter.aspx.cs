using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class AddChapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }
        }
        protected void AddChapterBtn_Click(object sender, EventArgs e)
        {
            var num = Request.Form["Nums"];
            var title = Request.Form["title"];
            var content = Request.Form["content"];
            var storyID = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);

            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = $"insert into Chapter values (N'{title}',N'{content}',{num},{storyID})";

            int check = cnt.Cmd.ExecuteNonQuery();
            if (check > 0)
            {
                message.InnerText = "Thêm thành công";
            } else
            {
                message.InnerText = "Thêm thất bại";
            }
        }
    }
}