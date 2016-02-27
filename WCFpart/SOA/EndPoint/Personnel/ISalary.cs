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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISalary”。
    /// <summary>
    /// 员工工资服务终结点
    /// </summary>
    [ServiceContract]
    public interface ISalary
    {
        #region 增
        [OperationContract]
        bool AddSalary(User_Salary Salary);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteSalary(int SalaryID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateSalary(User_Salary TempSalary);
        #endregion
        #region 查
        [OperationContract]
        User_Salary SelectSalary_ID(int SalaryID);
        [OperationContract]
        List<User_Salary> SelectAllSalarys();
        [OperationContract]
        List<User_Salary> SelectSalaryDIY_Func(Func<User_Salary, bool> where);
        [OperationContract]
        List<User_Salary> SelectSalaryDIY_Field(Func<User_Salary, bool> where, Func<User_Salary, User_Salary> select);
        #endregion
    }
}
