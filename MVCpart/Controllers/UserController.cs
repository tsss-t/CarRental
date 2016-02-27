using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCpart.Models;

namespace MVCpart.Controllers.Class
{
    public class UserController : Controller
    {
        // GET: /User/
        #region 登陆
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel LoginUserModel,String Code)
        {
            UserSummeryService.UserSummeryClient UserSummery_Client = (UserSummeryService.UserSummeryClient)ClientFactory.GetClient(ClientType.Type.UserSummery);
            if (Code.ToLower() == Session["Code"].ToString().ToLower())
            {
                String UserID=UserSummery_Client.UserLogOn(LoginUserModel.UserName, LoginUserModel.Password);
                if(UserID==null)
                {
                    ModelState.AddModelError("Error","您输入的账号和密码不匹配");
                }
                else{
                    Session["UserID"]=UserID;
                    Session["UserName"]=LoginUserModel.UserName;
                    Session["UserPassword"]=LoginUserModel.Password;
                    return RedirectToAction("Success", new {Massage="登录成功!" });
                }
            }
            else
            {
                ModelState.AddModelError("Code", "您输入的验证码不正确!");
            }

            return View(LoginUserModel);
        }
        public ActionResult LoginSuccess()
        {
            return View();
        }
        #endregion
        #region 注册
        [HttpGet]
        public ActionResult RegUser()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public ActionResult RegUser(MVCpart.Models.UserViewModel UserModel)
        {
            if (ModelState.IsValid)
            {
                UserSummeryService.UserSummeryClient UserSummery_Client = (UserSummeryService.UserSummeryClient)ClientFactory.GetClient(ClientType.Type.UserSummery);
                UserSummeryService.User_ViewModel BaseModel = new UserSummeryService.User_ViewModel()
                {
                    UserName = UserModel.UserName,
                    UserPassword = UserModel.UserPassword,
                    Email = UserModel.Email,
                    Answer = UserModel.Answer,
                    Question = UserModel.Question
                };
                UserSummeryService.aspnet_UsersEX Info = new UserSummeryService.aspnet_UsersEX()
                {
                    User_RealName = UserModel.User_RealName,
                    User_Phone = UserModel.User_Phone,
                    User_Validation = UserModel.User_Validation,
                    User_Adress = UserModel.User_Adress,
                    User_Info = UserModel.User_Info
                };
                if (UserSummery_Client.UserReg(BaseModel, Info))
                {
                    return RedirectToAction("Success", new { Massage = "注册成功!" });
                }
            }

            return View(UserModel);

        }
        public ActionResult Success(String Massage)
        {
            ViewData["Massage"] = Massage;
            return View();
        }
        [HttpPost]
        public String CheckUserName(String UserName)
        {
            UserName = UserName ?? "";
            UserManagerService.UserManagerClient UserManager_Client = (UserManagerService.UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            List<String> List_User = UserManager_Client.UserSelectAll().ToList();

            if (List_User.Where(P => P.Contains(UserName)).Count() != 0)
            {
                return "该用户名已被注册";
            }
            else
            {
                return "OK!";
            }
        }
        #endregion
    }
}
