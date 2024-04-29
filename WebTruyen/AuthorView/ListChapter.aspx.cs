using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class ListChapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string id = Request.RequestContext.RouteData.Values["id"].ToString();
            if (id != "")
            {
                _Connection connect = new _Connection();
                connect.adapter.TableMappings.Add("Table", "Chapter");
                connect.adapter.SelectCommand = new System.Data.SqlClient.SqlCommand($"select * from Chapter where StoryID={id}", connect.Connection);
                DataSet dataSet = new DataSet();
                connect.adapter.Fill(dataSet);
                DataTable dt = dataSet.Tables["Chapter"];

                Grid_Chapter.DataSource = dt;
                Grid_Chapter.DataBind();
            } else
            {
                Response.Redirect("/Error");
            }

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            var chapterID = Request.Form["ChapterNum"];

            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = "Delete from Chapter where ChapterID = @chapterID";
            cnt.Cmd.Parameters.AddWithValue("@chapterID", chapterID);

            int numsRow = cnt.Cmd.ExecuteNonQuery();

            if (numsRow > 0)
            {
                message.InnerText = "Xóa Thành Công";
                Page_Load(sender,e);
            }
            else
            {
                message.InnerText = "Không Tìm Thấy ID";
            }
            cnt.CloseConnect();

        }
    }
}