using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICity”。
    /// <summary>
    /// 城市服务终结点
    /// </summary>
    [ServiceContract]
    public interface ICity
    {
        #region 增
        [OperationContract]
        bool AddCity(Car_City City);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteCity(int CityID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateCity(Car_City TempCity);
        #endregion
        #region 查
        [OperationContract]
        Car_City SelectCity_ID(int CityID);
        [OperationContract]
        Car_City SelectCity_Name(String CityName,int ProvinceID);
        [OperationContract]
        List<Car_City> SelectCity_ProvinceID(int ProvinceID);
        [OperationContract]
        List<Car_City> SelectAllCitys();

        [OperationContract]
        List<Car_City> SelectCityDIY_Func(Func<Car_City, bool> where);
        [OperationContract]
        List<Car_City> SelectCityDIY_Field(Func<Car_City, bool> where, Func<Car_City, Car_City> select);
        #endregion
    }
}
