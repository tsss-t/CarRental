<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MVCpart.Models.UserLoginViewModel>" %>
    <script type="text/javascript">
        function change() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "../../WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }   
    </script>
    <% using (Html.BeginForm("Login", "User", FormMethod.Post))
       {%>
    <%: Html.ValidationSummary(true)%>
    <fieldset class="Loginfieldset">
        <legend>
            <h3>
                用户登录</h3>
        </legend>
        <div class="LoginBox">
            <div class="right" style="color: Red;">
                <%:Html.ValidationMessage("Error")%>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(model => model.UserName)%>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.UserName)%><br />
                <div class="right" style="color: Red;">
                    <%: Html.ValidationMessageFor(model => model.UserName)%></div>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Password)%>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.Password)%><br />
                <div class="right" style="color: Red;">
                    <%: Html.ValidationMessageFor(model => model.Password)%>
                </div>
            </div>
            <div>
                <div class="editor-label">
                    验证码:
                </div>
                <div class="editor-field">
                    <%:Html.TextBox("Code")%>
                    <div>
                        <div class="right" style="color: Red;">
                            <%:Html.ValidationMessage("Code")%>
                            <img src="../../WaterMark.ashx" id="vimg" alt="" onclick="change()" />
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <p class="right">
                <input type="submit" value="登录" />
            </p>
        </div>
    </fieldset>
    <% } %>
