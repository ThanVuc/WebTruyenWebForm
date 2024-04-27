<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="ListChapter.aspx.cs" Inherits="WebTruyen.AuthorView.ListChapter" %>


<asp:Content ID="Uploaded" ContentPlaceHolderID="AuthorContent" runat="server" >
    <h2 class="ms-1">Các Chương:</h2>
    <label id="lb1" runat="server" ></label>
    <asp:GridView runat="server" ID="Grid_Chapter" BorderStyle="None" AutoGenerateColumns="false" >
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <p><strong>Chương</strong></p>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="d-flex flex-row justify-content-between bg-black bg-opacity-25 m-2 rounded-3" style="width: 80vw">
                        <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("ChapterNums")%></strong></p>
                        <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("ChapterName")%></strong></p>                        
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <formview>
        <label for="chapterNum" >Nhập Chương: </label>
        <input type="number" ID="chapterNum" runat="server" />

        <asp:Button runat="server" Text="Xóa Truyện" ID="btn_delete" CssClass="btn btn-danger m-2" OnClick="btn_delete_Click" />
        
    </formview>
</asp:Content>
