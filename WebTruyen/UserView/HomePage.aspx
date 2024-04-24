<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebTruyen.HomePage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="alert alert-info d-flex justify-content-center">
            <strong class="thongBao">Thông Đít!</strong> Ghi thông báo vào đây!! .
        </div>
        <div class="main">
             <div class="whitespace">
                <p class="tabName">
                    Tép và những người bợn - ghi tiêu đề!
                </p>
             </div>
        </div>
        <div class="mainTruyen row">
            <div class="col-9">
                <p class="tabName">
                    Tép và những người bợn - ghi tiêu đề!
                </p>
                <div class="row">
                    <div class="ms-2 col-3 mb-4 TruyenItem">
                        <img src="#" / class="coverImg">
                        <p class="nameTruyen">
                            Tên chuyện Tên chuyện Tên chuyện Tên chuyện Tên chuyện
                        </p>
                    </div>             
                </div>
            </div>
            
            <div class="col-2 topBackgr">
                <p>Top nóng</p>
                <div class="topItem">
                    <p class="topNumber">
                        1.
                    </p>
                    <img src="#" class="topHotImg" alt=""\>
                    <div>
                        <p class="topName">nameTruyen</p>
                        <p class="topChapter">chapter</p>
                    </div>
                </div>
            </div>
        </div>

    </main>

</asp:Content>
            