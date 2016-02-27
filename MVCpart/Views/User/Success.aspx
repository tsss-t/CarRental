<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Success
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:80%;margin-left:auto;margin-right:auto;margin-top:50px;margin-bottom:50px;padding:30px auto;line-height:200px;  border:solid 2px #2e2e2e;">
    <center>
    恭喜!<%:ViewData["Massage"] %>!
    <%:Html.ActionLink("点此","Index","Home",null,null) %>
    回到主页,或者<a href='
    
    <%if(Session["BackUrl"]!=null){ %>
    <%=(String)Session["BackUrl"] %>
    <%}
    else{
     %>
     <%:Url.Action("Index","Home") %>
     <%
    }
     %>
    
    
    '>点此</a>回到登陆前页面
    
    </center>
    </div>
</asp:Content>

