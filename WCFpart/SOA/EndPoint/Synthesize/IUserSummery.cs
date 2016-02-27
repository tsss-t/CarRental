using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月12日9:18:42
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint  
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserSummery”。
    /// <summary>
    /// 用户管理服务终结点
    /// </summary>
    [ServiceContract]
    public interface IUserSummery
    {
        [OperationContract]
        bool UserReg(User_ViewModel User, aspnet_UsersEX UserEX);

        [OperationContract]
        String UserLogOn(string UserName,string Password);

        [OperationContract]
        Guid SelectUserID(String UserName);

        [OperationContract]
        User_ViewModel SelectUserInfo(Guid UserID);

        [OperationContract]
        aspnet_UsersEX SelectUserEXInfo(Guid UserID);

        [OperationContract]
        bool UserUpdate(String UserName, String OldPassword, String NewPassword);

        [OperationContract]
        bool UserAQUpdate(Guid UserID,String Password,String Question,String Answer);

        [OperationContract]
        bool UserEXUpdate(aspnet_UsersEX UserEX);

    }
    [DataContract]
    public class User_ViewModel
    {
        [DataMember]
        public Guid UserID { get; set; }
        [DataMember]
        public String UserName { get; set; }
        [DataMember]
        public String UserPassword { get; set; }
        [DataMember]
        public String Email {get;set; }
        [DataMember]
        public String Answer { get; set; }
        [DataMember]
        public String Question { get; set; }
    }
}
