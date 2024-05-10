using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebTruyen
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("Login", "login", "~/User/Login.aspx");
            routes.MapPageRoute("_Register", "register", "~/User/Register.aspx");

            routes.MapPageRoute("Index", "", "~/UserView/HomePage.aspx");
            routes.MapPageRoute("TypeOfStory", "Type", "~/UserView/TypeOfStory.aspx");
            routes.MapPageRoute("ListStory", "ListStory/{id}", "~/UserView/ListStory.aspx");
            routes.MapPageRoute("SerchStory", "SerchStory", "~/UserView/SerchStory.aspx");

            routes.MapPageRoute("Content", "detail/content/{id}", "~/DetailView/Content.aspx");
            routes.MapPageRoute("Comment", "detail/comment/{id}", "~/DetailView/Comment.aspx");
            routes.MapPageRoute("Introduction", "detail/introduction/{id}", "~/DetailView/Introduction.aspx");
            routes.MapPageRoute("Listchapter", "detail/listchapter/{id}", "~/DetailView/ListChapter.aspx");



            routes.MapPageRoute("AddNew", "author/addnew/{id}", "~/AuthorView/AddNew.aspx");
            routes.MapPageRoute("Uploaded", "author/uploaded", "~/AuthorView/CheckLoggin.aspx");
            routes.MapPageRoute("Uploaded1", "author/uploaded/{id}", "~/AuthorView/Uploaded.aspx");
            routes.MapPageRoute("AddChapter", "author/addchapter/{id}", "~/AuthorView/AddChapter.aspx");
            routes.MapPageRoute("Edit", "author/Edit/{id}", "~/AuthorView/Edit.aspx");
            routes.MapPageRoute("Chapters", "author/chapters/{id}", "~/AuthorView/ListChapter.aspx");
            routes.MapPageRoute("Error", "{*.aspx}", "~/Error.aspx");
        }
    }
}
