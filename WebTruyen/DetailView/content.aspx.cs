using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.DetailView
{
    public partial class content : System.Web.UI.Page
    {

        public string StoryTitle { get; set; }
        public string Content { get; set; }
        public string ChapterName { get; set; }
        public int? Nums { get; set; }
        public int? Total { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Nums = Convert.ToInt32(Request.QueryString["c"]);

            var id = Request.RequestContext.RouteData.Values["id"].ToString();
            if (Nums != null)
            {
                _Connection cnt = new _Connection();
                cnt.Cmd.CommandText = $"Select c.ChapterName, c.Content, s.Title from Chapter c, Story s where c.StoryID=s.StoryID and c.StoryID = {id} and ChapterNums = {Nums}";

                var reader = cnt.Cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChapterName = reader["ChapterName"].ToString();
                    Content = reader["Content"].ToString();
                    StoryTitle = reader["Title"].ToString();
                }
                reader.Close();

                cnt.Cmd.CommandText = $"Select Max(ChapterNums) from Chapter Where StoryID = {id}";

                Total = Convert.ToInt32(cnt.Cmd.ExecuteScalar());

                cnt.CloseConnect();
            }
            else
            {
                Response.Redirect("/Error");
            }
            if (Nums > 1)
            {
                prev.HRef = $"/detail/content/1?c={Nums-1}";
            }
            
            if (Nums<Total)
            next.HRef = $"/detail/content/1?c={Nums+1}";
        }
    }
}