<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MasterView.ascx.cs" Inherits="WebTruyen.DetailView.IntroductView" %>

<form id="MasterViewForm" runat="server" >
    <div class="content">
        <div class="tren container">
            <div class="left">
                <img runat="server" id="IntroductImage" src="" alt="">
            </div>
            <div class="right">
            <div class="tieude">
                <a1 href="#">
                    <% Response.Write(_Story.Title); %>
                </a1>
            </div>
            <br>
            <a href="#">Quần Ngọc Sơn Đầu Kiếm</a>
            <a href="#">Đang Ra</a>
            <a href="#">Huyền Huyễn</a>
            <a href="#">Điềm Đạm</a>
            <a href="#">TXuyên Qua</a>
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
                <a href="#" >
                    Đọc Truyện
                </a>
            </div>
            <br>
            <br>
            <div class="cmt">
                <a href="#">Giới Thiệu</a>
                <a href="#">Danh Sách Chương</a>
                <a href="#">Bình Luận</a>
            </div>
        </div>
        </div>
    </div>
</form>

