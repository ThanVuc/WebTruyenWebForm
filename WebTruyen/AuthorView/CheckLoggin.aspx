<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckLoggin.aspx.cs" Inherits="WebTruyen.AuthorView.CheckLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label class="form-label" for="Aliase">Nhập Bí Danh: </label>
            <input class="form-control" id="Aliase" name="Aliase" />
            <asp:Button CssClass="btn btn-outline-success" runat="server" Text="Confirm" ID="CreateAliase" OnClick="CreateAliase_Click" />
        </div>
    </form>
</body>
</html>
