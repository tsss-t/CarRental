using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IGetCar”。
    [ServiceContract]
    public interface IGetCar
    {
        [OperationContract]
        bool AddCarGet(Car_Get CarGet);
        [OperationContract]
        bool DeleteCarGet(int CarGetID);
        [OperationContract]
        bool UpdateCarGet(Car_Get TempCarGet);
        [OperationContract]
        Car_Get SelectCarGet_ID(int CarGetID);
        [OperationContract]
        List<Car_Get> SelectAllCarGets();
        [OperationContract]
        List<Car_Get> SelectCarGetDIY_Func(Func<Car_Get, bool> where);
        [OperationContract]
        List<Car_Get> SelectCarGetDIY_Field(Func<Car_Get, bool> where, Func<Car_Get, Car_Get> select);
    }
}
