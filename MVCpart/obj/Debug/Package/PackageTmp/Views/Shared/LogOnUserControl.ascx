<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Session["UserName"]!=null) {
%>
        欢迎您，<b><%: Session["UserName"] %></b>!
        [ <%: Html.ActionLink("注销", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        <%: Html.ActionLink("登录", "Login", "User")%>
        <%: Html.ActionLink("免费注册","RegUser","User")%>
<%
    }
%>
