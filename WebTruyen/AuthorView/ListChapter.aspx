<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" MasterPageFile="~/AuthorView/Author.Master" CodeBehind="ListChapter.aspx.cs" Inherits="WebTruyen.AuthorView.ListChapter" %>


<asp:Content ID="Uploaded" ContentPlaceHolderID="AuthorContent" runat="server" >
    <label style="color: red" runat="server" id="message" ></label>
    <br />
    <formview>
        <label for="ChapterNum" >Nhập ID Chương: </label>
        <input type="number" ID="ChapterNum" name="ChapterNum" />

        <asp:Button runat="server" Text="Xóa Chương" ID="btn_delete" CssClass="btn btn-danger m-2" OnClick="btn_delete_Click" />
    
    </formview>
    <h2 class="ms-1">Các Chương:</h2>
    <label id="lb1" runat="server" ></label>
    <asp:GridView runat="server" ID="Grid_Chapter" BorderStyle="None" AutoGenerateColumns="false" >
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <p><strong>Chương</strong></p>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="d-flex flex-row m-2 rounded-3" style="width: 80vw">
                        <div class="d-flex flex-row bg-info bg-opacity-50 m-2 rounded-3" style="width: 75vw">
                            <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("ChapterNums")%></strong></p>
                            <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("ChapterName")%></strong></p>
                        </div>
                        <p class="px-2 pt-2 mt-1" style="font-family: 'Times New Roman', Times, serif" ><strong><%#Eval("ChapterID")%></strong></p>                                                
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>
