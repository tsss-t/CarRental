<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCpart.CarSummeryService.Car_ViewModel>" %>

<%@ Import Namespace="MVCpart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    车辆详情
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="/Content/CarSelect.css" rel="stylesheet" type="text/css" />
    <link href="/Content/jquery-ui-1.8.20.custom.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jquery-ui-1.8.20.custom.min.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        function ShowEXWindow() {
            $("body").css({ overflow: "hidden" });    //禁用滚动条
            var wid = document.documentElement.clientWidth || document.body.clientWidth;    //取得整个屏幕宽
            var hei = document.documentElement.clientHeight || document.body.clientHeight;     //取得整个屏幕高
            var h = $(document).height();
            var h1 = $(document).scrollTop();
            var h2 = 0;
            HideScrollbar = false;
            $('#mengban').css({ display: 'block', opacity: 0.5, height: h + 'px' }).show(2000);
            $('.EXWindow').css("margin-top", (h2 + h1) + 'px');
            $('.EXWindow').fadeIn(1000);
        }
        function HideEXWindow() {
            HideScrollbar = true;
            $("body").css({ overflow: "auto" });
            $('#mengban').hide(0);
            $('.EXWindow').fadeOut(1000);
            return false;
        }
        function BindDatePicker() {
            $(".DateBox").datepicker({ dateFormat: "yy/mm/dd" });
            if ($("#StartTime").length>0) {
                var StartTime = $("#StartTime").val();
                StartTime = StartTime.substring(0, StartTime.lastIndexOf(' '));
                $("#StartTime").val(StartTime);
                var EndTime = $("#EndTime").val();
                EndTime = EndTime.substring(0, EndTime.lastIndexOf(' '));
                $("#EndTime").val(EndTime);
            }
        }
        function change() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "/WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }

        function Check() {
            alert("!!!!!");
            var StartTime = $("#StartTime").val();
            var EndTime = $("#EndTime").val();
            if (!IsDate(StartTime) || !IsDate(EndTime)) {
                return false;
            }
            else {
                if ($("#ShopID").val() == 0) {
                alert("请先选择好您要预订的数量");
                    return false;
                }
                if ($("#Code").val() == "") {
                    alert("验证码不能为空");
                    return false;
                }
                return true;
            }
            return false;
        }
        function IsDate(oTextbox) {
            var regex = new RegExp("^(?:(?:([0-9]{4}(-|\/)(?:(?:0?[1,3-9]|1[0-2])(-|\/)(?:29|30)|((?:0?[13578]|1[02])(-|\/)31)))|([0-9]{4}(-|\/)(?:0?[1-9]|1[0-2])(-|\/)(?:0?[1-9]|1\\d|2[0-8]))|(((?:(\\d\\d(?:0[48]|[2468][048]|[13579][26]))|(?:0[48]00|[2468][048]00|[13579][26]00))(-|\/)0?2(-|\/)29))))$");
            var dateValue = oTextbox;
            if (!regex.test(dateValue)) {
                alert("日期有误！");
                dateValue = "";
                this.focus();
                return false;
            }
            else {
                return true;
            }
        } 
        function SelectRentalCount() {
            var StartTime = $("#StartTime").val();
            var EndTime = $("#EndTime").val();
            var VersionID = $("#VersionID").val();
            var ShopID = $("#ShopID").val();
            //重置窗口位置
            var h = $(document).height();
            var h1 = $(document).scrollTop();
            var h2 = 0;
            $('.EXWindow').css("margin-top", (h2) + 'px');

            if (IsDate(StartTime) && IsDate(EndTime)) {
                $.ajax({
                    type: "Post",
                    url: "/Car/RentalNumberGet/",
                    dataType: "html",
                    contentType: "application/x-www-form-urlencoded; charset=utf-8",
                    data: {
                        ShopID: ShopID,
                        VersionID: VersionID,
                        StartTime: StartTime,
                        EndTime: EndTime
                    },
                    beforeSend: function (XMLHttpRequest) {
                        $("#Number").text("请稍等......查询中.......");

                    },
                    success: function (msg) {
                        $("#Number").html(msg);
                    },
                    complete: function (XMLHttpRequest, textStatus) {
                        //隐藏正在查询图片
                    },
                    error: function (msg) {
                        $("#UserCheck").html("错误");
                        $("#UserCheck").css("color", "red");
                    }
                });
            }
            else {
                return false;
            }

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        车辆详情</h2>
    <div class="CarSelect">
        <div class="CarImageBox">
            <div class="CarImg">
                <%          
                    Session["path1"] = Model.Version_IMG;
                    Session["path2"] = Model.Brand_IMG;
                %>
                <img src="/Pic.ashx?ID=1" width="400px" height="300px" />
            </div>
        </div>
        <div class="SelectBox">
            <div class="CarInfo">
                车辆名称:<%: Model.Version_Name%><br />
                车辆类型:<%: Model.Type_Name%><br />
                品牌系列:<%: Model.Brand_Name%><br />
                乘坐人数:<%: Model.Version_Person%>
            </div>
            <div class="CarPrice">
                <div>
                    <div style="color: #8E8E8E; font-size: 1.4em; line-height: 30px">
                        <img src="/Images/dot09.gif" />
                        市场价:
                        <%: String.Format("{0:F}", Model.Version_Price_Normal_Rental)%><br />
                    </div>
                    <div style="color: red; font-size: 1.4em; line-height: 30px">
                        <img src="/Images/dot10.gif" />
                        会员价:
                        <%: String.Format("{0:F}", Model.Version_Price_Member_Rental) %><br />
                    </div>
                    <div style="color: #1172C4; font-size: 1.4em; line-height: 30px">
                        <img src="/Images/dot11.gif" />
                        联系电话:
                        <%: Model.Shop_Phone %>
                    </div>
                </div>
            </div>
            <div class="CarOrder">
                <div>
                    <img src="/Pic.ashx?ID=2" /><br />
                    <%:Ajax.ActionLink("<img src='/Images/btn03.gif' />", "OrderGet",
                new {CityID=ViewData["CityID"],ShopID=ViewData["ShopID"], VersionID = Model.Version_ID }, new AjaxOptions() {HttpMethod="Post",UpdateTargetId="EXWindow",OnBegin="ShowEXWindow",OnSuccess="BindDatePicker" }).WriteHtml()%>
                </div>
            </div>
        </div>
        <div class="TabelBox">
            <table border="0px" style="border: solid 5px #EEEEEE;">
                <tr align="center">
                    <td class="TabelBoxHiro">
                    </td>
                    <td class="TabelBoxBlue" width="200px" colspan="2">
                        市场价
                    </td>
                    <td class="TabelBoxPink" width="200px" colspan="2">
                        会员价
                    </td>
                    <td class="TabelBoxHiro">
                    </td>
                    <td class="TabelBoxHiro">
                    </td>
                    <td class="TabelBoxHiro">
                    </td>
                    <td class="TabelBoxHiro">
                    </td>
                </tr>
                <tr align="center">
                    <td style="background-color: #EEEEEE;">
                        车型
                    </td>
                    <td style="background-color: #D9ECFF;">
                        接/送机
                    </td>
                    <td style="background-color: #D9ECFF;">
                        日租金
                    </td>
                    <td style="background-color: #FFE8D9;">
                        接/送机
                    </td>
                    <td style="background-color: #FFE8D9;">
                        日租金
                    </td>
                    <td style="background-color: #EEEEEE;">
                        配驾费
                    </td>
                    <td style="background-color: #EEEEEE;">
                        自驾超里程
                    </td>
                    <td style="background-color: #EEEEEE;">
                        配驾超里程
                    </td>
                    <td style="background-color: #EEEEEE;">
                        车辆押金
                    </td>
                </tr>
                <tr align="center">
                    <td>
                        <%:Model.Version_Name %>
                    </td>
                    <td>
                        <%: String.Format("{0:F}",Model.Version_Price_Normal_Catch) %>元/来回
                    </td>
                    <td>
                        <%: String.Format("{0:F}",Model.Version_Price_Normal_Rental) %>元/天
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Member_Catch)%>元/来回
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Member_Rental)%>元/天
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Riding )%>元/天
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Over  )%>元/公里
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Over_Riding)%>元/公里
                    </td>
                    <td>
                        <%: String.Format("{0:F}", Model.Version_Price_Deposit)%>元/辆
                    </td>
                </tr>
            </table>
        </div>
        <div id="mengban">
        </div>
        <div id="EXWindow" class="EXWindow">
        </div>
    </div>
</asp:Content>
