using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTruyen.Model;

namespace WebTruyen.DetailView
{
    public partial class GioiThieu : System.Web.UI.Page
    {
        public StoryModel _Story { get; set; } = new StoryModel();
        public AuthorModel _Author { get; set; } = new AuthorModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            try
            {
                cnt.Cmd.CommandText = $"Select * from StoryDetail where StoryID = {id}";

                var reader = cnt.Cmd.ExecuteReader();
                while (reader.Read())
                {
                    _Story.StoryID = reader.GetInt32(0);
                    _Story.Title = reader["Title"].ToString();
                    _Story.Description = reader["Description_"].ToString();
                    _Story.StoryView = Convert.ToInt32(reader["StoryView"]);
                    _Story.AuthorID = Convert.ToInt32(reader["AuthorID"]);
                    _Story.CoverImageUrl = reader["CoverImageUrl"].ToString();
                    _Story.NumsChapter = Convert.ToInt32(reader["NumsChapter"]);
                }
                reader.Close();

                cnt.Cmd.CommandText = $"Select * from Author where AuthorID = {_Story.AuthorID}";
                reader = cnt.Cmd.ExecuteReader();
                while (reader.Read())
                {
                    _Author.AuthorID = reader.GetInt32(0);
                    _Author.Aliases = reader["Aliases"].ToString();
                    _Author.AuthorView = Convert.ToInt32(reader["AuthorView"]);
                    _Author.AuthorAvartar = reader["AuthorAvartar"].ToString();
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
            AuthorAvartar.Src = _Author.AuthorAvartar;
        }
    }
}