<%@ Page Language="C#" MasterPageFile="~/AuthorView/Author.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebTruyen.AuthorView.Edit" %>

<asp:Content runat="server" ContentPlaceHolderID="AuthorContent">
    <label style="color: burlywood" id="message" runat="server" ></label>
    <hr />
    <formview>
        <div class="d-flex justify-content-between">
            <h2>Nhập Thông Tin Cập Nhật: </h2>
            <asp:Button runat="server" Text="Xóa Truyện" ID="btn_delete" CssClass="btn btn-danger m-2" OnClick="btn_delete_Click" />
        </div>
        <div class="container-fluid">
    <div class="mb-3 mt-3" for="" >
        <label for="title" class="form-label">Tên Truyện: </label>
        <input class="form-control" id="title" name="title" value="<% Response.Write(title); %>" />
    </div>
    <div class="mb-3 mt-3" for="" >
        <label for="" class="form-label">Giới Thiệu</label>
        <textarea class="form-control" rows="5" id="description" name="description" ></textarea>
    </div>
            <asp:Button CssClass="btn btn-outline-warning p-3 px-4" ID="btn_update" runat="server" Text="Cập Nhật" OnClick="btn_update_Click" />
</div>
    </formview>
</asp:Content>
