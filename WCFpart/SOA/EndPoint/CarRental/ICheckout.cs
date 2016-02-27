using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月10日10:01:39
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICheckout”。
    /// <summary>
    /// 收款单服务终结点
    /// </summary>
    [ServiceContract]
    public interface ICheckout
    {
        #region 增
        [OperationContract]
        bool AddCheckout(Car_Checkout Checkout);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteCheckout(int CheckoutID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateCheckout(Car_Checkout TempCheckout);
        #endregion
        #region 查
        [OperationContract]
        Car_Checkout SelectCheckout_ID(int CheckoutID);
        [OperationContract]
        List<Car_Checkout> SelectAllCheckouts();
        [OperationContract]
        List<Car_Checkout> SelectCheckoutDIY_Func(Func<Car_Checkout, bool> where);
        [OperationContract]
        List<Car_Checkout> SelectCheckoutDIY_Field(Func<Car_Checkout, bool> where, Func<Car_Checkout, Car_Checkout> select);
        #endregion
    }
}
