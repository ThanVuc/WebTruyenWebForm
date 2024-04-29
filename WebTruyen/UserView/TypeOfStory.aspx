<%@ Page Title="Contact" Language="C#" MasterPageFile="~/UserView/Home.Master" AutoEventWireup="true" CodeBehind="~/UserView/TypeOfStory.aspx.cs" Inherits="WebTruyen.UserView.TypeOfStory" %>

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
            }
    </style>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="alert alert-info d-flex justify-content-center">
            <strong class="thongBao">Thông Báo!</strong> Ghi thông báo vào đây!! .
        </div>
        <div class="main">
        
            <div class="mainTruyen row">
                <div class="col-12">
                    <p class="tabName">
                    </p>
                </div>
            </div>
            <asp:GridView ID="GridView_Type" HeaderStyle-Font-Size="0" BorderStyle="None" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                                <div>
                                    <a href="/liststory/<%# Eval("TypeID") %>" class="btn btn-outline-secondary mb-2 ms-4" style="width: 10vw; height: 8vh; font-size: 100%">
                                        <%# Eval("TypeName") %>
                                    </a>
                                </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        
    </main>

</asp:Content>
            
        
