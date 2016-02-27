using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Security;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月12日9:18:42
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserSummery”。
    /// <summary>
    /// 用户管理服务方法
    /// </summary>
    public class UserSummery : IUserSummery
    {
        DB_Helper<aspnet_UsersEX> DB_UserEX = new DB_Helper<aspnet_UsersEX>();
        #region 注册用户
        /// <summary>
        /// 注册用户
        /// <param name="User">用户注册资料</param>
        /// <param name="UserEX">用户附加详细资料</param>
        /// </summary>
        /// <returns></returns>
        public bool UserReg(User_ViewModel User, aspnet_UsersEX UserEX)
        {
            //mark为true时表示来自用户注册，为true时表示自动注册
            bool mark = true;
            if (User == null)
            {
                mark = false;
            }
            String guid= Guid.NewGuid().ToString();
            User = User ?? new User_ViewModel()
            {
                UserName =guid,
                UserPassword=guid,
                Email="",
                Answer="no",
                Question="no"
            };
            MembershipCreateStatus state=new MembershipCreateStatus();

                MembershipUser Temp_User = Membership.CreateUser(User.UserName, User.UserPassword, User.Email, User.Question, User.Answer, mark, out state);


            if (state == MembershipCreateStatus.Success)
            {
                UserEX.User_ID = (Guid)Temp_User.ProviderUserKey;
            }
            else
            {
                return false;
            }

            if (!DB_UserEX.Insert(UserEX))
            {
                Membership.DeleteUser(Temp_User.UserName);
            }
            else
            {
                    Roles.AddUserToRole(User.UserName, "普通会员");
            }
            return true;
        }
        #endregion
        #region 用户登录
        /// <summary>
        /// 用户登录
        /// </summary>
        ///  <param name="UserName">用户名</param>
        ///  <param name="Password">密码</param>
        /// <returns>返回用户ID</returns>
        public String UserLogOn(string UserName,string Password)
        {
            if (Membership.ValidateUser(UserName, Password))
            {
                return Membership.GetUser(UserName).ProviderUserKey.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region 获取用户ID
        /// <summary>
        /// 获取用户ID（UserName
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns></returns>
        public Guid SelectUserID(String UserName)
        {
            return (Guid)Membership.GetUser(UserName).ProviderUserKey;
        }
        #endregion
        #region 查询用户基本信息
        /// <summary>
        /// 查询用户基本信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        public User_ViewModel SelectUserInfo(Guid UserID)
        {
            MembershipUser Temp_User= Membership.GetUser(UserID);

            return new User_ViewModel()
            { 
                UserName=Temp_User.UserName,
                Email=Temp_User.Email,
                Question=Temp_User.PasswordQuestion
            };
        }
        #endregion
        #region 查询用户详细信息
        /// <summary>
        /// 查询用户详细信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        public aspnet_UsersEX SelectUserEXInfo(Guid UserID)
        {
            return DB_UserEX.Select(P => P.User_ID == UserID).Single();
        }
        #endregion
        #region 更改密码        
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="OldPassword">旧密码</param>
        /// <param name="NewPassword">新密码（最小7位</param>
        /// <returns></returns>
        public bool UserUpdate(String UserName,String OldPassword,String NewPassword)
        {
            MembershipUser Temp_User= Membership.GetUser(UserName);
            return Temp_User.ChangePassword(OldPassword, NewPassword);
        }
        #endregion
        #region 更改密码问题及答案
        /// <summary>
        /// 更改密码问题及答案
        /// </summary>
        /// <returns></returns>
        public bool UserAQUpdate(Guid UserID,String Password,String Question,String Answer)
        {
            return Membership.GetUser(UserID).ChangePasswordQuestionAndAnswer(Password, Question, Answer);
        }
        #endregion
        #region 更改用户详细信息
        /// <summary>
        /// 更改用户详细信息
        /// </summary>
        /// <param name="UserEX">新的用户详细数据实体</param>
        /// <returns></returns>
        public bool UserEXUpdate(aspnet_UsersEX TempUserEX)
        {
            aspnet_UsersEX old_UserEX = DB_UserEX.Select(P => P.User_ID == TempUserEX.User_ID).Single();
            aspnet_UsersEX UserEX = old_UserEX;
            UserEX.User_Adress = TempUserEX.User_Adress;
            UserEX.User_Info = TempUserEX.User_Info;
            UserEX.User_Phone = TempUserEX.User_Phone;
            UserEX.User_RealName = TempUserEX.User_RealName;
            UserEX.User_Validation = TempUserEX.User_Validation;
            return DB_UserEX.Update(old_UserEX, UserEX);
        }
        #endregion
        
    }
}
