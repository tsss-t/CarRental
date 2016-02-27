using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:54:55
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISalaryAppend”。
    /// <summary>
    /// 员工额外奖惩情况服务终结点
    /// </summary>
[ServiceContract]
    public interface ISalaryAppend
    {
        #region 增
        [OperationContract]
        bool AddSalaryAppend(User_SalaryAppend SalaryAppend);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteSalaryAppend(int SalaryAppendID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateSalaryAppend(User_SalaryAppend TempSalaryAppend);
        #endregion
        #region 查
        [OperationContract]
        User_SalaryAppend SelectSalaryAppend_ID(int SalaryAppendID);
        [OperationContract]
        List<User_SalaryAppend> SelectAllSalaryAppends();
        [OperationContract]
        List<User_SalaryAppend> SelectSalaryAppendDIY_Func(Func<User_SalaryAppend, bool> where);
        [OperationContract]
        List<User_SalaryAppend> SelectSalaryAppendDIY_Field(Func<User_SalaryAppend, bool> where, Func<User_SalaryAppend, User_SalaryAppend> select);
        #endregion
    }
}
