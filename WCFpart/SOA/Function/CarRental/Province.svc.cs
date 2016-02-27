using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日11:06:47
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Province”。
    /// <summary>
    /// 省份服务方法
    /// </summary>
    public class Province : IProvince
    {
        public DB_Helper<Car_Province> DB_Province = new DB_Helper<Car_Province>();
        #region 增
        /// <summary>
        /// 新增省份信息
        /// </summary>
        /// <param name="province">要增加的省份实体</param>
        /// <returns></returns>
        public bool AddProvince(Car_Province province)
        {
            return DB_Province.Insert(province);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除省份信息
        /// </summary>
        /// <param name="Province">要删除的省份实体</param>
        /// <returns></returns>
        public bool DeleteProvince(int ProvinceID)
        {
            Car_Province Provin = DB_Province.Select(P => P.Province_ID == ProvinceID).Single();
            return DB_Province.Delete(Provin);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改省份信息
        /// </summary>
        /// <param name="New_Province">新的省份实体</param>
        /// <returns></returns>
        public bool UpdateProvince(Car_Province TempProvince)
        {
            Car_Province OldProvince = DB_Province.Select(P => P.Province_ID == TempProvince.Province_ID).Single();
            Car_Province NewProvince = OldProvince;
            NewProvince.Province_Name = TempProvince.Province_Name;
            return DB_Province.Update(OldProvince, NewProvince);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询省份信息
        /// </summary>
        /// <param name="ProvinceID">省份ID</param>
        /// <returns></returns>
        public Car_Province SelectProvince_ID(int ProvinceID)
        {
            return DB_Province.Select(P => P.Province_ID == ProvinceID).Single();
        }
        /// <summary>
        /// 查询省份信息
        /// </summary>
        /// <param name="ProvinceName">省份名</param>
        /// <returns></returns>
        public Car_Province SelectProvince_Name(String ProvinceName)
        {
            return DB_Province.Select(P => P.Province_Name == ProvinceName).Single();
        }
        /// <summary>
        /// 查询省份信息
        /// </summary>
        /// <returns>返回所有省份</returns>
        public List<Car_Province> SelectAllProvinces()
        {
            return DB_Province.Select(P => P.Province_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询省份信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Province> SelectProvinceDIY_Func(Func<Car_Province, bool> where)
        {
            return DB_Province.Select(where).ToList();
        }
        /// <summary>
        /// 查询省份信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Province> SelectProvinceDIY_Filed(Func<Car_Province, bool> where, Func<Car_Province, Car_Province> select)
        {
            return DB_Province.Select<Car_Province>(where, select).ToList();
        }
        #endregion
    }
}
