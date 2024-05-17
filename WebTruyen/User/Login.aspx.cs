﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Security;

namespace WebTruyen.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                Session.Remove("logged");
                Session.Add("logged", 0);
            } else
            {
                Session.Add("logged", 0);
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var user = Request.Form["user"];
            var password = Request.Form["password"];
            string encodePassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password,"SHA1");
            _Connection cnt = new _Connection();
            cnt.Cmd.CommandText = "Select * from StoryUser Where UserName = @username and UserPassword = @userpassword";
            cnt.Cmd.Parameters.AddWithValue("@username",user);
            cnt.Cmd.Parameters.AddWithValue("@userpassword", encodePassword);
            var reader = cnt.Cmd.ExecuteReader();
            int? userID = null;
            
            while(reader.Read())
                userID = Convert.ToInt32(reader["UserID"]);
  
            if (userID != null)
            {
                // Session: Logged -> Khi nào Session["logged"] == 1 thì đã được đăng nhập, ==0 thì chưa
                // Session: userID -> Khi nào đã được đăng nhập, thì Session["userID"] sẽ chứa
                //giá trị của user đang sử dụng
                Session.Add("logged",1);
                Session.Add("userID",userID);
                Response.Cookies.Remove("userID");
                HttpCookie c = new HttpCookie("userID", userID.ToString());
                Response.Cookies.Add(c);
                Response.Cookies["userID"].Expires = DateTime.Now.AddDays(1);
                Response.Redirect("/");
            } else
            {
                err.InnerText = "Tên Đăng Nhập hoặt Mật Khẩu không chính xác";
            }
        }
    }
}