<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCpart.CarSummeryService.Car_ViewModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    分类选择
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="/Content/CarSelect.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
        $(document).ready(function nocache() {
            $.ajaxSetup({ cache: false });
        }
    )
        function Clike(obj) {
            if ($(obj).hasClass("GroupOption")) {
                if ($(obj).parent().parent().attr("id") == "Shop") {
                    var objs = $("#Shop .GroupOptionClick");
                    objs.removeClass("GroupOptionClick");
                    objs.addClass("GroupOption");
                }
                if ($(obj).parent().parent().attr("id") == "Type") {
                    var objs = $("#Type .GroupOptionClick");
                    objs.removeClass("GroupOptionClick");
                    objs.addClass("GroupOption");
                }
                if ($(obj).parent().parent().attr("id") == "Price") {
                    var objs = $("#Price .GroupOptionClick");
                    objs.removeClass("GroupOptionClick");
                    objs.addClass("GroupOption");
                }
                if ($(obj).parent().parent().attr("id") == "Brand") {
                    var objs = $("#Brand .GroupOptionClick");
                    objs.removeClass("GroupOptionClick");
                    objs.addClass("GroupOption");
                }
                $(obj).removeClass("GroupOption");
                $(obj).addClass("GroupOptionClick");
                $(obj).children().click();
                $.ajaxSetup({ cache: false });
            }
        }
     
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Select">
        <div id="Shop" class="Group">
            <div class="GroupTitle">
                店铺分布</div>
            <div class="GroupOptions">
                <%
                    List<MVCpart.ShopService.Car_Shop> List_Shop = (List<MVCpart.ShopService.Car_Shop>)ViewData["ListShop"];
                    if (List_Shop != null)
                    {
                        foreach (var item in List_Shop)
                        {
                %>
                <span <%if (item.Shop_ID == 0){%>class="GroupOptionClick" <%} else{%> class="GroupOption"
                    <%} %> onclick="Clike(this);">
                    <%:Ajax.ActionLink(item.Shop_Name.ToString(), "SelectShop",
                      new { ID = item.Shop_ID }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span>
                <%
                        }
                    }
                %>
            </div>
        </div>
        <div id="Type" class="Group">
            <div class="GroupTitle">
                车辆类型</div>
            <div class="GroupOptions">
                <%   List<MVCpart.TypeService.Car_Type> List_Type = (List<MVCpart.TypeService.Car_Type>)ViewData["ListType"];
                     if (List_Type != null)
                     {
                         foreach (var item in List_Type)
                         {
                %>
                <span <%if (item.Type_ID == 0){%>class="GroupOptionClick" <%} else{%> class="GroupOption"
                    <%} %> onclick="Clike(this);">
                    <%:Ajax.ActionLink(item.Type_Name.ToString(), "SelectType",
                      new { ID = item.Type_ID }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span>
                <%
                         }
                     }
                %></div>
        </div>
        <div id="Price" class="Group">
            <span class="GroupTitle">租赁价额</span>
            <div class="GroupOptions">
                <span class="GroupOptionClick" onclick="Clike(this);">
                    <%:Ajax.ActionLink("全部", "SelectPrice",
                                              new { ID = 0 }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span><span class="GroupOption" onclick="Clike(this);">
                    <%:Ajax.ActionLink("0-199元/天", "SelectPrice",
                                              new { ID = 1 }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span><span class="GroupOption" onclick="Clike(this);">
                    <%:Ajax.ActionLink("200-499元/天", "SelectPrice",
                                              new { ID = 2 }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span><span class="GroupOption" onclick="Clike(this);">
                    <%:Ajax.ActionLink("500-999元/天", "SelectPrice",
                                              new { ID = 3 }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span><span class="GroupOption" onclick="Clike(this);">
                    <%:Ajax.ActionLink("1000元以上/天", "SelectPrice",
                                              new { ID = 4 }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span>
            </div>
        </div>
        <div id="Brand" class="Group">
            <span class="GroupTitle">品牌系列</span>
            <div class="GroupOptions">
                <%   List<MVCpart.BrandService.Car_Brand> List_Brand = (List<MVCpart.BrandService.Car_Brand>)ViewData["ListBrand"];
                     if (List_Brand != null)
                     {
                         foreach (var item in List_Brand)
                         {
                %>
                <span <%if (item.Brand_ID == 0){%>class="GroupOptionClick" <%} else{%> class="GroupOption"
                    <%} %> onclick="Clike(this);">
                    <%:Ajax.ActionLink(item.Brand_Name.ToString(), "SelectBrand",
                                                   new { ID = item.Brand_ID }, new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "SelectResult" })%>
                </span>
                <%
                         }
                     }
       
                %>
            </div>
        </div>
    </div>
    <div id="SelectResult">
        <%Html.RenderPartial("SelectCar", Model, ViewData);%>
    </div>
</asp:Content>
