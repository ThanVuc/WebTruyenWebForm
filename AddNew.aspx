<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNew.aspx.cs" MasterPageFile="~/AuthorView/Author.Master" Inherits="WebTruyen.AuthorView.Form_DangKiTruyen" %>


<asp:Content ID="AddNew" ContentPlaceHolderID="AuthorContent" runat="server" >
    <main>
    
    <div class="display-2 ms-2"><strong class="auto-style1">THÊM TRUYỆN</strong></div>

    <formview>
        <div class="container-fluid">
            <div class="mb-3 mt-3" for="" >
                <label for="name" class="form-label">Tên Truyện: </label>
                <asp:TextBox ID="TextBox1" runat="server" Width="1021px"></asp:TextBox>
                <input class="form-control" id="name" name="name" />
            </div>
            <div class="mb-3 mt-3" for="" >
                <label for="description" class="form-label">Giới Thiệu</label>
                <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="254px" Width="1111px"></asp:TextBox>
                <br />
            </div>
            <asp:Button CssClass="btn btn-outline-success p-3 px-4" ID="AddStory" runat="server" Text="Thêm Truyện" OnClick="AddStory_Click" />
        </div>
    </formview>
</main>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        font-weight: bold;
    }
</style>
</asp:Content>

