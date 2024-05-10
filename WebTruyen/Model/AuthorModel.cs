using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WebTruyen.Model
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string Aliases { get; set; }
        public int AuthorView { get; set; }
        public string AuthorAvartar { get; set; }
    }
}