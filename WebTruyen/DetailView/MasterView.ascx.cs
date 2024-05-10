using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTruyen.Model;

namespace WebTruyen.DetailView
{
    public partial class IntroductView : System.Web.UI.UserControl
    {
        public StoryModel _Story { get; set; } = new StoryModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);
            try
            {
                cnt.Cmd.CommandText = $"Select * from StoryDetail where StoryID = {id}";

                var reader =  cnt.Cmd.ExecuteReader();
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
                cnt.Cmd.CommandText = "dbo.GetTypeByStory";
                cnt.Cmd.CommandType = CommandType.StoredProcedure;
                cnt.Cmd.Parameters.Add(
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = _Story.StoryID
                        }
                    );

                cnt.adapter.TableMappings.Add("Type","TypeOfStory");
                cnt.adapter = new SqlDataAdapter(cnt.Cmd);

                DataTable dt = new DataTable();
                cnt.adapter.Fill(dt);

                ListType.DataSource = dt;
                ListType.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            } finally
            {
                cnt.CloseConnect();
            }
            IntroductImage.Src = _Story.CoverImageUrl;
            Introduction_Link.HRef = $"/detail/introduction/{_Story.StoryID}";
            ListChapter_Link.HRef = $"/detail/listchapter/{_Story.StoryID}";
            Comment_Link.HRef = $"/detail/comment/{_Story.StoryID}";
            ReadBook.HRef = $"/detail/content/{_Story.StoryID}?c=1";
            
        }
    }
}