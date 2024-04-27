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
            routes.MapPageRoute("ListStory", "ListStory", "~/UserView/ListStory.aspx");

            routes.MapPageRoute("AddNew", "author/addnew", "~/AuthorView/AddNew.aspx");
            routes.MapPageRoute("Uploaded", "author/uploaded", "~/AuthorView/Uploaded.aspx");
            routes.MapPageRoute("AddChapter", "author/addchapter/{id}", "~/AuthorView/AddChapter.aspx");
            routes.MapPageRoute("Edit", "author/Edit/{id}", "~/AuthorView/Edit.aspx");
            routes.MapPageRoute("Chapters", "author/chapters/{id}", "~/AuthorView/ListChapter.aspx");
            routes.MapPageRoute("Error", "{*.aspx}", "~/Error.aspx");
        }
    }
}
