<%@ Page Language="C#" MasterPageFile="~/DetailView/Detail.Master" AutoEventWireup="true" CodeBehind="ListChapter.aspx.cs" Inherits="WebTruyen.DetailView.ListChapter" %>

<asp:Content ContentPlaceHolderID="DetailMaster" runat="server" ID="gioithieu" >
    <style>
        .Chapter tbody{
            width: 90%;
            display: flex;
            flex-direction: column
        }
        .Chapter tbody tr{
            width: 100%;
            margin-right: 10px;
        }
        .Chapter tbody tr td{
            width: 74vw;
        }
        .Chapter tbody tr td a{
            text-overflow: ellipsis;
            white-space: nowrap;
            overflow: hidden;
            text-align: start;
        }

    </style>

    <div class="container-fluid row" style="padding-left: 14%">
        <asp:DataList ID="ChapterList" runat="server" CssClass="Chapter" >
            <ItemTemplate>
                <a href="/detail/content/<%# Eval("StoryID") %>?c=<%# Eval("ChapterNums") %>" class="btn btn-secondary m-2 w-100" ><%# Eval("ChapterNums") %>.  <%# Eval("ChapterName") %></a>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <hr />
    <br />
</asp:Content>
