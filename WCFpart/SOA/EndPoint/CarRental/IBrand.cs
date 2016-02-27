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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IBrand”。
    /// <summary>
    /// 品牌服务终结点
    /// </summary>
    [ServiceContract]
    public interface IBrand
    {
        #region 增
        [OperationContract]
        bool AddBrand(Car_Brand Brand);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteBrand(int BrandID);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateBrand(Car_Brand TempBrand);
        #endregion
        #region 查
        [OperationContract]
        Car_Brand SelectBrand_ID(int BrandID);
        [OperationContract]
        Car_Brand SelectBrand_Name(String BrandName);
        [OperationContract]
        List<Car_Brand> SelectAllBrands();
        [OperationContract]
        List<Car_Brand> SelectBrandDIY_Func(Func<Car_Brand, bool> where);
        [OperationContract]
        List<Car_Brand> SelectBrandDIY_Field(Func<Car_Brand, bool> where, Func<Car_Brand, Car_Brand> select);
        #endregion
    }
}
