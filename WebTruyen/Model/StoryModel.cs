using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTruyen.Model
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
            public string[] ListType { get; set; }
    }
}