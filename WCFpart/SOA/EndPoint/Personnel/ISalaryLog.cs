using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:54:43
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISalaryLog”。
    /// <summary>
    /// 员工工资领取服务终结点
    /// </summary>
    [ServiceContract]
    public interface ISalaryLog
    {
        #region 增
        [OperationContract]
        bool AddSalaryLog(User_SalaryLog SalaryLog);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteSalaryLog(int SalaryLogID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateSalaryLog(User_SalaryLog TempSalaryLog);
        #endregion
        #region 查
        [OperationContract]
        User_SalaryLog SelectSalaryLog_ID(int SalaryLogID);
        [OperationContract]
        List<User_SalaryLog> SelectAllSalaryLogs();
        [OperationContract]
        List<User_SalaryLog> SelectSalaryLogDIY_Func(Func<User_SalaryLog, bool> where);
        [OperationContract]
        List<User_SalaryLog> SelectSalaryLogDIY_Field(Func<User_SalaryLog, bool> where, Func<User_SalaryLog, User_SalaryLog> select);
        #endregion
    }
}
