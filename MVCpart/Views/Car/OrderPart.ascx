<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MVCpart.Models.OrderViewModel>" %>
<%: Html.ValidationSummary(true)%>
<%
    if (Session["UserName"] == null)
    { %>
<div style="margin: 20px  auto; width: 80%; border: solid 1px #2e2e2e; line-height: 300px;">
    <center>
        您还没有进行登陆!请
        <%:Html.ActionLink("点此","Login","User",null,null) %>
        进行登陆,或者 <a href="#" onclick="HideEXWindow()">点此</a> 返回页面
    </center>
</div>
<%}
    else
    {
              
%>
<fieldset>
    <legend>订单 </legend>
    <% using (Html.BeginForm())
       {%>
    <%:Html.HttpMethodOverride(HttpVerbs.Put) %>
    <%: Html.HiddenFor(model => model.VersionID, new { id = "VersionID" })%>
    <%if (Convert.ToInt32(ViewData["ShopID"].ToString()) != 0)
      { %>
    <%:Html.Hidden("ShopID",ViewData["ShopID"].ToString())%>
    <%} %>
    <div class="OrderLeft">
        <div class="editor-label">
            <%: Html.LabelFor(model => model.RiderType)%>
        </div>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.RiderType, 1, new { @checked = true, @class = "RadioButton" })%>
            <span style="padding-right: 80px">自驾</span>
            <%: Html.RadioButtonFor(model => model.RiderType, 2, new { @class = "RadioButton" })%>代驾
            <%: Html.ValidationMessageFor(model => model.RiderType)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IsCatch)%>
        </div>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.IsCatch, false, new { @checked = true, @class = "RadioButton" })%>
            <span style="padding-right: 80px">自取</span>
            <%: Html.RadioButtonFor(model => model.IsCatch, true, new { @class = "RadioButton" })%>接送
            <%: Html.ValidationMessageFor(model => model.IsCatch)%>
        </div>
        <%if (Convert.ToInt32(ViewData["ShopID"].ToString()) == 0)
          { %>
        <div class="editor-label">
            店铺选择:
        </div>
        <div class="editor-field">
            <%:Html.DropDownList("ShopID", (IEnumerable<SelectListItem>)ViewData["ShopList"], new { id = "ShopID", @class = "TextBox", @style = "height:20px;" })%>
        </div>
        <%} %>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.StartTime)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.StartTime, new {@id="StartTime", @class = "DateBox" })%>
            <%: Html.ValidationMessageFor(model => model.StartTime)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.EndTime)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.EndTime, new { @id="EndTime",@class = "DateBox" })%>
            <%: Html.ValidationMessageFor(model => model.EndTime)%>
        </div>
    </div>
    <div class="OrderRight">
        <div class="editor-label">
            预订数量:
        </div>
        <div id="Number" class="editor-field">
            <%--            <%: Html.DropDownListFor(model => model.RentalNumber, (IEnumerable<SelectListItem>)ViewData["CarCountList"], new { @class = "TextBox", @Stype = "height:20px;" })%>
            <%: Html.ValidationMessageFor(model => model.RentalNumber)%>--%>
            <select class="TextBox" style="height:20px;">
                <option value="0" label="请点击下方按钮查询剩余可预订数量" ></option>
            </select>
        </div>
        <div style="float:right;margin-right:20px;">
            <a href="#" onclick="SelectRentalCount()">点击查询剩余数量</a>
            <%--       <%:Ajax.ActionLink("点击查询剩余数量","RentalNumberGet",new {ShopID=ViewData["ShopID"] ,VersionID=ViewData["VersionID"]},new AjaxOptions(){HttpMethod="Post",UpdateTargetId="Number"} %>--%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.ActionEvent)%>
        </div>
        <div class="editor-field">
            <div style="height: 20px; line-height: 20px;">
                <%: Html.DropDownListFor(model => model.ActionEvent, (IEnumerable<SelectListItem>)ViewData["ActionList"], new { @class = "TextBox", @Style = "height:20px;" })%>
            </div>
            <%: Html.ValidationMessageFor(model => model.ActionEvent)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Info)%>
        </div>
        <div class="editor-field">
            <%: Html.TextAreaFor(model => model.Info, new { @class = "TextArea" })%>
            <%: Html.ValidationMessageFor(model => model.Info)%>
        </div>
        <div class="editor-label">
            验证码:
        </div>
        <div class="editor-field">
            <%:Html.TextBox("Code",null, new { @class = "TextBox" })%>
        </div>
        <br />
    </div>
    <div style="float: right; padding-right: 30px;">
        <img src="/WaterMark.ashx" id="vimg" alt="" onclick="change()" />
        <input type="submit" value="提交" onclick="return Check();" />
        <button onclick="return HideEXWindow();">
            返回</button>
    </div>
</fieldset>
<% } %>
<%} %>
