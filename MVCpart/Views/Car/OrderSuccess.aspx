<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OrderSuccess
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div style="width:80%;margin-left:auto;margin-right:auto;margin-top:50px;margin-bottom:50px;padding:30px auto;line-height:200px;  border:solid 2px #2e2e2e;">
    <center>
        恭喜,您已经预订成功,请于2日内到店铺进行定金付款手续,否则系统将自动取消您的订单!
        </center>
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
</asp:Content>
