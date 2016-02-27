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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“City”。
    /// <summary>
    /// 城市服务方法
    /// </summary>
    public class City : ICity
    {
        public DB_Helper<Car_City> DB_City = new DB_Helper<Car_City>();
        #region 增
        /// <summary>
        /// 新增城市信息
        /// </summary>
        /// <param name="City">要增加的城市实体</param>
        /// <returns></returns>
        public bool AddCity(Car_City City)
        {
            if (DB_City.Select(P => P.City_Name == City.City_Name && P.City_Province == City.City_Province).Count() == 0)
            {
                return DB_City.Insert(City);
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除城市信息
        /// </summary>
        /// <param name="City">要删除的城市实体</param>
        /// <returns></returns>
        public bool DeleteCity(int CityID)
        {
            Car_City Cit = DB_City.Select(P => P.City_ID == CityID).Single();
            return DB_City.Delete(Cit);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改城市信息
        /// </summary>
        /// <param name="New_City">新的城市实体</param>
        /// <returns></returns>
        public bool UpdateCity(Car_City TempCity)
        {
            Car_City OldCity = DB_City.Select(P => P.City_ID == TempCity.City_ID).Single();
            Car_City NewCity = OldCity;
            NewCity.City_Name = TempCity.City_Name;
            return  DB_City.Update(OldCity, NewCity);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询城市信息
        /// </summary>
        /// <param name="CityID">城市ID</param>
        /// <returns></returns>
        public Car_City SelectCity_ID(int CityID)
        {
            return DB_City.Select(P => P.City_ID == CityID).Single();
        }
        /// <summary>
        /// 查询城市信息
        /// </summary>
        /// <param name="CityName">城市名</param>
        /// <returns></returns>
        public Car_City SelectCity_Name(String CityName,int ProvinceID)
        {
            return DB_City.Select(P => P.City_Name == CityName&&P.City_Province==ProvinceID).Single();
        }
        /// <summary>
        /// 查询城市信息（省份ID
        /// </summary>
        /// <param name="ProvinceID">省份ID</param>
        /// <returns></returns>
        public List<Car_City> SelectCity_ProvinceID(int ProvinceID)
        {
            return DB_City.Select(P => P.City_Province == ProvinceID).ToList();
        }
        /// <summary>
        /// 查询城市信息
        /// </summary>
        /// <returns>返回所有城市</returns>
        public List<Car_City> SelectAllCitys()
        {
            return DB_City.Select(P => P.City_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询城市信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_City> SelectCityDIY_Func(Func<Car_City, bool> where)
        {
            return DB_City.Select(where).ToList();
        }
        /// <summary>
        /// 查询城市信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_City> SelectCityDIY_Field(Func<Car_City, bool> where, Func<Car_City, Car_City> select)
        {
            return DB_City.Select<Car_City>(where, select).ToList();
        }
        #endregion
    }
}
