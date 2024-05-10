<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MasterView.ascx.cs" Inherits="WebTruyen.DetailView.IntroductView" %>

<style>
    tbody{
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
    }
    tbody tr{
        margin-bottom: 2%;
    }
</style>

<form id="MasterViewForm">
    <div class="content">
        <div class="tren container">
            <div class="left">
                <img runat="server" id="IntroductImage" alt="">
            </div>
            <div class="right">
            <div class="tieude">
                <a1 href="#">
                    <% Response.Write(_Story.Title); %>
                </a1>
            </div>

            <br>
                <asp:DataList ID="ListType" runat="server">
                    <ItemTemplate>
                        <a href="/liststory/<%# Eval("TypeID") %>" ><%# Eval("TypeName") %></a>
                    </ItemTemplate>
                </asp:DataList>
            <br>

            <br>
            <div class="chu d-flex flex-row ms-5" style="font-size: 25px" >
                <div class="d-flex flex-column me-5">
                    <p>
                        <strong>
                            <% Response.Write(_Story.NumsChapter); %>
                        </strong>
                    </p>
                    <p> <strong>Chương</strong></p>
                </div>
                <div class="d-flex flex-column">
                    <p> 
                        <strong>
                            <% Response.Write(_Story.StoryView); %>
                        </strong>
                    </p>
                    <p> <strong>Lượt đọc</strong></p>
                </div>

            </div>
            <br>
            <div class="doctruyen">
                <a runat="server" id="ReadBook" >
                    Đọc Truyện
                </a>
            </div>
            <br>
            <br>
            <div class="cmt">
                <a runat="server" id="Introduction_Link" >Giới Thiệu</a>
                <a runat="server" id="ListChapter_Link" >Danh Sách Chương</a>
                <a runat="server" id="Comment_Link" >Bình Luận</a>
            </div>
        </div>
        </div>
    </div>
</form>

