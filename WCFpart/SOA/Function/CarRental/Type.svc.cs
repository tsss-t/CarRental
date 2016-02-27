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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Type”。
    /// <summary>
    /// 车型服务方法
    /// </summary>
    public class Type : IType
    {
        public DB_Helper<Car_Type> DB_Type = new DB_Helper<Car_Type>();
        #region 增
        /// <summary>
        /// 新增车型信息
        /// </summary>
        /// <param name="Type">要增加的车型实体</param>
        /// <returns></returns>
        public bool AddType(Car_Type Type)
        {
            return DB_Type.Insert(Type);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除车型信息
        /// </summary>
        /// <param name="Type">要删除的车型实体</param>
        /// <returns></returns>
        public bool DeleteType(int TypeID)
        {
            Car_Type typ = DB_Type.Select(P => P.Type_ID == TypeID).Single();
            return DB_Type.Delete(typ);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改车型信息
        /// </summary>
        /// <param name="New_Type">新的车型实体</param>
        /// <returns></returns>
        public bool UpdateType(Car_Type TempType)
        {
            Car_Type OldType = DB_Type.Select(P => P.Type_ID == TempType.Type_ID).Single();
            Car_Type NewType = OldType;
            NewType.Type_Info = TempType.Type_Info;
            NewType.Type_Name = TempType.Type_Name;
            return DB_Type.Update(OldType, NewType);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询车型信息
        /// </summary>
        /// <param name="TypeID">车型ID</param>
        /// <returns></returns>
        public Car_Type SelectType_ID(int TypeID)
        {
            return DB_Type.Select(P => P.Type_ID == TypeID).Single();
        }
        /// <summary>
        /// 查询车型信息
        /// </summary>
        /// <param name="TypeName">车型名</param>
        /// <returns></returns>
        public Car_Type SelectType_Name(String TypeName)
        {
            return DB_Type.Select(P => P.Type_Name == TypeName).Single();
        }
        /// <summary>
        /// 查询车型信息
        /// </summary>
        /// <returns>返回所有车型</returns>
        public List<Car_Type> SelectAllTypes()
        {
            return DB_Type.Select(P => P.Type_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询车型信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Type> SelectTypeDIY_Func(Func<Car_Type, bool> where)
        {
            return DB_Type.Select(where).ToList();
        }
        /// <summary>
        /// 查询车型信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Type> SelectTypeDIY_Field(Func<Car_Type, bool> where, Func<Car_Type, Car_Type> select)
        {
            return DB_Type.Select<Car_Type>(where, select).ToList();
        }
        #endregion
    }
}
