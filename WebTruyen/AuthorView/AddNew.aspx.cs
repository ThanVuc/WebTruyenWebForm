using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTruyen.Model;

namespace WebTruyen.AuthorView
{
    public partial class Form_DangKiTruyen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public StoryModel _Story = new StoryModel();

        protected void AddStory_Click(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            _Story.Title = Request.Form["name"];
            _Story.Description = Request.Form["description"];
            _Story.AuthorID = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            try
            {
                cnt.Cmd.CommandText = $"insert into Story values ('{_Story.Title}','{_Story.Description}',0,{_Story.AuthorID},'')";
                cnt.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cnt.CloseConnect();
                //Response.Redirect($"/author/uploaded/{Session["UserID"]}");
            }

        }
    }
}