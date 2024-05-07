using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen
{
    public partial class HomePage : System.Web.UI.Page
    {

        public int Nums { get; set; } = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();

            try
            {
                cnt.adapter.TableMappings.Add("Table", "Story");
                cnt.adapter.SelectCommand = new SqlCommand("Select StoryID, Title, CoverImageUrl from Story", cnt.Connection);

                DataSet ds = new DataSet();
                cnt.adapter.Fill(ds);

                DataTable dt = ds.Tables["Story"];

                GridView_Home.DataSource = dt;
                GridView_Home.DataBind();
                cnt.CloseConnect();
            }
            catch (Exception ex)
            {
                cnt.CloseConnect();
                Response.Write(ex.Message);
            }

            try
            {
                cnt.OpenConnect();
                cnt.adapter.SelectCommand = new SqlCommand($"Select top 10 StoryID, Title, CoverImageUrl from Story  order by StoryView desc", cnt.Connection);

                DataSet ds = new DataSet();
                cnt.adapter.Fill(ds);

                DataTable dt = ds.Tables["Story"];

                GridView_Top.DataSource = dt;
                GridView_Top.DataBind();
                cnt.CloseConnect();
            }
            catch (Exception ex)
            {
                cnt.CloseConnect();
                Response.Write(ex.Message);
            }

            Nums = 1;

        }

        protected void GridView_Home_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Home.PageIndex = e.NewPageIndex;

            Page_Load(sender, e);
        }
    }
}