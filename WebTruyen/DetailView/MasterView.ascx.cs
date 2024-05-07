using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.DetailView
{
    public partial class IntroductView : System.Web.UI.UserControl
    {

        public class StoryModel
        {
            public StoryModel()
            {
            }

            public StoryModel(int storyID, string title, string description, int storyView, int authorID, string coverImageUrl)
            {
                StoryID = storyID;
                this.Title = title;
                Description = description;
                StoryView = storyView;
                AuthorID = authorID;
                CoverImageUrl = coverImageUrl;
            }



            public int StoryID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int StoryView { get; set; }
            public int AuthorID { get; set; }
            public string CoverImageUrl { get; set; }

            public int NumsChapter { get; set; }

        }

        public StoryModel _Story { get; set; } = new StoryModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection cnt = new _Connection();
            try
            {
                int id = Convert.ToInt32(Request.RequestContext.RouteData.Values["id"]);

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

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            } finally
            {
                cnt.CloseConnect();
            }
            IntroductImage.Src = _Story.CoverImageUrl;
        }
    }
}