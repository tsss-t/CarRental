using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
using System.Web.Security;
using System.Transactions;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月15日16:19:54
 * 版本：v0.5
 * */

namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserManager”。
    public class UserManager : IUserManager
    {
        DB_Helper<Shop_ViewModel> DB_ShopUser = new DB_Helper<Shop_ViewModel>();
        DB_Helper<UserInShop> DB_UserInShop = new DB_Helper<UserInShop>();
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
            String guid = Guid.NewGuid().ToString();
            User = User ?? new User_ViewModel()
            {
                UserName = guid,
                UserPassword = guid,
                Email = "",
                Answer = "no",
                Question = "no"
            };
            MembershipCreateStatus state = new MembershipCreateStatus();
            MembershipUser Temp_User = Membership.CreateUser(User.UserName, User.UserPassword, User.Email, User.Question, User.Answer, false, out state);

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
        #region 创建角色
        /// <summary>
        /// 建角色
        /// </summary>
        /// <returns></returns>
        public void RoleCreat(String RoleName)
        {
            Roles.CreateRole(RoleName);
        }
        #endregion
        #region 所有角色查询
        /// <summary>
        /// 所有角色查询
        /// </summary>
        /// <returns></returns>
        public List<String> RoleSelectAll()
        {
            return Roles.GetAllRoles().ToList();
        }
        #endregion
        #region 角色分配
        /// <summary>
        /// 用户角色分配
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="RoleName">角色名</param>
        /// <returns></returns>
        public bool UserPutInRole(String UserName, String RoleName)
        {
            try
            {
                Roles.AddUserToRole(UserName, RoleName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region 所有用户查询
        /// <summary>
        /// 所有用户查询
        /// </summary>
        /// <returns></returns>
        public List<string> UserSelectAll()
        {
            List<string> List_UserName = new List<string>();
            MembershipUserCollection collection = Membership.GetAllUsers();
            foreach (MembershipUser us in collection)
            {
                List_UserName.Add(us.UserName);
            }
            return List_UserName;
        }
        #endregion
        #region 用户查询(角色
        /// <summary>
        /// 用户查询(角色
        /// </summary>
        /// <returns></returns>
        public List<String> UserSelect_RoleName(String RoleName)
        {

            return Roles.FindUsersInRole(RoleName, "").ToList();
        }
        #endregion
        #region 角色查询（用户
        /// <summary>
        /// 角色查询（用户
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns></returns>
        public List<String> RoleSelect_UserName(String UserName)
        {
            return Roles.GetRolesForUser(UserName).ToList();
        }
        #endregion
        #region 删除用户的某项角色
        /// <summary>
        /// 删除用户的某项角色
        /// </summary>
        /// <returns></returns>
        public bool RoleUserDelete(String UserName, String RoleName)
        {
            try
            {
                Roles.RemoveUserFromRole(UserName, RoleName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region 查找店铺及其下的所有成员
        /// <summary>
        /// 查找店铺及其下的所有成员
        /// </summary>
        /// <param name="ProvinceID">省份ID</param>
        /// <param name="CityID">城市ID</param>
        /// <param name="ShopID">店铺ID</param>
        /// <returns></returns>
        public List<Shop_ViewModel> GetAllShops(int? ProvinceID, int? CityID, int? ShopID)
        {
            ProvinceID = ProvinceID ?? 0;
            CityID = CityID ?? 0;
            ShopID = ShopID ?? 0;
            List<Shop_ViewModel> List_ShopModel = new List<Shop_ViewModel>();
            //搜索规则由窄到宽
            if (ShopID != 0)
            {
                List_ShopModel = DB_ShopUser.Select(P => P.Shop_ID == ShopID).ToList();
                if (CityID != 0)
                {
                    List_ShopModel = List_ShopModel.Where(P => P.City_ID == CityID).ToList();
                    if (ProvinceID != 0)
                    {
                        List_ShopModel = List_ShopModel.Where(P => P.Province_ID == ProvinceID).ToList();
                    }
                }
            }
            else
            {
                List_ShopModel = DB_ShopUser.getTable().ToList();
            }
            return List_ShopModel;
        }
        #endregion
        #region 添加员工到一个店铺
        /// <summary>
        /// 添加员工到一个店铺
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="ShopID">店铺ID</param>
        /// <returns></returns>
        public bool UserPutInShop(Guid UserID, int ShopID)
        {
            return DB_UserInShop.Insert(new UserInShop() { UserID = UserID, ShopID = ShopID });
        }
        #endregion
        #region 将员工开除出店铺
        /// <summary>
        /// 将员工开除出店铺
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        public bool UserDropShop_UserID(Guid UserID)
        {
            UserInShop new_UIS;
            try
            {
                new_UIS = DB_UserInShop.Select(P => P.UserID == UserID).Single();
            }
            catch (Exception)
            {
                return true;
            }
            return DB_UserInShop.Delete(new_UIS);
        }
        /// <summary>
        /// 将员工开除出店铺
        /// </summary>
        /// <param name="UserID">店铺ID</param>
        /// <returns></returns>
        public bool UserDropShop_ShopID(int ShopID)
        {
            List<UserInShop> new_UIS;
            try
            {
                new_UIS = DB_UserInShop.Select(P => P.ShopID == ShopID).ToList();
            }
            catch (Exception)
            {
                return true;
            }
            return DB_UserInShop.Delete_ALL(new_UIS);
        }
        #endregion
        #region 将员工改签店铺
        /// <summary>
        /// 将员工改签店铺
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="ShopID">店铺ID</param>
        /// <returns></returns>
        public bool UserChangeShop(Guid UserID, int ShopID)
        {
            using (TransactionScope TS = new TransactionScope())
            {
                try
                {
                    UserInShop new_UIS = new UserInShop();
                    //当有User在数据库中有值的时候才进行删除操作
                    bool Mark = true;
                    try
                    {
                        new_UIS = DB_UserInShop.Select(P => P.UserID == UserID).Single();
                    }
                    catch (Exception)
                    {
                        Mark = false;
                    }
                    if (Mark) { DB_UserInShop.Delete_NoSub(new_UIS); }
                    DB_UserInShop.Insert_NoSub(new UserInShop() { UserID = UserID, ShopID = ShopID });
                }
                catch (Exception)
                {

                }
                TS.Complete();
            }
            return true;
        }
        #endregion
        #region 员工查店铺
        public int SelectShopID_UserID(Guid  UserID)
        {
            if (DB_UserInShop.Select(P => P.UserID == UserID).Count() > 0)
            {
                return DB_UserInShop.Select(P => P.UserID == UserID).Single().ShopID;
            }
            else
            {
                return -1;
            }
        }
        #endregion 
        #region 更改密码（不要旧密码
        /// <summary>
        /// 更改密码（不要旧密码
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="NewPassword">新密码（最小7位</param>
        /// <returns></returns>
        public bool UserUpdate_NoOldPassword(String UserName, String NewPassword)
        {
            MembershipUser Temp_User = Membership.GetUser(UserName);
            String OldPassword = Temp_User.GetPassword();
            return Temp_User.ChangePassword(OldPassword, NewPassword);
        }
        #endregion
        #region 更改密码问题及答案(不要旧密码
        /// <summary>
        /// 更改密码问题及答案
        /// </summary>
        /// <returns></returns>
        public bool UserAQUpdate_NoOldPassword(String UserName, String Question, String Answer)
        {
            String Password = Membership.GetUser(UserName).GetPassword();
            return Membership.GetUser(UserName).ChangePasswordQuestionAndAnswer(Password, Question, Answer);
        }
        #endregion
        #region 查询全体用户基本信息
        /// <summary>
        /// 查询全体用户基本信息
        /// </summary>
        /// <returns></returns>
        public List<User_ViewModel> SelectUserInfo_All()
        {
            MembershipUserCollection List_User = Membership.GetAllUsers();
            List<User_ViewModel> List_UserInfo = new List<User_ViewModel>();
            foreach (MembershipUser user in List_User)
            {
                List_UserInfo.Add(new User_ViewModel()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Question = user.PasswordQuestion,
                    UserID = (Guid)user.ProviderUserKey
                });
            }
            return List_UserInfo;
        }

        #endregion
        #region 查询所有用户详细信息
        /// <summary>
        /// 查询所有用户详细信息
        /// </summary>
        /// <returns></returns>
        public List<aspnet_UsersEX> SelectUserEXInfo_All()
        {
            return DB_UserEX.getTable().ToList();
        }

        #endregion
        #region 删除用户
        public bool DropUser(String UserName)
        {
            aspnet_UsersEX userEX = DB_UserEX.Select(P => P.User_ID == (Guid)Membership.GetUser(UserName).ProviderUserKey).Single();
            if (DB_UserEX.Delete(userEX))
            {
                Membership.DeleteUser(UserName);
                return true;
            }
            else
            {
                DB_UserEX.Insert(userEX);
                return false;
            }
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
