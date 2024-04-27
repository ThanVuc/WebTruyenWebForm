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
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }

            var id = Request.RequestContext.RouteData.Values["id"];
            if (id != null)
            {
                id = id.ToString();
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

        }
    }
}