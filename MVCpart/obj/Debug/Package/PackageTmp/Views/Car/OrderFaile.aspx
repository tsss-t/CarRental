<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    OrderFaile
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 80%; margin-left: auto; margin-right: auto; margin-top: 50px;
        margin-bottom: 50px; padding: 30px auto; line-height: 200px; border: solid 2px #2e2e2e;">
        <center>
            对不起,您的订单提交失败,请点击<a href="<%:Url.Encode(Session["BackUrl"].ToString()) %>">此处</a>回到前页重试!
        </center>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
</asp:Content>
