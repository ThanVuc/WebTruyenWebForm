<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="Uploaded.aspx.cs" Inherits="WebTruyen.AuthorView.FormUpChapter" %>


<asp:Content ID="Uploaded" ContentPlaceHolderID="AuthorContent" runat="server" >
    <h2 class="ms-1">Danh Sách Truyện Đã Đăng:</h2>
    <label id="lb1" runat="server" ></label>
    <asp:GridView runat="server" ID="Grid_Uploaded" BorderStyle="None" AutoGenerateColumns="false" >
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <p><strong>Truyện</strong></p>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="d-flex flex-row justify-content-between bg-black bg-opacity-25 m-2 rounded-3" style="width: 80vw">
                        <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("title")%></strong></p>
                        <div>
                            <a href="/author/addchapter/<%# Eval("StoryID") %>" class="btn btn-dark m-2 py-2">Thêm Chương</a>
                            <a href="/author/chapters/<%# Eval("StoryID") %>" class="btn btn-dark m-2 py-2 px-3">Chương</a>
                            <a href="/author/Edit/<%# Eval("StoryID") %>" class="btn btn-dark m-2 py-2 px-3">Chỉnh Sửa</a>

                        </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <label id="lb31" runat="server" ></label>
</asp:Content>
