<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="AddChapter.aspx.cs" Inherits="WebTruyen.AuthorView.AddChapter" %>

<asp:Content ID="AddChapter" runat="server" ContentPlaceHolderID="AuthorContent">
    <main>

    <formview>
        <h2><strong>THÊM CHƯƠNG VÀO TRUYỆN </strong>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style1" DataSourceID="Truyen" Height="81px" Width="668px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Truyen" runat="server"></asp:SqlDataSource>
</h2>
         <div class="container-fluid">
            <div class="mb-3 mt-3" for="" >
                <label for="title" class="form-label">Tiêu Đề Chương: </label>
                <asp:TextBox ID="TextBox1" runat="server" Width="953px"></asp:TextBox>
                <input class="form-control" id="title" name="title" />
            </div>
            <div class="mb-3 mt-3" for="" >
                <label for="Content" class="form-label">Nội Dung Chương:</label>
                <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="163px" OnTextChanged="TextBox2_TextChanged" Width="1124px"></asp:TextBox>
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" Width="339px" />
            </div>
            <asp:Button CssClass="btn btn-outline-success p-3 px-4" ID="Button1" runat="server" Text="Thêm Chương Mới" OnClick="Button1_Click" />
        </div>
    </formview>
</main>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        margin-top: 26;
    }
</style>
</asp:Content>
