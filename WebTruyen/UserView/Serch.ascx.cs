using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.UserView
{
    public partial class Serch : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SerchBtn_Click(object sender, EventArgs e)
        {
            var subString = Request.Form["substring"];
            string url = $"/SerchStory?serchString={subString}";
            Response.Redirect(url);
        }
    }
}