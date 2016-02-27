<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCpart.Models.UserViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    RegUser
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContent" runat="server">
    <link href="/Content/UserReg.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#TB_UserName").focusout(JudgeUserName);
        })
        function JudgeUserName() {
            if ($("#TB_UserName").val().length < 7) {
                $("#UserCheck").html("用户名长度不能小于7位!");
                $("#UserCheck").css("color", "red");
                return false;
            }
            $.ajax({
                type: "Post",
                url: "/User/CheckUserName/",
                dataType: "html",
                contentType: "application/x-www-form-urlencoded; charset=utf-8",
                data: { UserName: $("#TB_UserName").val() },
                beforeSend: function (XMLHttpRequest) {
                    $("#UserCheck").text("验证中.......");

                },
                success: function (msg) {
                    $("#UserCheck").html(msg);
                    if (msg.toString() == "OK!") {
                        $("#UserCheck").css("color", "green");
                    }
                    else {
                        $("#UserCheck").css("color", "red");
                    }
                },
                complete: function (XMLHttpRequest, textStatus) {
                    //隐藏正在查询图片
                },
                error: function (msg) {
                    $("#UserCheck").html(msg);
                    $("#UserCheck").css("color", "green");
                }
            });
        }
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% using (Html.BeginForm())
       {
          
    %>

    <%: Html.ValidationSummary(true, "帐户创建不成功。请更正错误并重试。")%>
    <div class="OutBox">
        <div class="RegBox">
            <fieldset>
                <legend>
                    <h2>
                        用户注册</h2>
                </legend>
                <div class="RegTabel">
                    <div class="RegInfo">
                        <fieldset>
                            <legend>
                                <h3>
                                    基本资料</h3>
                            </legend>
                            <div class="RegFrom">
                                <div class="editor-label">
                                    <%:Html.LabelFor( model => model.UserName)%>:<span id="UserCheck"  class="Error">
                                        <%: Html.ValidationMessageFor(model => model.UserName) %></span>
                                </div>
                                <div class="editor-field">

<%--                                <%using(Ajax.BeginForm(,new AjaxOptions() { HttpMethod = "Post", UpdateTargetId = "UserCheck" })) {%>
                                                                     <%} %>--%>
                                    <%: Html.TextBoxFor(model => model.UserName, new { id = "TB_UserName" })%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.UserPassword)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.UserPassword) %>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.PasswordFor(model => model.UserPassword) %>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.UserConfirmPassword)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.UserConfirmPassword)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.PasswordFor(model => model.UserConfirmPassword)%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.Email)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.Email) %>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.Email) %>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.Answer)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.Answer) %>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.Answer) %>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.Question)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.Question) %>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.Question) %>
                                </div>
                            </div>
                        </fieldset>
                    </div>
                    <div class="RegInfo">
                        <fieldset>
                            <legend>
                                <h3>
                                    高级资料</h3>
                            </legend>
                            <div class="RegFrom">
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.User_RealName)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.User_RealName)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.User_RealName)%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.User_Validation)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.User_Validation)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.User_Validation)%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.User_Phone)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.User_Phone)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.User_Phone)%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.User_Adress)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.User_Adress)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.User_Adress)%>
                                </div>
                                <div class="editor-label">
                                    <%:Html.LabelFor(model => model.User_Info)%>: <span class="Error">
                                        <%: Html.ValidationMessageFor(model => model.User_Info)%>
                                    </span>
                                </div>
                                <div class="editor-field">
                                    <%: Html.TextBoxFor(model => model.User_Info)%>
                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>
                <div class="RegList">
                    <fieldset>
                        <legend>
                            <h3>
                                注册条列</h3>
                        </legend>
                        <textarea readonly="True">
                     注册协议
1．特别提示
1.1四通汽车租赁有限公司（以下简称“四通租车”）同意按照本协议的规定及其不时发布的操作规则提供基于互联网的相关服务（以下称“网络服务”），为获得网络服务，服务使用人（以下称“用户”）应当同意本协议的全部条款并按照页面上的提示完成全部的注册程序。用户注册成功即表示用户完全接受本协议项下的全部条款。

1.2用户注册成功后，四通租车将给予每个用户一个用户帐号及相应的密码，该用户帐号和密码由用户自行保管。用户首次租赁车辆用车完毕后，如未产生任何纠纷，四通租车将通过邮递或其他方式向用户寄送会员卡。

1.3为提供更好的服务，四通租车有权使用通过合法途径获得的用户其他身份信息（如身份证照片等）用于为用户提供服务，该信息是依据用户提供的身份信息而合法获取的，且仅限用于为客户提供服务。

2. 服务内容
2.1通过四通租车网站在线预订车辆、查询价格车型信息、对提供的服务发表意见等。（具体查看公司网页http://www.1hai.cn/）

3. 服务变更、中断或终止
3.1鉴于网络服务的特殊性，用户授权四通租车可随时变更、中断或终止部分或全部的网络服务。由于四通租车需要定期或不定期地对提供网络服务的平台（如互联网网站）或相关的设备进行检修或者维护，如因此类情况而造成网络服务在合理时间内的中断，四通租车无需为此承担任何责任。

3.2如发生下列任何一种情形，四通租车有权在通知用户后中断或终止向用户提供本协议项下的网络服务而无需对用户或任何第三方承担任何责任：

3.2.1 用户提供的个人资料不真实；

3.2.2 用户违反本协议中规定的使用规则；

3.3如用户注册的帐号在任何连续180日内未实际使用，则四通租车有权删除该帐号并停止为该用户提供相关的网络服务。

4. 使用规则
4.1用户在申请使用四通租车网络服务时，必须向四通租车提供准确的个人资料，如个人资料有任何变动，必须在三个工作日内更新。

4.2用户需妥善保管其个人账号密码，无论基于何种相关目的，都不允许将帐号、密码转让或出借于他人使用。如用户发现其帐号遭他人非法使用，应当立即通知四通租车。因黑客行为、用户的保管疏忽导致帐号、密码遭他人非法使用或用户将其帐号、密码转让或出借于他人使用而导致任何的客户损失，四通租车不承担任何责任。

4.3 用户注册成功后，视为允许四通租车通过电子邮件或其他方式向用户发送四通租车的优惠服务信息。

4.4用户在使用四通租车网络服务过程中，必须遵循以下原则：

4.4.1 遵守中国有关的法律和法规；

4.4.2 遵守所有与网络服务有关的网络协议、规定和程序；

4.4.3 不得为任何非法目的而使用网络服务系统；

4.4.4 不得利用四通租车网络服务系统进行任何不利于四通租车的行为

5. 知识产权
四通租车提供的服务中包含的任何文本、图片、图形、音频和/或视频资料均受版权、商标和/或其它财产所有权法律的保护，未经相关权利人同意，上述资料均不得在任何媒体直接或间接发布、播放、出于播放或发布目的而改写或再发行，或者被用于其他任何商业目的。所有这些资料或资料的任何部分仅可作为私人和非商业用途而保存在某台计算机内。四通租车为提供服务而使用的任何软件（包括但不限于软件中所含的任何图象、照片、动画、录像、录音、音乐、文字和附加程序、随附的帮助材料）的一切权利均属于该软件的著作权人，未经该软件的著作权人许可，用户不得对该软件进行反向工程（reverse engineer）、反向编译（decompile）或反汇编（disassemble）。

6. 隐私保护
6.1保护用户隐私是四通租车的一项基本政策，四通租车保证不对外公开或向第三方提供单独用户的注册资料及用户在使用网络服务时存储在四通租车的非公开内容，但下列情况除外：

6.1.1 事先获得用户的明确授权；

6.1.2 根据有关的法律法规要求；

6.1.3 按照相关政府主管部门的要求；

6.1.4 为维护社会公众的利益；

6.1.5 为维护四通租车的合法权益

6.2当四通租车与第三方合作向用户提供相关的网络服务，在此情况下，如该第三方允诺严格承担与四通租车同等的保护用户隐私的责任，则视为客户授权四通租车将包含其个人注册资料在内的相关信息仅提供给该等第三方。

7. 免责声明
7.1用户明确同意其使用四通租车网络服务所存在的风险将完全由其自己承担；因其使用四通租车网络服务而产生的一切后果也由其自己承担，四通租车对用户不承担任何责任。

7.2四通租车不保证为向用户提供便利而设置的外部链接的准确性和完整性。同时，对于该等外部链接指向的不由四通租车实际控制的任何网页上的内容，四通租车不承担任何责任。

7.3对于因不可抗力或非因四通租车的原因造成的网络服务中断或其它缺陷，四通租车不承担任何责任。

8. 违约赔偿
8.1如因四通租车违反有关法律、法规或本协议项下的任何条款而给用户造成损失，四通租车同意承担由此造成的损害赔偿责任。

8.2用户同意保障和维护四通租车及其他用户的合法利益，如因用户违反有关法律、法规或本协议项下的任何条款而给四通租车或任何其他第三人造成损失，用户同意承担由此造成的一切损害赔偿责任。

9. 协议修改
9.1四通租车有权随时修改本协议的任何条款，一旦本协议的内容发生变动，四通租车将会在http://www.1hai.cn/网站上公布修改之后的协议内容，该公布行为视为四通租车已经通知用户修改内容。

9.2如果不同意四通租车对本协议相关条款所做的修改，用户有权停止使用网络服务。如果用户继续使用网络服务，则视为用户接受四通租车对本协议相关条款所做的修改

10. 通知送达
10.1本协议项下四通租车对于用户所有的通知均可通过网页公告、电子邮件、手机短信或常规的信件传送等方式进行；四通租车可任意选择其中一种方式通知用户，该通知于发送之日视为已送达用户，用户知悉并接受通知之内容。

10.2 用户如有任何事宜需通知四通租车，应当通过四通租车对外正式公布的通信地址、传真号码、电子邮件地址等联系方式进行联系及送达。

11. 法律管辖
如双方就本协议内容或其执行发生任何争议，双方应友好协商解决；协商不成时，任何一方均可向四通汽车租赁有限公司所在地的人民法院提起诉讼。

                </textarea>
                    </fieldset>
                </div>
            </fieldset>
        </div>
    </div>
    <p>
        <input type="submit" value="注册" />
    </p>
    <% } %>
</asp:Content>
