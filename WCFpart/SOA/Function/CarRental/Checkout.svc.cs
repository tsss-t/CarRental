using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月10日9:59:56
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Checkout”。
    /// <summary>
    /// 收款单服务方法
    /// </summary>
    public class Checkout : ICheckout
    {
        public DB_Helper<Car_Checkout> DB_Checkout = new DB_Helper<Car_Checkout>();
        #region 终结点实现
        #region 增
        /// <summary>
        /// 新增收款单信息
        /// </summary>
        /// <param name="Checkout">要增加的收款单实体</param>
        /// <returns></returns>
        public bool AddCheckout(Car_Checkout Checkout)
        {
            return DB_Checkout.Insert(Checkout);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除收款单信息
        /// </summary>
        /// <param name="Checkout">要删除的收款单实体</param>
        /// <returns></returns>
        public bool DeleteCheckout(int CheckoutID)
        {
            Car_Checkout Che = DB_Checkout.Select(P => P.Checkout_ID == CheckoutID).Single();
            return DB_Checkout.Delete(Che);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改收款单信息
        /// </summary>
        /// <param name="New_Checkout">新的收款单实体</param>
        /// <returns></returns>
        public bool UpdateCheckout(Car_Checkout TempCheckout)
        {
            Car_Checkout OldCheckout = DB_Checkout.Select(P => P.Checkout_ID == TempCheckout.Checkout_ID).Single();
            Car_Checkout NewCheckout = OldCheckout;
            NewCheckout.Checkout_KM = TempCheckout.Checkout_KM;
            NewCheckout.Checkout_Mark = TempCheckout.Checkout_Mark;
            NewCheckout.Checkout_Order = TempCheckout.Checkout_Order;
            NewCheckout.Checkout_Time = TempCheckout.Checkout_Time;
            NewCheckout.Checkout_User = TempCheckout.Checkout_User;
            return DB_Checkout.Update(OldCheckout, NewCheckout);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询收款单信息
        /// </summary>
        /// <param name="CheckoutID">收款单ID</param>
        /// <returns></returns>
        public Car_Checkout SelectCheckout_ID(int CheckoutID)
        {
            return DB_Checkout.Select(P => P.Checkout_ID == CheckoutID).Single();
        }
        /// <summary>
        /// 查询收款单信息
        /// </summary>
        /// <returns>返回所有收款单</returns>
        public List<Car_Checkout> SelectAllCheckouts()
        {
            return DB_Checkout.Select(P => P.Checkout_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询收款单信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Checkout> SelectCheckoutDIY_Func(Func<Car_Checkout, bool> where)
        {
            return DB_Checkout.Select(where).ToList();
        }
        /// <summary>
        /// 查询收款单信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Checkout> SelectCheckoutDIY_Field(Func<Car_Checkout, bool> where, Func<Car_Checkout, Car_Checkout> select)
        {
            return DB_Checkout.Select<Car_Checkout>(where, select).ToList();
        }
        #endregion
        #endregion
        #region 事务辅助方法
        /// <summary>
        /// 更改收款单信息
        /// </summary>
        /// <param name="New_Checkout">新的收款单实体</param>
        /// <returns></returns>
        public bool UpdateCheckout_Trans(Car_Checkout NewCheckout)
        {
            Car_Checkout OldCheckout = DB_Checkout.Select(P => P.Checkout_ID == NewCheckout.Checkout_ID).Single();
            return DB_Checkout.Update_NoSub(OldCheckout, NewCheckout);
        }
        /// <summary>
        /// 删除收款单连带删除订单
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public bool DeleteCheckout_Trans(int OrderID)
        {
            Car_Checkout TempCheckout = DB_Checkout.Select(P => P.Checkout_Order == OrderID).Single();
            return DB_Checkout.Delete_NoSub(TempCheckout);
        }
        #endregion 
    }
}
