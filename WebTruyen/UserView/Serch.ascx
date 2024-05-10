<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Serch.ascx.cs" Inherits="WebTruyen.UserView.Serch" %>

<formview>
    <input type="text" id="subString" name="subString" class="texSearchBar" />
    <asp:Button runat="server" ID="SerchBtn" BorderStyle="None" Text="Tìm" OnClick="SerchBtn_Click" />
</formview> 