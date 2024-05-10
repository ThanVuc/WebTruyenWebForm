using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.DetailView
{
    public partial class ListChapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _Connection cnt = new _Connection();
            int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            try
            {
                cnt.adapter.TableMappings.Add("chapter", "Chapter");
                cnt.Cmd.CommandText = $"Select * from Chapter where StoryID = {id}";

                cnt.adapter = new System.Data.SqlClient.SqlDataAdapter(cnt.Cmd);

                DataTable dt = new DataTable();
                cnt.adapter.Fill(dt);

                ChapterList.DataSource = dt;
                ChapterList.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cnt.CloseConnect();
            }
           
        }
    }
}