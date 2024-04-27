<%@ Page Title="Contact" Language="C#" MasterPageFile="~/UserView/Home.Master" AutoEventWireup="true" CodeBehind="TypeOfStory.aspx.cs" Inherits="WebTruyen.HomePage" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/UserCss/home.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="alert alert-info d-flex justify-content-center">
            <strong class="thongBao">Thông Báo!</strong> Ghi thông báo vào đây!! .
        </div>
        <div class="main">
        
        <div class="mainTruyen row">
            <div class="col-12">
                <p class="tabName">
                    Thể Loại
                </p>
                <div class="row">
                    <div class="col-3 TruyenItem">
                        <a class="btn btn-outline-secondary nameTruyen">
                           Thể Loại Truyện
                        </a>
                    </div>             
                </div>
            </div>
        </div>
    </main>

</asp:Content>
            