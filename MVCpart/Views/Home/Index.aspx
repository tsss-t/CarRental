<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    主页
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id="Main">
<div class="youhui">
<div class="youhui_Header"><a href="#"><img src="/Images/p08.gif"  /></a>
<ul>
<li><a href="#">成都租车-奔驰威霆800元/天</a></li>
<li><a href="#">成都租车 捷达180元/天</a></li>
<li><a href="#">成都国信租车 奔驰商务 850元/天</a></li>
<li><a href="#">成都国信租车 长安之星 150元/天</a></li>
<li><a href="#">成都租车-奔驰威霆800元/天</a></li>
<li><a href="#">五一节租车享平日租车优惠</a></li>
<li><a href="#">成都租车-奔驰威霆800元/天</a></li>
<li><a href="#">成都租车 捷达180元/天</a></li>
</ul>
</div>
</div>
<div class="ShowImg">
<div class="Img">
<div class="ImgInfo">国信租车开展“四统一”标准培训<ul class="ImgInfo_btn"><li class="li1" id="highLight">1</li><li class="li2" >2</li><li class="li3">3</li><li class="li4">4</li></ul></div>
</div>
<div id="News">
<div id="News_Title">公司新闻<a href="#" class="right"><img src="/Images/more.gif" /></a></div>
<div id="News_Content">
<ul class="News_ul">
<li><a href="#">新车-雪铁龙C5出租</a><span class="right">2012/05/22</span></li>
<li><a href="#">新车-雪铁龙C5出租</a><span class="right">2012/05/22</span></li>
<li><a href="#">新车-雪铁龙C5出租</a><span class="right">2012/05/22</span></li>
<li><a href="#">新车-雪铁龙C5出租</a><span class="right">2012/05/22</span></li>
</ul>
</div>
</div>
</div>
<div id="Phone">
<div id="Phone_Number"><img src="/Images/电话.gif" /></div>
<div id="Record">
<div id="Record_Title">
<span class="Record_Title_Content">预定时间</span><span class="Record_Title_Content">预定车型</span><span class="Record_Title_Content">联系电话</span><span class="Record_Title_Content">联系人</span>
</div>
<div id="Record_Content">
<div class="Record_Content_Style"><span class="Record_Content_Content">05/26</span><span class="Record_Content_Content">宝来</span><span class="Record_Content_Content">1341907****</span><span class="Record_Content_Content">张*</span></div>

<div class="Record_Content_Style"><span class="Record_Content_Content">05/26</span><span class="Record_Content_Content">宝来</span><span class="Record_Content_Content">1341907****</span><span class="Record_Content_Content">张*</span></div>
<div class="Record_Content_Style"><span class="Record_Content_Content">05/26</span><span class="Record_Content_Content">宝来</span><span class="Record_Content_Content">1341907****</span><span class="Record_Content_Content">张*</span></div>

<div class="Record_Content_Style"><span class="Record_Content_Content">05/26</span><span class="Record_Content_Content">宝来</span><span class="Record_Content_Content">1341907****</span><span class="Record_Content_Content">张*</span></div>

<div class="Record_Content_Style"><span class="Record_Content_Content">05/26</span><span class="Record_Content_Content">宝来</span><span class="Record_Content_Content">1341907****</span><span class="Record_Content_Content">张*</span></div>
</div>
</div>
</div>
<%--<div class="HotCar"></div>--%>
 <div class="Help">
 <div class="Help_title"><div class="left">租车指南</div><div  class="Help_more"><a href="#">更多>></a></div></div>
 <div class="Help_content">
 <ul class="News_ul">
<li><a href="#">大家知道“汽车租赁”吗？</a></li>
<li><a href="#">成都节假日租车，需要提前多久预定</a></li>
<li><a href="#">旅游租车：轻松四招让你更省钱</a></li>
<li><a href="#">租赁公司的责任和义务</a></li>
<li><a href="#">会议租车要注意的细节：</a></li>
<li><a href="#">签定租赁合同时，需注意以下几点：</a></li>
<li><a href="#">客户租车流程</a></li>
</ul>
 </div>
 </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="../../Content/Sytles.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(function () {
        function hook() {
            $(".li1").mouseover(function () {


                $(".Img").css("background-image", "url(Images/1.jpg)");
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>国信租车开展“四统一”标准培训<ul class='ImgInfo_btn'><li class='li1' id='hightLight'>1</li><li class='li2' >2</li><li class='li3'>3</li><li class='li4'>4</li></ul></div>");
                hook();
            })
            $(".li2").mouseover(function () {

                $(".Img").css("background-image", "url(Images/2.jpg)");
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>全球租车选国信<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2' id='hightLight'>2</li><li class='li3' >3</li><li class='li4'>4</li></ul></div>");
                hook();
            })
            $(".li3").mouseover(function () {

                $(".Img").css("background-image", "url(Images/3.jpg)");
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>成都国信租车<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2'>2</li><li class='li3' id='hightLight'>3</li><li class='li4'>4</li></ul></div>");
                hook();
            })
            $(".li4").mouseover(function () {

                $(".Img").css("background-image", "url(Images/4.jpg)");
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>国信租车开展“四统一”标准培训<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2'>2</li><li class='li3'>3</li><li class='li4' >4</li></ul></div>");
                hook();
            })
        }
        function Change() {
            var name = $(".Img").css("background-image");
            var i = name.substr(44, 1);
            var j = parseInt(i) + 1;
            if (j == 2) {
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>国信租车开展“四统一”标准培训<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2' id='highLight'>2</li><li class='li3'>3</li><li class='li4' >4</li></ul></div>");
            } else if (j == 3) {
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>全球租车选国信<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2'>2</li><li class='li3'  id='highLight'>3</li><li class='li4'>4</li></ul></div>");
            } else if (j == 4) {
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>成都国信租车<ul class='ImgInfo_btn'><li class='li1' >1</li><li class='li2'>2</li><li class='li3'>3</li><li class='li4' id='highLight'>4</li></ul></div>");
            } else {
                j = 1;
                $(".ImgInfo").replaceWith("<div class='ImgInfo'>国信租车开展“四统一”标准培训<ul class='ImgInfo_btn'><li class='li1' id='highLight'>1</li><li class='li2'>2</li><li class='li3'>3</li><li class='li4' >4</li></ul></div>");
            }
            hook();
            $(".Img").css("background-image", "url(Images/" + j + ".jpg)");
            setTimeout(Change, 3000);
        }
        Change();
        hook();
    })
</script>

</asp:Content>
