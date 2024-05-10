using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTruyen.User;

namespace WebTruyen.AuthorView
{
    public partial class CheckLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/Login");
            }
            else
            {
                _Connection cnt = new _Connection();
                int userID = Convert.ToInt32(Session["userID"]);
                try
                {
                    cnt.adapter.TableMappings.Add("chapter", "Chapter");
                    cnt.Cmd.CommandText = $"Select * from Author where AuthorID = {userID}";

                    var check = cnt.Cmd.ExecuteScalar();

                    if (check != null)
                    {
                        Response.Redirect($"/author/uploaded/{userID}");
                    }
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

        protected void CreateAliase_Click(object sender, EventArgs e)
        {
            string Aliase = Request.Form["Aliase"];
            int userID = Convert.ToInt32(Session["userID"]);
            _Connection cnt = new _Connection();
            try
            {
                cnt.Cmd.CommandText = $"select AvatarUrl from StoryUser where UserID={userID}";
                var avartarUrl = cnt.Cmd.ExecuteScalar().ToString();


                cnt.Cmd.CommandText = $"insert into Author values ({userID},N'{Aliase}',0,'{avartarUrl}')";

                cnt.Cmd.ExecuteNonQuery();

                Response.Redirect($"/author/uploaded/{userID}");
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