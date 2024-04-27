<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="AddChapter.aspx.cs" Inherits="WebTruyen.AuthorView.AddChapter" %>

<asp:Content ID="AddChapter" runat="server" ContentPlaceHolderID="AuthorContent">
    <main>

    <formview>
        <h2>Thêm Chương: </h2>
         <div class="container-fluid">
            <div class="mb-3 mt-3" for="" >
                <label for="title" class="form-label">Tiêu Đề Chương: </label>
                <input class="form-control" id="title" name="title" />
            </div>
            <div class="mb-3 mt-3" for="" >
                <label for="Content" class="form-label">Nội Dung Chương:</label>
                <textarea class="form-control" rows="10" id="Content" ></textarea>
            </div>
            <asp:Button CssClass="btn btn-outline-success p-3 px-4" ID="Button1" runat="server" Text="Thêm Chương Mới" />
        </div>
    </formview>
</main>
</asp:Content>