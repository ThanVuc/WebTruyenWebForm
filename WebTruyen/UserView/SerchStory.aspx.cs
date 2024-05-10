using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.UserView
{
    public partial class SerchStory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int typeID = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            string serchString = Request.QueryString["SerchString"];
            _Connection cnt = new _Connection();

            try
            {
                cnt.Cmd.CommandText = $"select * from story where Title like N'%{serchString}%'";

                cnt.adapter = new SqlDataAdapter(cnt.Cmd);

                DataTable dt = new DataTable();
                cnt.adapter.Fill(dt);

                GridView_ListStory.DataSource = dt;
                GridView_ListStory.DataBind();
                cnt.CloseConnect();
            }
            catch (Exception ex)
            {
                cnt.CloseConnect();
                Response.Write(ex.Message);
            }
        }
        protected void GridView_ListStory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_ListStory.PageIndex = e.NewPageIndex;

            Page_Load(sender, e);
        }
    }
}