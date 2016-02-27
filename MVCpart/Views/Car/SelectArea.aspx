<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCpart.ProvinceService.Car_Province>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    地点选择
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="../../Content/CarSelect.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        地点选择</h2>
    <div class="CarSelect">
        <div class="SelectBoxCity">
            <% foreach (var item in Model)
               { %>
            <div class="SbottonCity">
                <%:Ajax.ActionLink(item.Province_Name.ToString(), "SelectCity",
                                   new { ID = item.Province_ID }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "CityBox" })%>
            </div>
            <% } %>
        </div>
        <div id="CityBox">
        </div>
    </div>
</asp:Content>
