using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.DetailView
{
    public partial class Comment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            string comment = Request.Form["cmtInt"];
            int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            try
            {
                cnt.Cmd.CommandText = $"select Content from Comment where StoryID={id}";

                cnt.adapter.TableMappings.Add("comment","Comment");
                cnt.adapter = new System.Data.SqlClient.SqlDataAdapter(cnt.Cmd);
                DataTable dt = new DataTable();
                cnt.adapter.Fill(dt);

                CommentList.DataSource = dt;
                CommentList.DataBind();
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

        protected void CommentSubmit_Click(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            } else
            {
                int userID = Convert.ToInt32(Session["userID"]);
                _Connection cnt = new _Connection();
                string comment = Request.Form["cmtInp"];
                int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
                try
                {
                    cnt.Cmd.CommandText = $"insert into Comment(Content,UserID,StoryID) values ('{comment}',{userID},{id})";

                    var reader = cnt.Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    cnt.CloseConnect();
                }
                Page_Load(sender,e);
            }
            

        }
    }
}