<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DetailView/Detail.Master" CodeBehind="Comment.aspx.cs" Inherits="WebTruyen.DetailView.Comment" %>

<asp:Content ContentPlaceHolderID="head" runat="server" ID="Head1" >
    <style>
        .Comment tbody{
            width: 90%;
            display: flex;
            flex-direction: column
        }
        .Comment tbody tr{
            width: 100%;
            margin-right: 10px;
        }
        .Comment tbody tr td{
            width: 74vw;
        }
        .Comment tbody tr td a{
            text-overflow: ellipsis;
            white-space: nowrap;
            overflow: hidden;
            text-align: start;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="DetailMaster" runat="server" ID="Commnet" >
    <div class="tong">
        <div class="cha">
            <div class="left2">
                <img src="#" runat="server" id="Avatar" alt="">
            </div>
            <div class="right2">
                <formview>
                    <input class="form-control ms-2" id="cmtInp" name="cmtInp" style="width: 70vw; height: 14vh" type="text"  />
                    <asp:Button ID="CommentSubmit" runat="server" BorderStyle="None" OnClick="CommentSubmit_Click" />
                </formview>
                     <br>
                <div class="noidung">
                    <asp:DataList CssClass="Comment" ID="CommentList" runat="server">
                        <ItemTemplate>
                            <p2><%# Eval("content") %></p2>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            
            </div>
        </div>
    </div>

</asp:Content>
