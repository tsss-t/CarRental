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
    // 不需要证书
    /// <summary>
    /// 可租汽车业务服务终结点
    /// </summary>
    [ServiceContract]
    public interface ICarSummery
    {
        [OperationContract]
        List<Car_ViewModel> SelectAllCar();
        [OperationContract]
        int SelectCarCount_ShopIDAndTime(int ShopID, int VersionID, int? StartYear, int? StartMonth, int? StartDay, int? EndYear, int? EndMonth, int? EndDay);
        [OperationContract]
        List<Car_Shop> SelectHasCar_CityIDAndTime(int CityID, int VersionID, int CarCount, int? StartYear, int? StartMonth, int? StartDay, int? EndYear, int? EndMonth, int? EndDay);
        [OperationContract]
        List<Car_ViewModel> SelectCarInfo_Price(int? ShopID, decimal? StartPrice, decimal? EndPrice, int? CarTypeID, int? BrandID);
    }
}
