using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:56:36
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“WorkRAP”。
    /// <summary>
    /// 员工制度奖惩服务方法
    /// </summary>
    public class WorkRAP : IWorkRAP
    {
        DB_Helper<User_WorkRAP> DB_WorkRAP = new DB_Helper<User_WorkRAP>();
        #region 增
        /// <summary>
        /// 新增员工制度奖惩情况信息
        /// </summary>
        /// <param name="WorkRAP">要增加的员工制度奖惩情况实体</param>
        /// <returns></returns>
        public bool AddWorkRAP(User_WorkRAP WorkRAP)
        {
            return DB_WorkRAP.Insert(WorkRAP);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除员工制度奖惩情况信息
        /// </summary>
        /// <param name="WorkRAP">要删除的员工制度奖惩情况实体</param>
        /// <returns></returns>
        public bool DeleteWorkRAP(int WorkRAPID)
        {
            User_WorkRAP WRAP = DB_WorkRAP.Select(P => P.WorkRAP_ID == WorkRAPID).Single();
            return DB_WorkRAP.Delete(WRAP);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改员工制度奖惩情况信息
        /// </summary>
        /// <param name="New_WorkRAP">新的员工制度奖惩情况实体</param>
        /// <returns></returns>
        public bool UpdateWorkRAP(User_WorkRAP TempWorkRAP)
        {
            User_WorkRAP OldWorkRAP = DB_WorkRAP.Select(P => P.WorkRAP_ID == TempWorkRAP.WorkRAP_ID).Single();
            User_WorkRAP NewWorkRAP = OldWorkRAP;
            NewWorkRAP.WorkRAP_Time = TempWorkRAP.WorkRAP_Time;
            NewWorkRAP.WorkRAP_Type = TempWorkRAP.WorkRAP_Type;
            NewWorkRAP.WorkRAP_User = TempWorkRAP.WorkRAP_User;
            return DB_WorkRAP.Update(OldWorkRAP, NewWorkRAP);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询员工制度奖惩情况信息
        /// </summary>
        /// <param name="WorkRAPID">员工制度奖惩情况ID</param>
        /// <returns></returns>
        public User_WorkRAP SelectWorkRAP_ID(int WorkRAPID)
        {
            return DB_WorkRAP.Select(P => P.WorkRAP_ID == WorkRAPID).SingleOrDefault();
        }
        /// <summary>
        /// 查询员工制度奖惩情况信息
        /// </summary>
        /// <returns>返回所有员工制度奖惩情况</returns>
        public List<User_WorkRAP> SelectAllWorkRAPs()
        {
            return DB_WorkRAP.Select(P => P.WorkRAP_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询员工制度奖惩情况信息
        /// </summary>
        /// <param name="UID">员工ID</param>
        /// <returns></returns>
        public List<User_WorkRAP> SelectWorkRAP_UID(Guid UID)
        {
            return DB_WorkRAP.Select(P => P.WorkRAP_User == UID).ToList();
        }
        /// <summary>
        /// 查询员工制度奖惩情况信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<User_WorkRAP> SelectWorkRAPDIY_Func(Func<User_WorkRAP, bool> where)
        {
            return DB_WorkRAP.Select(where).ToList();
        }
        /// <summary>
        /// 查询员工制度奖惩情况信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<User_WorkRAP> SelectWorkRAPDIY_Field(Func<User_WorkRAP, bool> where, Func<User_WorkRAP, User_WorkRAP> select)
        {
            return DB_WorkRAP.Select<User_WorkRAP>(where, select).ToList();
        }
        #endregion
    }
}
