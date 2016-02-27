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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IProvince”。
    /// <summary>
    /// 省份服务终结点
    /// </summary>
    [ServiceContract]
    public interface IProvince
    {
        #region 增
        [OperationContract]
        bool AddProvince(Car_Province Province);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteProvince(int ProvinceID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateProvince(Car_Province TempProvince);
        #endregion
        #region 查
        [OperationContract]
        Car_Province SelectProvince_ID(int ProvinceID);
        [OperationContract]
        Car_Province SelectProvince_Name(String ProvinceName);
        [OperationContract]
        List<Car_Province> SelectAllProvinces();
        [OperationContract]
        List<Car_Province> SelectProvinceDIY_Func(Func<Car_Province, bool> where);
        [OperationContract]
        List<Car_Province> SelectProvinceDIY_Filed(Func<Car_Province, bool> where, Func<Car_Province, Car_Province> select);
        #endregion
    }
}
