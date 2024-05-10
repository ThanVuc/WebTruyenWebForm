<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DetailView/Detail.Master" CodeBehind="Introduction.aspx.cs" Inherits="WebTruyen.DetailView.GioiThieu" %>


<asp:Content ContentPlaceHolderID="DetailMaster" runat="server" ID="gioithieu" >
    <div class="content">
        <div class="left1">
            <div class="noidung" style="background-color: antiquewhite; padding: 10px" >
                <p style="font-size: 20px;" ><% Response.Write(_Story.Description); %></p>
            </div>
        </div>
        <div class="right1">
            <div class="anh">
                <img runat="server" id="AuthorAvartar" src="" alt="">
                <div class="chu">
                    Khong
                </div>

            </div>
            <br>
            <br>
            <p5 class="text-center" ><% Response.Write(_Author.Aliases); %></p5>
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
