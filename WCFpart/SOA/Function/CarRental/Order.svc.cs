using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日11:06:47
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Order”。
    /// <summary>
    /// 订单服务方法
    /// </summary>
    public class Order : IOrder
    {
        public DB_Helper<Car_Order> DB_Order = new DB_Helper<Car_Order>();
        #region 增
        /// <summary>
        /// 新增订单信息
        /// </summary>
        /// <param name="Order">要增加的订单实体</param>
        /// <returns></returns>
        public bool AddOrder(Car_Order Order)
        {
            return DB_Order.Insert(Order);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除订单信息
        /// </summary>
        /// <param name="Order">要删除的订单实体</param>
        /// <returns></returns>
        public bool DeleteOrder(int OrderID)
        {
            Car_Order Ord = DB_Order.Select(P => P.Order_ID == OrderID).Single();
            return DB_Order.Delete(Ord);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改订单信息
        /// </summary>
        /// <param name="New_Order">新的订单实体</param>
        /// <returns></returns>
        public bool UpdateOrder(Car_Order TempOrder)
        {
            Car_Order OldOrder = DB_Order.Select(P => P.Order_ID == TempOrder.Order_ID).Single();
            Car_Order NewOrder = OldOrder;
            NewOrder.Order_Action = TempOrder.Order_Action;
            NewOrder.Order_Count = TempOrder.Order_Count;
            NewOrder.Order_End_Time = TempOrder.Order_End_Time;
            NewOrder.Order_IsCatch = TempOrder.Order_IsCatch;
            NewOrder.Order_Message = TempOrder.Order_Message;
            NewOrder.Order_RentalType = TempOrder.Order_RentalType;
            NewOrder.Order_Shop = TempOrder.Order_Shop;
            NewOrder.Order_Start_Time = TempOrder.Order_Start_Time;
            NewOrder.Order_User = TempOrder.Order_User;
            NewOrder.Order_Version = TempOrder.Order_Version;
            NewOrder.Order_Time = TempOrder.Order_Time;
            return DB_Order.Update(OldOrder, NewOrder);
        }
        /// <summary>
        /// 支付定金
        /// </summary>
        /// <param name="OrderID">订单编号</param>
        /// <returns></returns>
        public bool PayDeposit(int OrderID)
        {
            Car_Order OldOrder = DB_Order.Select(P => P.Order_ID == OrderID).Single();
            Car_Order NewOrder = OldOrder;
            NewOrder.Order_DepositPay = true;
            return DB_Order.Update(OldOrder, NewOrder);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="OrderID">订单ID</param>
        /// <returns></returns>
        public Car_Order SelectOrder_ID(int OrderID)
        {
            return DB_Order.Select(P => P.Order_ID == OrderID).Single();
        }
        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <returns>返回所有订单</returns>
        public List<Car_Order> SelectAllOrders()
        {
            return DB_Order.Select(P => P.Order_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询订单信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Order> SelectOrderDIY_Func(Func<Car_Order, bool> where)
        {
            return DB_Order.Select(where).ToList();
        }
        /// <summary>
        /// 查询订单信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Order> SelectOrderDIY_Field(Func<Car_Order, bool> where, Func<Car_Order, Car_Order> select)
        {
            return DB_Order.Select<Car_Order>(where, select).ToList();
        }
        #endregion
    }
}
