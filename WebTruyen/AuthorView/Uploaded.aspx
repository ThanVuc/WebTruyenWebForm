<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="Uploaded.aspx.cs" Inherits="WebTruyen.AuthorView.FormUpChapter" %>


<asp:Content ID="Uploaded" ContentPlaceHolderID="AuthorContent" runat="server" >
    <h2 class="ms-1">Danh Sách Truyện Đã Đăng:</h2>
    <asp:GridView runat="server" ID="Grid_Uploaded">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <p><strong>Tên Truyện</strong></p>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="d-flex flex-row">
                        <p><strong><%#Eval("StoryName")%></strong></p>
                        <asp:Button CssClass="btn btn-secondary fa-solid fa-plus" runat="server" />
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
