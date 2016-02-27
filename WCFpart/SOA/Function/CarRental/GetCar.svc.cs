using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;

namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“GetCar”。
    public class GetCar : IGetCar
    {
        public DB_Helper<Car_Get> DB_CarGet = new DB_Helper<Car_Get>();
        #region 终结点实现
        #region 增
        /// <summary>
        /// 新增资金变动信息
        /// </summary>
        /// <param name="CarGet">要增加的资金变动实体</param>
        /// <returns></returns>
        public bool AddCarGet(Car_Get CarGet)
        {
            return DB_CarGet.Insert(CarGet);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除资金变动信息
        /// </summary>
        /// <param name="CarGet">要删除的资金变动实体</param>
        /// <returns></returns>
        public bool DeleteCarGet(int CarGetID)
        {
            Car_Get CarGet = DB_CarGet.Select(P => P.GetCar_ID == CarGetID).Single();
            return DB_CarGet.Delete(CarGet);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改资金变动信息
        /// </summary>
        /// <param name="New_CarGet">新的资金变动实体</param>
        /// <returns></returns>
        public bool UpdateCarGet(Car_Get TempCarGet)
        {
            Car_Get OldCarGet = DB_CarGet.Select(P => P.GetCar_ID == TempCarGet.GetCar_ID).Single();
            Car_Get NewCarGet = OldCarGet;
            NewCarGet.GetCar_CarNumber = TempCarGet.GetCar_CarNumber;
            NewCarGet.GetCar_Order = TempCarGet.GetCar_Order;
            NewCarGet.GetCar_UserValidation = TempCarGet.GetCar_UserValidation;
            return DB_CarGet.Update(OldCarGet, NewCarGet);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询资金变动信息
        /// </summary>
        /// <param name="CarGetID">资金变动ID</param>
        /// <returns></returns>
        public Car_Get SelectCarGet_ID(int CarGetID)
        {
            return DB_CarGet.Select(P => P.GetCar_ID == CarGetID).Single();
        }
        /// <summary>
        /// 查询资金变动信息
        /// </summary>
        /// <returns>返回所有资金变动</returns>
        public List<Car_Get> SelectAllCarGets()
        {
            return DB_CarGet.Select(P => P.GetCar_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询资金变动信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Get> SelectCarGetDIY_Func(Func<Car_Get, bool> where)
        {
            return DB_CarGet.Select(where).ToList();
        }
        /// <summary>
        /// 查询资金变动信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Get> SelectCarGetDIY_Field(Func<Car_Get, bool> where, Func<Car_Get, Car_Get> select)
        {
            return DB_CarGet.Select<Car_Get>(where, select).ToList();
        }
        #endregion
        #endregion
        #region 事务辅助方法
        /// <summary>
        /// 新增资金变动信息
        /// </summary>
        /// <param name="CarGet">要增加的资金变动实体</param>
        /// <returns></returns>
        public bool AddCarGet_Trans(Car_Get CarGet)
        {
            return DB_CarGet.Insert_NoSub(CarGet);
        }
        #endregion
    }
}
