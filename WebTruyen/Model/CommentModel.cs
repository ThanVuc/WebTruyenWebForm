using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTruyen.Model
{
    public class CommentModel
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public int StoryID { get; set; }
    }
}