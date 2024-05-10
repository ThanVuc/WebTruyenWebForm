using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTruyen.Model
{
    public class ChapterModel
    {
        public int ChapterID { get; set; }
        public string ChapterName { get; set; }
        public string Content { get; set; }
        public int ChapterNums { get; set; }
        public int StoryID { get; set; }
    }
}