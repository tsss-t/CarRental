using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:56:36
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IWorkRAP”。
    /// <summary>
    /// 员工制度奖惩服务终结点
    /// </summary>
    [ServiceContract]
    public interface IWorkRAP
    {
        #region 增
        [OperationContract]
        bool AddWorkRAP(User_WorkRAP WorkRAP);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteWorkRAP(int WorkRAPID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateWorkRAP(User_WorkRAP TempWorkRAP);
        #endregion
        #region 查
        [OperationContract]
        User_WorkRAP SelectWorkRAP_ID(int WorkRAPID);
        [OperationContract]
        List<User_WorkRAP> SelectWorkRAP_UID(Guid UID);
        [OperationContract]
        List<User_WorkRAP> SelectAllWorkRAPs();
        [OperationContract]
        List<User_WorkRAP> SelectWorkRAPDIY_Func(Func<User_WorkRAP, bool> where);
        [OperationContract]
        List<User_WorkRAP> SelectWorkRAPDIY_Field(Func<User_WorkRAP, bool> where, Func<User_WorkRAP, User_WorkRAP> select);
        #endregion
    }
}
