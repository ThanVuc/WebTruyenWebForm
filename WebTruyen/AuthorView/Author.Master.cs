using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addnew_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/author/addnew");
        }

        protected void uploaded_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/author/uploaded");
        }
    }
}