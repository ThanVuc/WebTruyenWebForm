<%@ Page Title="Contact" Language="C#" MasterPageFile="~/UserView/Home.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebTruyen.HomePage" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/UserCss/home.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    <style>
        tbody{
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: left;
        }
            tbody trow th {
                padding: 0;
                width: 0;
                height: 0;
                font-size: 0;
                line-height: 0;
            }
        .card-img-top{
            height: 100%;
            width: 100%;
            object-fit: contain;
        }

        .card-body{
            width: 20vw;
            height: 30vh;
            display: flex;
            flex-direction: column;
            justify-content: center;
        }

        .card-body .card-title{
            height: 15vh;
            text-align: center;
        }

        .main{

        }

    </style>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>   
        <div class="main row">
            <div class="mainTruyen row col-9">
                <div class="col-12">
                    <asp:GridView ID="GridView_Home" AllowPaging="true" PageSize="4" BorderStyle="None" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="GridView_Home_PageIndexChanging">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="card m-2 me-5 box-card">
                                      <div style="height: 30vh; width: 20vw" >
                                          <img class="card-img-top" src="<%# Eval("CoverImageUrl")%>" />
                                      </div>
                                      <div class="card-body">
                                        <h5 class="card-title"><%# Eval("Title") %></h5>
                                        <a href="../detail/introduction/<%# Eval("StoryID") %>" class="btn btn-primary">Xem Thêm</a>
                                      </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerSettings Mode="NextPrevious" />
                        <PagerStyle CssClass="m-2 fixed-bottom"/>
                    </asp:GridView>
                    <br />
                    <br />
       
                </div>
            </div>

            <div class="col-3 bg-secondary bg-opacity-25">
                <p>Top nóng</p>

                <asp:GridView ID="GridView_Top" runat="server"  BorderStyle="None" AutoGenerateColumns="false" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a class="topItem text-dark p-3" href="../detail/introduction/<%# Eval("StoryID")%>" >
                                    <p class="topNumber me-2">
                                        <%# Nums++ %>
                                    </p>
                                    <img src="<%# Eval("CoverImageUrl")%>" class="topHotImg me-1" alt="" \>
                                    <div>
                                        <p class="topName"><%# Eval("Title") %></p>
                                    </div>
                                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
            
        
    </main>

</asp:Content>
            