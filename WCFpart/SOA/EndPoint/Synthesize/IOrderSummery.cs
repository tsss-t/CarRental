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

    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IOrderSummery”。
    /// <summary>
    /// 订单总体情况服务终结点
    /// </summary>
    [ServiceContract]
    public interface IOrderSummery
    {
        [OperationContract]
        Order_ViewModel SelectOrderSummery_OrderID(int OrderID);
        [OperationContract]
        decimal GetPrice_Order(Order_ViewModel Summery);
        [OperationContract]
        decimal GetPrice_OrderID(int OrderID);
        [OperationContract]
        bool Pay_Order(int OrderID);
        [OperationContract]
        bool LastCheakOrder(String StaffName, int OrderID, int KM);
        [OperationContract]
        List<Order_ViewModel> SelectOrderSummery_ClientName(string ClientName);
        [OperationContract]
        List<Order_ViewModel> SelectOrderSummery_StaffName(string StaffName);
        [OperationContract]
        List<Order_ViewModel> SelectOrderSummerys_CarVersion(int VersionID);
        [OperationContract]
        List<Order_ViewModel> SelectOrderSummerys_ShopID(int ShopID, int? year, int? month);
        [OperationContract]
        List<Order_ViewModel> SelectOrderSummerys_Time(int? Year, int? Month, int? Day, bool? Ispay);
        [OperationContract]
        int SelectRentaledCarCount_TimeAndVersion(int ShopID, int VersionID, int? StartYear, int? StartMonth, int? StartDay, int? EndYear, int? EndMonth, int? EndDay);
        [OperationContract]
        bool Order_Cancel(int OrderID, Guid UID);
        [OperationContract]
        List<Order_ViewModel> Select_OverTime(int ShopID);
        [OperationContract]
        int Delete_OverTime(int ShopID);
    }
}
