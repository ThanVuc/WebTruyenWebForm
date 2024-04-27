<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebTruyen.User.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
   <script src="https://kit.fontawesome.com/e35e1d8f1c.js" crossorigin="anonymous"></script>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <label id="err" runat="server" class="text-danger text-center" ></label>
    <form id="form1" runat="server">
        <h1 class="ms-2">Đăng Kí</h1>
        <div class="container-fluid p-4">
            <label class="form-label" for="UserName">Tên Đăng Nhập</label>
            <input class="form-control mb-2" type="text" id="UserName" name="UserName" />
            <label class="form-label" for="FullName">Họ Và Tên</label>
            <input class="form-control mb-2" type="text" id="FullName" name="FullName" />
            <label class="form-label" for="Birth">Ngày Sinh</label>
            <input class="form-control mb-2" type="date" id="Birth" name="Birth" />
            <label class="form-label" for="password">Mật Khẩu</label>
            <input class="form-control mb-2" type="password" id="Password" name="Password" />
            <label class="form-label" for="Confirm">Xác Nhận Mật Khẩu</label>
            <input class="form-control mb-2" type="password" id="Confirm" name="Confirm" />
            <asp:Button CssClass="btn btn-outline-success mb-2 p-3 px-4" Text="Register" runat="server" ID="btn_Register" OnClick="btn_Register_Click" />
        </div>
        <p class="ms-2">Go To Login <a href="/login" >Login</a></p>
    </form>
</body>
</html>
