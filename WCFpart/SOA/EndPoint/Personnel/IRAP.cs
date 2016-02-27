using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日11:06:47
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IRAP”。
    /// <summary>
    /// 员工奖惩方案服务终结点
    /// </summary>
    [ServiceContract]
    public interface IRAP
    {
        #region 增
        [OperationContract]
        bool AddRAP(User_RAP RAP);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteRAP(int RAPID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateRAP(User_RAP TempRAP);
        #endregion
        #region 查
        [OperationContract]
        User_RAP SelectRAP_ID(int RAPID);
        [OperationContract]
        List<User_RAP> SelectAllRAPs();
        [OperationContract]
        List<User_RAP> SelectRAPDIY_Func(Func<User_RAP, bool> where);
        [OperationContract]
        List<User_RAP> SelectRAPDIY_Field(Func<User_RAP, bool> where, Func<User_RAP, User_RAP> select);
        #endregion
    }
}
