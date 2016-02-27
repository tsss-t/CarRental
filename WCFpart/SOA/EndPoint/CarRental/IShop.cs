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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IShop”。
    /// <summary>
    /// 店铺服务终结点
    /// </summary>
    [ServiceContract]
    public interface IShop
    {
        #region 增
        [OperationContract]
        bool AddShop(Car_Shop Shop);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteShop(int ShopID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateShop(Car_Shop TempShop);
        #endregion
        #region 查
        [OperationContract]
        Car_Shop SelectShop_ID(int ShopID);
        [OperationContract]
        Car_Shop SelectShop_Name(String ShopName,int CityID);
        [OperationContract]
        List<Car_Shop> SelectShop_CityID(int CityID);
        [OperationContract]
        List<Car_Shop> SelectAllShops();
        [OperationContract]
        List<Car_Shop> SelectShopDIY_Func(Func<Car_Shop, bool> where);
        [OperationContract]
        List<Car_Shop> SelectShopDIY_Field(Func<Car_Shop, bool> where, Func<Car_Shop, Car_Shop> select);
        #endregion
    }
}
