<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<MVCpart.CarSummeryService.Car_ViewModel>>" %>
<div class="CarSelect">
    <% 
        string path;
        int i = 0;
        if (Model != null)
            foreach (var item in Model)
            {
    %>
    <div class="SelectBox">
        <div class="CarImage">
            <%          
                    i++;
                    path = "path" + i;
                    Session[path] = item.Version_IMG; 
            %>
            <img src="/Pic.ashx?ID=<%=i %>" width="150px" height="110px" />
        </div>
        <div class="CarInfo">
            车辆名称:<%: item.Version_Name %><br />
            车辆类型:<%: item.Type_Name %><br />
            品牌系列:<%: item.Brand_Name %><br />
            乘坐人数:<%: item.Version_Person %>
        </div>
        <div class="CarPrice">
            <div>
                <div style="color: #8E8E8E; font-size: 1.4em; line-height: 30px">
                    <img src="/Images/dot09.gif" />
                    市场价:
                    <%: String.Format("{0:F}", item.Version_Price_Normal_Rental) %><br />
                </div>
                <div style="color: red; font-size: 1.4em; line-height: 30px">
                    <img src="/Images/dot10.gif" />
                    会员价:
                    <%: String.Format("{0:F}", item.Version_Price_Member_Rental) %><br />
                </div>
                <div style="color: #1172C4; font-size: 1.4em; line-height: 30px">
                    <img src="/Images/dot11.gif" />
                    联系电话:
                    <%: item.Shop_Phone %>
                </div>
            </div>
        </div>
        <div class="CarOrder">
            <div>
                <%          
                    i++;
                    path = "path" + i;
                    Session[path] = item.Brand_IMG; 
                %>
                <img src="/Pic.ashx?ID=<%=i %>" /><br />
              <a href="
              <%if(Session["ShopSelect"]==null){ %>
              <%=Url.Action("SelectInfo", new {CityID=Session["CityID"].ToString(),VersionID = item.Version_ID }) %>
              <%}else{ %>
              <%=Url.Action("SelectInfo", new {CityID= Session["CityID"].ToString(),ShopID=Session["ShopSelect"].ToString(),VersionID = item.Version_ID }) %>
              <%} %>
              "><img src='../../Images/btn03.gif'/></a> 
            </div>
        </div>
    </div>
    <% } %>
    <div style="height: 50px; padding-top: 10px;">
        <span class="Sbotton">
            <%:Ajax.ActionLink("首页","SelectPage",new {ID=1},new AjaxOptions(){HttpMethod="Post",UpdateTargetId="SelectResult"}) %>
        </span><span class="Sbotton">上一页</span>
        <%for (int k = 1; k <= Convert.ToInt32(ViewData["Count"].ToString()) / 10 + 1; k++)
          { %>
        <span class="Sbotton">
            <%:Ajax.ActionLink(k.ToString(), "SelectPage", new { ID = k }, new AjaxOptions() { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
        </span>
        <%} %>
        <span class="Sbotton">下一页</span> <span class="Sbotton">
            <%:Ajax.ActionLink("末页", "SelectPage", new { ID = Convert.ToInt32(ViewData["Count"].ToString()) / 10 + 1 }, new AjaxOptions() { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
        </span>
        <div style="float: right;">
            <span>总共<%=ViewData["Count"]%>条数据&nbsp;&nbsp;&nbsp;&nbsp; 10条/页&nbsp;&nbsp;&nbsp;&nbsp;
                共<%=Convert.ToInt32(ViewData["Count"].ToString())/10+1 %>页</span>
        </div>
    </div>
</div>
