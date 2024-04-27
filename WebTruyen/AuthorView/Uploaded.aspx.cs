using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTruyen.AuthorView
{
    public partial class FormUpChapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int logged = Convert.ToInt32(Session["logged"]);
            if (logged == 0)
            {
                Response.Redirect("/login");
            }

            var sqlconnectstring = @"Data Source=localhost;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=88888888";
            var connection = new SqlConnection(sqlconnectstring);
            connection.Open();


            // TẠO DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Thiết lập bảng trong DataSet ánh xạ tương ứng có tên là Nhanvien
            adapter.TableMappings.Add("Table", "Story");

            // SelectCommand - Thực thi khi gọi Fill lấy dữ liệu về DataSet
            adapter.SelectCommand = new SqlCommand(@"SELECT * FROM Story", connection);

            DataSet dataSet = new DataSet();

            // Thực hiện lấy dữ liệu từ nguồn về DataSet
            adapter.Fill(dataSet);
            DataTable dt = dataSet.Tables["Story"];

            Grid_Uploaded.DataSource = dt;
            Grid_Uploaded.DataBind();
        }


        protected void btn_Delete(object sender, EventArgs e)
        {
        }

    }
}