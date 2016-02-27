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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IAccount”。
    /// <summary>
    /// 资金变动服务终结点
    /// </summary>
    [ServiceContract]
    public interface IAccount
    {
        #region 增
        [OperationContract]
        bool AddAccount(Car_Account Account);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteAccount(int AccountID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateAccount(Car_Account TempAccount);
        #endregion
        #region 查
        [OperationContract]
        Car_Account SelectAccount_ID(int AccountID);
        [OperationContract]
        List<Car_Account> SelectAllAccounts();
        [OperationContract]
        List<Car_Account> SelectAccountDIY_Func(Func<Car_Account, bool> where);
        [OperationContract]
        List<Car_Account> SelectAccountDIY_Field(Func<Car_Account, bool> where, Func<Car_Account, Car_Account> select);
        #endregion
    }
}
