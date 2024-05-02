using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class AddChapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-1PD1RQEE\PHUNGUYEN;Initial Catalog=THANVUC_TRUYEN;Integrated Security=True;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=88888888";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM TRUYEN WHERE matruyen = @matruyen", connection);
                    command.Parameters.AddWithValue("@matruyen", DropDownList1.SelectedValue);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBox1.Text = reader["tentruyen"].ToString();
                    }
                }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-1PD1RQEE\PHUNGUYEN;Initial Catalog=THANVUC_TRUYEN;Integrated Security=True;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=88888888"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO CHAPTER (title, content) VALUES (@title, @content)", connection);
                command.Parameters.AddWithValue("@title", TextBox1.Text);
                command.Parameters.AddWithValue("@content", TextBox2.Text);
                command.ExecuteNonQuery();
            }
        }
    }
}