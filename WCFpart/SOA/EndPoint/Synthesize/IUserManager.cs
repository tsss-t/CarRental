using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月15日16:19:38
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserManager”。
    /// <summary>
    /// 用户,用户权限,用户店铺管理管理
    /// </summary>
    [ServiceContract]
    public interface IUserManager
    {
        [OperationContract]
        bool UserReg(User_ViewModel User, aspnet_UsersEX UserEX);
        [OperationContract]
        void RoleCreat(String RoleName);
        [OperationContract]
        List<String> RoleSelectAll();
        [OperationContract]
        bool UserPutInRole(String UserName, String RoleName);
        [OperationContract]
        List<string> UserSelectAll();
        [OperationContract]
        List<String> UserSelect_RoleName(String RoleName);
        [OperationContract]
        List<String> RoleSelect_UserName(String UserName);
        [OperationContract]
        bool RoleUserDelete(String UserName, String RoleName);
        [OperationContract]
        List<Shop_ViewModel> GetAllShops(int? ProvinceID, int? CityID, int? ShopID);
        [OperationContract]
        bool UserPutInShop(Guid UserID, int ShopID);
        [OperationContract]
        bool UserDropShop_UserID(Guid UserID);
        [OperationContract]
        bool UserDropShop_ShopID(int ShopID);
        [OperationContract]
        bool UserChangeShop(Guid UserID, int ShopID);
        [OperationContract]
        int SelectShopID_UserID(Guid UserID);
        [OperationContract]
        bool UserUpdate_NoOldPassword(String UserName, String NewPassword);
        [OperationContract]
        bool UserAQUpdate_NoOldPassword(String UserName, String Question, String Answer);
        [OperationContract]
        List<aspnet_UsersEX> SelectUserEXInfo_All();
        [OperationContract]
        List<User_ViewModel> SelectUserInfo_All();
        [OperationContract]
        bool DropUser(String UserName);
        [OperationContract]
        bool UserEXUpdate(aspnet_UsersEX TempUserEX);
    }
}
