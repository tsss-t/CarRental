using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:56:36
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 不需要证书
    /// <summary>
    /// 可租汽车业务服务方法
    /// </summary>
    public class CarSummery : ICarSummery
    {
        DB_Helper<Car_ViewModel> DB_ViewModel = new DB_Helper<Car_ViewModel>();
        public List<Car_ViewModel> SelectAllCar()
        {
            return DB_ViewModel.getTable().ToList();
        }
        #region 查询店内指定车辆在指定时间的存货
        /// <summary>
        /// 查询店内指定车辆在指定时间的存货
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
        public int SelectCarCount_ShopIDAndTime(int ShopID,int VersionID,int? StartYear,int? StartMonth,int? StartDay,int? EndYear,int? EndMonth,int? EndDay)
        {
            OrderSummery OrderSummery_Manager=new OrderSummery();
            int OrderCount = OrderSummery_Manager.SelectRentaledCarCount_TimeAndVersion(ShopID,VersionID, StartYear, StartMonth, StartDay, EndYear, EndMonth, EndDay);
            int TatalCount = DB_ViewModel.Select(P => P.Shop_ID == ShopID && P.Version_ID == VersionID).First().Version_Count;
            return TatalCount-OrderCount;
        }
        #endregion       
        #region 查找一个市内指定时间段里是否还有指定数量的某车型
        /// <summary>
        /// 查找一个市内指定时间段里是否还有指定数量的某车型
        /// </summary>
        /// <param name="CityID">城市ID</param>
        /// <param name="CarCount">所需该车的数量</param>
        /// <param name="VersionID">车的型号</param>
        /// <param name="StartYear">开始的年份(默认当前年份</param>
        /// <param name="StartMonth">开始的月份(默认当前月份</param>
        /// <param name="StartDay">开始的日(默认当前日</param>
        /// <param name="EndYear">结束的年份(默认当前年份</param>
        /// <param name="EndMonth">结束的月份(默认当前月份</param>
        /// <param name="EndDay">结束日(默认当前日</param>
        /// <returns></returns>
        public List<Car_Shop> SelectHasCar_CityIDAndTime(int CityID, int VersionID, int CarCount, int? StartYear, int? StartMonth, int? StartDay, int? EndYear, int? EndMonth, int? EndDay)
        {
            List<Car_Shop> List_Shop = new List<Car_Shop>();
            OrderSummery OrderSummery_Manager = new OrderSummery();
            //遍历在这个城市中每一个有该种类车型的店铺
            foreach (Car_ViewModel CarInfo in DB_ViewModel.Select(P => P.Version_ID == VersionID && P.City_ID == CityID).ToList())
            {
                //取得该店铺中剩余数量，当剩余数量大于所需数量时，返回该店铺
                int LastCount= OrderSummery_Manager.SelectRentaledCarCount_TimeAndVersion(CarInfo.Shop_ID, VersionID, StartYear, StartMonth, StartDay, EndYear, EndMonth, EndDay);
                if (LastCount > CarCount)
                {
                    List_Shop.Add(new Car_Shop() 
                    {Shop_ID=CarInfo.Shop_ID,
                        Shop_Info=CarInfo.Shop_Info ,
                        Shop_Name=CarInfo.Shop_Name,
                        Shop_Phone=CarInfo.Shop_Phone,
                        Shop_City=CarInfo.City_ID
                    });
                }
            }
            return List_Shop;
        }
        #endregion
        #region 根据价格查找车型（车辆参数
        /// <summary>
        /// 根据价格查找车型（车辆参数
        /// </summary>
        /// <param name="ShopID">店铺ID（默认为所有店铺</param>
        /// <param name="StartPrice">起始价格（默认为0</param>
        /// <param name="EndPrice">终止价格（默认无上限</param>
        /// <param name="CarTypeID">车辆种类(默认所有种类</param>
        /// <param name="BrandID">车辆品牌(默认所有品牌</param>
        /// <returns></returns>
        public List<Car_ViewModel> SelectCarInfo_Price(int? ShopID,decimal? StartPrice,decimal? EndPrice,int? CarTypeID,int? BrandID)
        {
            ShopID = ShopID ?? 0;
            StartPrice = StartPrice ?? 0;
            EndPrice = EndPrice ?? 100000;
            CarTypeID = CarTypeID ?? 0;
            BrandID = BrandID ?? 0;
            List<Car_ViewModel> List_CarInfo=new List<Car_ViewModel>();

            List_CarInfo= DB_ViewModel.Select(P => P.Version_Price_Member_Rental >= StartPrice && P.Version_Price_Member_Rental <= EndPrice).ToList();
            if (ShopID!=0)
            {
                List_CarInfo = List_CarInfo.Where(P=>P.Shop_ID==ShopID).ToList();
            }
            if (CarTypeID != 0)
            {
                List_CarInfo = List_CarInfo.Where(P => P.Type_ID == CarTypeID).ToList();
            }
            if (BrandID != 0)
            {
                List_CarInfo = List_CarInfo.Where(P => P.Brand_ID == BrandID).ToList();
            }
            return List_CarInfo;
        }
        #endregion

    }
}
