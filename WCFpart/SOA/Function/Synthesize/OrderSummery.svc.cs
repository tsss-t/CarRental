using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
using System.Web.Security;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:56:36
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“OrderSummery”。
    /// <summary>
    /// 订单总体情况服务终结点
    /// </summary>
    public class OrderSummery : IOrderSummery
    {
        DB_Helper<Order_ViewModel> DB_ViewModel = new DB_Helper<Order_ViewModel>();
        DB_Helper<Car_Order> DB_CarOrder = new DB_Helper<Car_Order>();
        DB_Helper<Car_Checkout> DB_Checkout = new DB_Helper<Car_Checkout>();
        #region 查询用户订车的所有订单（客户用户名
        /// <summary> 
        /// 查询用户订车的所有订单
        /// </summary>
        /// <param name="ClientName">客户用户名</param>
        /// <returns></returns>
        public List<Order_ViewModel> SelectOrderSummery_ClientName(String ClientName)
        {
            return DB_ViewModel.Select(P => P.Client_UserName == ClientName).ToList();
        }
        #endregion
        #region 查询该店员处理过的所有订单（店员用户名
        /// <summary>
        /// 查询该店员处理过的所有订单
        /// </summary>
        /// <param name="StaffName">店员用户名</param>
        /// <returns></returns>
        public List<Order_ViewModel> SelectOrderSummery_StaffName(String StaffName)
        {
            return DB_ViewModel.Select(P => P.Staff_UserName == StaffName).ToList();
        }
        #endregion
        #region 查询单笔账单的总金额（单号
        /// <summary>
        /// 查询单笔账单的总金额（单号
        /// </summary>
        /// <param name="OrderID">订单号</param>
        /// <returns></returns>
        public decimal GetPrice_OrderID(int OrderID)
        {
            Order_ViewModel Summery = DB_ViewModel.Select(P => P.Order_ID == OrderID).Single();
            decimal Total_Money = 0;
            Total_Money = GetPrice_Order(Summery);
            return Total_Money;
        }
        #endregion
        #region 查询单笔账单的总金额（账单实体
        /// <summary>
        /// 查询单笔账单的总金额（账单实体
        /// </summary>
        /// <param name="Summery">定单实体</param>
        /// <returns></returns>
        public decimal GetPrice_Order(Order_ViewModel Summery)
        {
            decimal Total_Money = 0;
            decimal RentalPrice;
            decimal CatchPrice;

            #region 普通会员
            if (Summery.Client_RoleName == "普通会员")
            {
                RentalPrice = Summery.Version_Price_Normal_Rental;
                CatchPrice = Summery.Version_Price_Normal_Catch;
            }
            else
            {
                RentalPrice = Summery.Version_Price_Member_Rental;
                CatchPrice = Summery.Version_Price_Member_Catch;
            }
            //基本租金：每天租费*时间*租借数量
            TimeSpan TS_Start = new TimeSpan(Summery.Order_Start_Time.Ticks);
            TimeSpan TS_End = new TimeSpan(Summery.Checkout_Time.Ticks);
            TimeSpan TS = TS_Start.Subtract(TS_End);
            Total_Money += RentalPrice * TS.Duration().Days * Summery.Order_Count;
            //参加活动：活动优惠*租借数量
            Total_Money += Summery.Action_Price * Summery.Order_Count;
            //是否接送：
            if (Summery.Order_IsCatch == true)
            {
                Total_Money += CatchPrice * Summery.Order_Count;
            }
            //是否代驾：
            if (Summery.RentalType_Name == "代驾")
            {
                Total_Money += Summery.Version_Price_Riding * Summery.Order_Count;
            }
            //超里程：

            if (Summery.RentalType_Name == "代驾")
            {
                Total_Money += Summery.Checkout_KM * Summery.Version_Price_Over_Riding;
            }
            else
            {
                Total_Money += Summery.Checkout_KM * Summery.Version_Price_Over;
            }


            #endregion
            return Total_Money;
        }
        #endregion
        #region 查询所有订单详细情况（时间
        /// <summary>
        /// 查询所有订单详细情况（时间
        /// </summary>
        /// <param name="Month">月份（可空</param>
        /// <param name="Year">年份（可空</param>
        /// <param name="Day">日（可空</param>
        /// <param name="Ispay">是否已经付款(可空，默认已经付款</param>
        /// <returns></returns>
        public List<Order_ViewModel> SelectOrderSummerys_Time(int? Year, int? Month, int? Day, bool? Ispay)
        {
            int Select_Month = Month ?? 0;
            int Select_Year = Year ?? 0;
            int Select_Day = Day ?? 0;
            Ispay = Ispay ?? true;
            List<Order_ViewModel> List_Order_ViewModel = new List<Order_ViewModel>();
            List_Order_ViewModel = DB_ViewModel.Select(P => P.Checkout_Mark == Ispay).ToList();

            if (Select_Day != 0)
            {
                List_Order_ViewModel = DB_ViewModel.Select(P => P.Checkout_Mark == Ispay && P.Checkout_Time.Day == Day).ToList();
            }
            if (Select_Month != 0)
            {
                List_Order_ViewModel = List_Order_ViewModel.Where(P => P.Checkout_Time.Month == Month).ToList();
            }
            if (Select_Year != 0)
            {
                List_Order_ViewModel = List_Order_ViewModel.Where(P => P.Checkout_Time.Year == Year).ToList();
            }
            return List_Order_ViewModel;
        }
        #endregion
        #region 查询某个时间段里面指定车型已被预定的数量(时间，店铺ID，车型
        /// <summary>
        /// 查询某个时间段里面指定车型已被预定的数量
        /// </summary>
        /// <param name="ShopID">店铺ID</param>
        /// <param name="VersionID">车的型号</param>
        /// <param name="StartYear">开始的年份(默认当前年份</param>
        /// <param name="StartMonth">开始的月份(默认当前月份</param>
        /// <param name="StartDay">开始的日(默认当前日</param>
        /// <param name="EndYear">结束的年份(默认当前年份</param>
        /// <param name="EndMonth">结束的月份(默认当前月份</param>
        /// <param name="EndDay">结束日(默认当前日</param>
        /// <returns></returns>
        public int SelectRentaledCarCount_TimeAndVersion(int ShopID, int VersionID, int? StartYear, int? StartMonth, int? StartDay, int? EndYear, int? EndMonth, int? EndDay)
        {
            int OrderCount = 0;
            DateTime Now = DateTime.Now;
            DateTime StartTime = new DateTime(StartYear ?? Now.Year, StartMonth ?? Now.Month, StartDay ?? Now.Day);
            DateTime EndTime = new DateTime(EndYear ?? Now.Year, EndMonth ?? Now.Month, EndDay ?? Now.Day);
            //结束时间在别人的起始时间之前或者起始时间在别人的结束时间后面
            List<Order_ViewModel> List_OrderInTime = DB_ViewModel.Select(
               P => P.Shop_ID == ShopID &&
                   P.Version_ID == VersionID &&
                   (
                    (P.Order_Start_Time <= StartTime && P.Order_End_Time >= StartTime) ||
                    (P.Order_Start_Time <= EndTime && P.Order_End_Time >= EndTime) ||
                    (P.Order_Start_Time >= StartTime && P.Order_End_Time <= EndTime)
                   )
                   ).ToList();
            foreach (Order_ViewModel Order_Temp in List_OrderInTime)
            {
                OrderCount += Order_Temp.Order_Count;
            }
            return OrderCount;
        }
        #endregion
        #region 查询某辆车的订单情况（型号ID
        /// <summary>
        /// 查询某辆车的订单情况
        /// </summary>
        /// <param name="VersionID">车辆型号ID</param>
        /// <returns></returns>
        public List<Order_ViewModel> SelectOrderSummerys_CarVersion(int VersionID)
        {

            return DB_ViewModel.Select(P => P.Version_ID == VersionID).ToList();
        }
        #endregion
        #region 查询某个店铺的订单情况（店铺ID
        /// <summary>
        /// 查询某个店铺的订单情况
        /// <param name="ShopID">店铺ID</param>
        /// <param name="year">年(可空)</param>
        /// <param name="month">月 (可空</param>
        /// </summary>
        /// <returns></returns>
        public List<Order_ViewModel> SelectOrderSummerys_ShopID(int ShopID, int? year, int? month)
        {
            int select_Year = year ?? 0;
            int select_Month = month ?? 0;
            if (select_Year == 0 && select_Month == 0)
            {
                return DB_ViewModel.Select(P => P.Shop_ID == ShopID).ToList();
            }
            else if (select_Year != 0 && select_Month == 0)
            {
                return DB_ViewModel.Select(P => P.Shop_ID == ShopID && P.Checkout_Time.Year == select_Year).ToList();
            }
            else if (select_Year == 0 && select_Month != 0)
            {
                return DB_ViewModel.Select(P => P.Shop_ID == ShopID && P.Checkout_Time.Month == select_Month).ToList();
            }
            else
            {
                return DB_ViewModel.Select(P => P.Shop_ID == ShopID && P.Checkout_Time.Year == select_Year && P.Checkout_Time.Month == select_Month).ToList();
            }
        }
        #endregion
        #region 订单最终确认
        /// <summary>
        /// 订单付款
        /// </summary>
        /// <param name="StaffName">工作人员登陆名</param>
        /// <param name="OrderID">订单ID</param>
        /// <param name="KM">实际行驶里程</param>
        /// <returns></returns>
        public bool LastCheakOrder(String StaffName, int OrderID, int KM)
        {
            Order_ViewModel Summery = DB_ViewModel.Select(P => P.Order_ID == OrderID).Single();
            Summery.Checkout_Time = DateTime.Now;
            Summery.Checkout_KM = KM;

            //管理类声明并共享数据库操作实体
            Checkout Checkout_Manager = new Checkout();



            //实体类声明并获得实体
            Car_Checkout old_checkout = Checkout_Manager.SelectCheckout_ID(Summery.Checkout_ID);
            Car_Checkout new_Checkout = old_checkout;
            new_Checkout.Checkout_KM = KM;
            new_Checkout.Checkout_User = (Guid)Membership.GetUser(StaffName).ProviderUserKey;
            new_Checkout.Checkout_Time = DateTime.Now;

            //将信息保存到数据库以完整信息
            if (!Checkout_Manager.UpdateCheckout(new_Checkout))
            {
                return false;
            }


            return true;
        }
        #endregion
        #region 修改订单状态为已付款并记录资金流向
        public bool Pay_Order(int OrderID)
        {
            Account Account_Manager = new Account();
            Checkout Checkout_Manager = new Checkout();
            Checkout_Manager.DB_Checkout.dt = Account_Manager.DB_Account.dt;



            Order_ViewModel Summery = DB_ViewModel.Select(P => P.Order_ID == OrderID).Single();
            Car_Checkout old_checkout = Checkout_Manager.SelectCheckout_ID(Summery.Checkout_ID);
            Car_Checkout new_Checkout = old_checkout;
            new_Checkout.Checkout_Mark = true;

            //定义付款操作所需要的实体成员
            Car_Account account = new Car_Account()
            {
                Account_Price = GetPrice_OrderID(Summery.Order_ID),
                Account_Shop = Summery.Shop_ID,
                Account_Time = DateTime.Now,
                Account_User = (Guid)new_Checkout.Checkout_User,
                Account_Info = String.Format("第{0}号的订单进行了买单操作!", Summery.Order_ID)
            };
            using (TransactionScope tc = new TransactionScope())
            {
                try
                {
                    Account_Manager.AddAccount_Trans(account);
                    Checkout_Manager.UpdateCheckout_Trans(new_Checkout);
                    Account_Manager.DB_Account.SubmitChanges();
                    tc.Complete();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region 查询订单详情(订单ID
        /// <summary>
        /// 查询订单详情(订单ID
        /// </summary>
        /// <param name="OrderID">订单ID</param>
        /// <returns></returns>
        public Order_ViewModel SelectOrderSummery_OrderID(int OrderID)
        {
            if (DB_ViewModel.Select(P => P.Order_ID == OrderID).Count() > 0)
            {
                return DB_ViewModel.Select(P => P.Order_ID == OrderID).Single();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region 订单取消并支付违约金
        public bool Order_Cancel(int OrderID, Guid UID)
        {
            Checkout Checkout_Manager = new Checkout();
            Account Account_Manager = new Account();
            Account_Manager.DB_Account.dt = Checkout_Manager.DB_Checkout.dt;
            Order_ViewModel CancelOrder = DB_ViewModel.Select(P => P.Order_ID == OrderID).Single();

            int OrderCount = CancelOrder.Order_Count;
            decimal CastPrice = OrderCount * 1000;

            Car_Account acc = new Car_Account()
            {
                Account_Info = String.Format("这笔款项来源自用户:{0},身份证:{1}的取消订单违约金", CancelOrder.Client_RealName, CancelOrder.Client_Validaton),
                Account_Price = CastPrice,
                Account_Shop = CancelOrder.Shop_ID,
                Account_Time = DateTime.Now,
                Account_User = UID
            };
            using (TransactionScope TS = new TransactionScope())
            {
                try
                {
                    Checkout_Manager.DeleteCheckout_Trans(OrderID);
                    Account_Manager.AddAccount_Trans(acc);

                    Checkout_Manager.DB_Checkout.SubmitChanges();
                    TS.Complete();
                }
                catch
                {
                    return false;
                }
                return true;
            }


        }
        #endregion
        #region 过期订单处理
        /// <summary>
        /// 查找所有的过期订单
        /// </summary>
        /// <returns></returns>
        public List<Order_ViewModel> Select_OverTime(int ShopID)
        {

            List<Order_ViewModel> List_Order = new List<Order_ViewModel>();
            TimeSpan TS_Now = new TimeSpan(DateTime.Now.Ticks);
            List_Order = DB_ViewModel.Select(P => new TimeSpan(P.Order_Time.Ticks).Subtract(TS_Now).Duration().Days >= 2 && P.Shop_ID == ShopID).ToList();
            return List_Order;
        }
        /// <summary>
        /// 删除所有的过期订单
        /// </summary>
        /// <returns></returns>
        public int Delete_OverTime(int ShopID)
        {
            TimeSpan TS_Now = new TimeSpan(DateTime.Now.Ticks);

            List<Car_Order> List_CarOrder = DB_CarOrder.Select(P => new TimeSpan(P.Order_Time.Ticks).Subtract(TS_Now).Duration().Days >= 2 && P.Order_Shop == ShopID).ToList();
            List<Car_Checkout> List_Check = new List<Car_Checkout>();
            foreach (Car_Order temp in List_CarOrder)
            {
                List_Check.Add(DB_Checkout.Select(P => P.Checkout_Order == temp.Order_ID).SingleOrDefault());
            }


            if (DB_Checkout.Delete_ALL(List_Check))
            {
                foreach (Car_Order temp in List_CarOrder)
                {
                    DB_CarOrder.Delete(temp);
                }
                return List_Check.Count();
            }
            else
            {
                foreach (Car_Checkout Temp in List_Check)
                {
                    DB_Checkout.Insert(Temp);

                }
                return 0;
            }
        }
        #endregion
    }
}
