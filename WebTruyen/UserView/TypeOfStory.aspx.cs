using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.UserView
{
    public partial class TypeOfStory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            cnt.adapter.TableMappings.Add("Table", "TypeOfStory");
            cnt.adapter.SelectCommand = new System.Data.SqlClient.SqlCommand("Select * From TypeOfStory", cnt.Connection);

            DataSet ds = new DataSet();
            cnt.adapter.Fill(ds);
            DataTable dt = ds.Tables["TypeOfStory"];

            GridView_Type.DataSource = dt;
            GridView_Type.DataBind();

        }
    }
}