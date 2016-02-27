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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IOrder”。
    /// <summary>
    /// 订单服务终结点
    /// </summary>
    [ServiceContract]
    public interface IOrder
    {
        #region 增
        [OperationContract]
        bool AddOrder(Car_Order Order);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteOrder(int OrderID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateOrder(Car_Order TempOrder);
        [OperationContract]
        bool PayDeposit(int OrderID);
        #endregion
        #region 查
        [OperationContract]
        Car_Order SelectOrder_ID(int OrderID);
        [OperationContract]
        List<Car_Order> SelectAllOrders();
        [OperationContract]
        List<Car_Order> SelectOrderDIY_Func(Func<Car_Order, bool> where);
        [OperationContract]
        List<Car_Order> SelectOrderDIY_Field(Func<Car_Order, bool> where, Func<Car_Order, Car_Order> select);
        #endregion
    }
}
