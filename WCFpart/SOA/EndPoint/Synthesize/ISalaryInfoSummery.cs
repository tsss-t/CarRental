using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月12日9:18:53
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISalaryInfoSummery”。
    /// <summary>
    /// 员工工资详情服务终结点
    /// </summary>
    [ServiceContract]
    public interface ISalaryInfoSummery
    {
        [OperationContract]
        List<SalaryInfo_ViewModel> SelectSalaryInfo(int? ShopID, string UserName, string RealName, string RoleName, int? Year, int? Month);
        [OperationContract]
        List<Salary_ViewModel> SelectAllSalary();
        [OperationContract]
        List<RAP_ViewModel> SelectAllRAP();
        [OperationContract]
        List<RAP_ViewModel> SelectRAP_UID(Guid UID);
        [OperationContract]
        List<SalaryAppend_ViewModel> SelectSalaryAppend();
        [OperationContract]
        List<SalaryAppend_ViewModel> SelectSalaryAppend_UID(Guid UID);
        [OperationContract]
        bool GetSalary(int SalaryLogID, Guid UID, String RealName, decimal Price);
    }
}
