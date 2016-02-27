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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Version”。
    /// <summary>
    /// 车名服务方法
    /// </summary>
    public class Version : IVersion
    {
        public DB_Helper<Car_Version> DB_Version = new DB_Helper<Car_Version>();
        #region 增
        /// <summary>
        /// 新增车名信息
        /// </summary>
        /// <param name="Version">要增加的车名实体</param>
        /// <returns></returns>
        public bool AddVersion(Car_Version Version)
        {
            return DB_Version.Insert(Version);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除车名信息
        /// </summary>
        /// <param name="Version">要删除的车名实体</param>
        /// <returns></returns>
        public bool DeleteVersion(int VersionID)
        {
            Car_Version Ver = DB_Version.Select(P => P.Version_ID == VersionID).Single();
            return DB_Version.Delete(Ver);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改车名信息
        /// </summary>
        /// <param name="New_Version">新的车名实体</param>
        /// <returns></returns>
        public bool UpdateVersion(Car_Version TempVersion)
        {
            Car_Version OldVersion = DB_Version.Select(P => P.Version_ID == TempVersion.Version_ID).Single();
            Car_Version NewVersion = OldVersion;
            NewVersion.Version_BaseKM = TempVersion.Version_BaseKM;
            NewVersion.Version_Brand = TempVersion.Version_Brand;
            NewVersion.Version_Count = TempVersion.Version_Count;
            NewVersion.Version_IMG = TempVersion.Version_IMG;
            NewVersion.Version_Info = TempVersion.Version_Info;
            NewVersion.Version_Name = TempVersion.Version_Name;
            NewVersion.Version_Person = TempVersion.Version_Person;
            NewVersion.Version_Price_Deposit = TempVersion.Version_Price_Deposit;
            NewVersion.Version_Price_Member_Catch = TempVersion.Version_Price_Member_Catch;
            NewVersion.Version_Price_Member_Rental = TempVersion.Version_Price_Member_Rental;
            NewVersion.Version_Price_Normal_Catch = TempVersion.Version_Price_Normal_Catch;
            NewVersion.Version_Price_Normal_Rental = TempVersion.Version_Price_Normal_Rental;
            NewVersion.Version_Price_Over = TempVersion.Version_Price_Over;
            NewVersion.Version_Price_Over_Riding = TempVersion.Version_Price_Over_Riding;
            NewVersion.Version_Price_Riding = TempVersion.Version_Price_Riding;
            NewVersion.Version_Shop = TempVersion.Version_Shop;
            NewVersion.Version_Type = TempVersion.Version_Type;

            return DB_Version.Update(OldVersion, NewVersion);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询车名信息
        /// </summary>
        /// <param name="VersionID">车名ID</param>
        /// <returns></returns>
        public Car_Version SelectVersion_ID(int VersionID)
        {
            return DB_Version.Select(P => P.Version_ID == VersionID).Single();
        }
        /// <summary>
        /// 查询车名信息
        /// </summary>
        /// <param name="VersionName">车名名</param>
        /// <returns></returns>
        public Car_Version SelectVersion_Name(String VersionName)
        {
            return DB_Version.Select(P => P.Version_Name == VersionName).Single();
        }
        /// <summary>
        /// 查询车名信息
        /// </summary>
        /// <returns>返回所有车名</returns>
        public List<Car_Version> SelectAllVersions()
        {
            return DB_Version.Select(P => P.Version_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询车名信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Version> SelectVersionDIY_Func(Func<Car_Version, bool> where)
        {
            return DB_Version.Select(where).ToList();
        }
        /// <summary>
        /// 查询车名信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Version> SelectVersionDIY_Field(Func<Car_Version, bool> where, Func<Car_Version, Car_Version> select)
        {
            return DB_Version.Select<Car_Version>(where, select).ToList();
        }
        #endregion
    }
}
