<%@ Page Language="C#" MasterPageFile="~/AuthorView/Author.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebTruyen.AuthorView.Edit" %>

<asp:Content runat="server" ContentPlaceHolderID="AuthorContent">
    <formview>
        <div class="d-flex justify-content-between">
            <h2>Nhập Thông Tin Cập Nhật: </h2>
            <asp:Button runat="server" Text="Xóa Truyện" ID="btn_delete" CssClass="btn btn-danger m-2" OnClick="btn_delete_Click" />
        </div>
        <div class="container-fluid">
    <div class="mb-3 mt-3" for="" >
        <label for="name" class="form-label">Tên Truyện: </label>
        <input class="form-control" id="name" name="name" />
    </div>
    <div class="mb-3 mt-3"  >
        <label for="author" class="form-label">Tên Tác Giả: </label>
        <input class="form-control" id="author" name="author" />
    </div>
    <div class="mb-3 mt-3" for="" >
        <label for="" class="form-label">Giới Thiệu</label>
        <textarea class="form-control" rows="5" id="" ></textarea>
    </div>
            <asp:Button CssClass="btn btn-outline-warning p-3 px-4" ID="btn_update" runat="server" Text="Cập Nhật" OnClick="btn_update_Click" />
</div>
    </formview>
</asp:Content>
