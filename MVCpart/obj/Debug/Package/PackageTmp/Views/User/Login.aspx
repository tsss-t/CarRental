<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCpart.Models.UserLoginViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Login
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="../../Content/UserLogin.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function change() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "../../WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }   
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <%Html.RenderPartial("LoginPart"); %>
</asp:Content>
