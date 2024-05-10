<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DetailView/Detail.Master" CodeBehind="Introduction.aspx.cs" Inherits="WebTruyen.DetailView.GioiThieu" %>


<asp:Content ContentPlaceHolderID="DetailMaster" runat="server" ID="gioithieu" >
    <div class="content">
        <div class="left1">
            <div class="noidung" style="background-color: antiquewhite; padding: 10px" >
                <p style="font-size: 20px;" ><% Response.Write(_Story.Description); %></p>
            </div>
        </div>
        <div class="right1">
            <div class="d-flex flex-column align-items-center pt-5 ">
                <img style="width: 30%; height: auto" runat="server" id="AuthorAvatar" src="" alt="">
                <p style="font-size: 20px; font-weight: 700; font-family: sans-serif" ><% Response.Write(_Author.Aliases); %></p>
            </div>
            <br>
            <br>
            <div class="duoi" style="display: flex; flex-direction: row; flex-wrap: wrap; justify-content: center" >
                <div>
                    <p7>Số Lượt Xem</p7>
                    <p8> <% Response.Write(_Author.AuthorView); %> </p8>
                </div>      
            </div>


        </div>
    </div>
    <br />
    <br />
</asp:Content>
