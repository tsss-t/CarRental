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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IType”。
    /// <summary>
    /// 车型服务终结点
    /// </summary>
    [ServiceContract]
    public interface IType
    {
        #region 增
        [OperationContract]
        bool AddType(Car_Type Type);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteType(int TypeID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateType(Car_Type TempType);
        #endregion
        #region 查
        [OperationContract]
        Car_Type SelectType_ID(int TypeID);
        [OperationContract]
        Car_Type SelectType_Name(String TypeName);
        [OperationContract]
        List<Car_Type> SelectAllTypes();
        [OperationContract]
        List<Car_Type> SelectTypeDIY_Func(Func<Car_Type, bool> where);
        [OperationContract]
        List<Car_Type> SelectTypeDIY_Field(Func<Car_Type, bool> where, Func<Car_Type, Car_Type> select);
        #endregion
    }
}
