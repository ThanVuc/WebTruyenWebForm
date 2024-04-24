<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebTruyen.User.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./login.css" />
    <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet' />
</head>
<body runat="server">
    <div class="container" runat="server">
        <div class="wrapper" runat="server">
            <form id="form1" runat="server" method="post">
                <h1>Login</h1>
                <div class="input-box">
                    <input id="user" runat="server" type="text" name="user" placeholder="Username" required />
                    <i class='bx bxs-user-rectangle'></i>
                </div>
                <div class="input-box">
                    <input id="password" runat="server" type="password" name="password" placeholder="Password" required/>
                    <i class='bx bxs-lock-alt' ></i>
                </div>
                <div class="remember-forgot">
                    <label><input type="checkbox" />Remember me</label>
                    <a href="#">Forgot password?</a>
                </div>
                <asp:Button CssClass="btn" runat="server" Text="Login" OnClick="Submit_Click" />
                <div class="register-link">
                    <p>Don't have an account?<a href="#">Register</a></p>
                </div>
            </form>
            <label id="lb1" runat="server" ></label>
        </div>
    </div>
</body>
</html>
