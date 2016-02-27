using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日11:06:42
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“RAP”。
    /// <summary>
    /// 员工奖惩方案服务方法
    /// </summary>
    public class RAP : IRAP
    {
        public DB_Helper<User_RAP> DB_RAP = new DB_Helper<User_RAP>();
        #region 增
        /// <summary>
        /// 新增员工奖惩方案信息
        /// </summary>
        /// <param name="RAP">要增加的员工奖惩方案实体</param>
        /// <returns></returns>
        public bool AddRAP(User_RAP RAP)
        {
            return DB_RAP.Insert(RAP);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除员工奖惩方案信息
        /// </summary>
        /// <param name="RAP">要删除的员工奖惩方案实体</param>
        /// <returns></returns>
        public bool DeleteRAP(int  RAPID)
        {
            User_RAP rap = DB_RAP.Select(P => P.RAP_ID == RAPID).Single();
            return DB_RAP.Delete(rap);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改员工奖惩方案信息
        /// </summary>
        /// <param name="New_RAP">新的员工奖惩方案实体</param>
        /// <returns></returns>
        public bool UpdateRAP(User_RAP TempRAP)
        {
            User_RAP OldRAP = DB_RAP.Select(P => P.RAP_ID == TempRAP.RAP_ID).Single();
            User_RAP NewRAP = OldRAP;
            NewRAP.RAP_Name = TempRAP.RAP_Name;
            NewRAP.RAP_Price = TempRAP.RAP_Price;
            return DB_RAP.Update(OldRAP, NewRAP);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询员工奖惩方案信息
        /// </summary>
        /// <param name="RAPID">员工奖惩方案ID</param>
        /// <returns></returns>
        public User_RAP SelectRAP_ID(int RAPID)
        {
            return DB_RAP.Select(P => P.RAP_ID == RAPID).Single();
        }
        /// <summary>
        /// 查询员工奖惩方案信息
        /// </summary>
        /// <returns>返回所有员工奖惩方案</returns>
        public List<User_RAP> SelectAllRAPs()
        {
            return DB_RAP.Select(P => P.RAP_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询员工奖惩方案信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<User_RAP> SelectRAPDIY_Func(Func<User_RAP, bool> where)
        {
            return DB_RAP.Select(where).ToList();
        }
        /// <summary>
        /// 查询员工奖惩方案信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<User_RAP> SelectRAPDIY_Field(Func<User_RAP, bool> where, Func<User_RAP, User_RAP> select)
        {
            return DB_RAP.Select<User_RAP>(where, select).ToList();
        }
        #endregion
    }
}
