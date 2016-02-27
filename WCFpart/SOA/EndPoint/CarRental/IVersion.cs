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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IVersion”。
    /// <summary>
    /// 车名服务终结点
    /// </summary>
    [ServiceContract]
    public interface IVersion
    {
        #region 增
        [OperationContract]
        bool AddVersion(Car_Version Version);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteVersion(int VersionID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateVersion(Car_Version TempVersion);
        #endregion
        #region 查
        [OperationContract]
        Car_Version SelectVersion_ID(int VersionID);
        [OperationContract]
        List<Car_Version> SelectAllVersions();
        [OperationContract]
        List<Car_Version> SelectVersionDIY_Func(Func<Car_Version, bool> where);
        [OperationContract]
        List<Car_Version> SelectVersionDIY_Field(Func<Car_Version, bool> where, Func<Car_Version, Car_Version> select);
        #endregion
    }
}
