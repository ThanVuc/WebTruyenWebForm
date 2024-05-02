using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class Form_DangKiTruyen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }
        }

        protected void AddStory_Click(object sender, EventArgs e)
        {
            if (Session["abc"] == null)
            {
            }
            string connectionString = @"Data Source=LAPTOP-1PD1RQEE\PHUNGUYEN;Initial Catalog=THANVUC_TRUYEN;Integrated Security=True;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=88888888"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TRUYEN (tentruyen, tacgia, mota) VALUES (@tentruyen, @tacgia, @mota)", connection);
                command.Parameters.AddWithValue("@tentruyen", TextBox1.Text);
                command.Parameters.AddWithValue("@gioithieu", TextBox2.Text);   
                command.ExecuteNonQuery();
            }
        }
    }
}