<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManage.aspx.cs" Inherits="WebTruyen.UserView.ChangeAvatar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <label runat="server" id="message" class="alert alert-info mb-2" style="width: 100%" ></label>
    <a href="/" style="color: black" >Trở Lại Trang Chủ</a>
    <form id="form1" runat="server">
        <h1 style="text-align: center; color: burlywood" >Thay Đổi Ảnh Đại Diện</h1>
        <div class="container-fluid p-5" >
            <label for="FileUpload">Chọn Ảnh Cần Đổi</label>
            <asp:FileUpload runat="server" CssClass="form-control p-5 m-2 mb-3" Id="FileUpload" />
            <asp:Button runat="server" CssClass="btn btn-outline-info" ID="ChangeAvatarBtn" Text="Thay Đổi" OnClick="ChangeAvatarBtn_Click"   />
        </div>
        <h1 style="text-align: center; color: red" >Xóa Tài Khoản</h1>
        <div class="container-fluid p-5" >
            <label class="alert alert-danger" style="width: 91vw; text-align: center" for="FileUpload">Bạn nên cân nhắc kỹ lưỡng trước quyết định này!</label>
            <br />
            <asp:Button runat="server" CssClass="btn btn-outline-danger p-3 px-5" ID="Drop_Account" Text="Xóa" OnClick="Drop_Account_Click"   />
        </div>
    </form>
</body>
</html>
