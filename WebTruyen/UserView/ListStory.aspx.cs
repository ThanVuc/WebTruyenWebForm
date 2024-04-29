using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.UserView
{
    public partial class ListStory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int typeID = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);

            Response.Write(typeID);
            _Connection cnt = new _Connection();

            try
            {
                cnt.Cmd.CommandText = $"Select TypeName from TypeOfStory where TypeID = {typeID}";
                string typeName = cnt.Cmd.ExecuteScalar().ToString();
                Type.InnerText = typeName;

            } catch(Exception ex)
            {
                cnt.CloseConnect();
                Response.Redirect("Error");
            }

            try
            {
                cnt.adapter.TableMappings.Add("Table", "Story");
                cnt.Cmd = new System.Data.SqlClient.SqlCommand("dbo.getStoryByType", cnt.Connection);
                cnt.Cmd.CommandType = CommandType.StoredProcedure;
                cnt.Cmd.Parameters.Add(
                        new System.Data.SqlClient.SqlParameter()
                        {
                            ParameterName = "@typeID",
                            SqlDbType = SqlDbType.Int,
                            Value = typeID
                        }
                    );

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