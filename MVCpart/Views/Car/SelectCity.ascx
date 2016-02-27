<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<MVCpart.CityService.Car_City>>" %>
<div class="SelectBox">
    <% 
        foreach (var item in Model)
        { %>
    <div class="SbottonCity">
        <%:Html.ActionLink(item.City_Name.ToString(), "Select", new { ID = item.City_ID })%>
    </div>
    <% } %>
</div>
