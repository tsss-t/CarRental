using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:54:06
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SalaryLog”。
    /// <summary>
    /// 员工工资领取服务实现方法
    /// </summary>
    public class SalaryLog : ISalaryLog
    {
        public DB_Helper<User_SalaryLog> DB_SalaryLog = new DB_Helper<User_SalaryLog>();
        #region 增
        /// <summary>
        /// 新增工资领取状况信息
        /// </summary>
        /// <param name="SalaryLog">要增加的工资领取状况实体</param>
        /// <returns></returns>
        public bool AddSalaryLog(User_SalaryLog SalaryLog)
        {
            return DB_SalaryLog.Insert(SalaryLog);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除工资领取状况信息
        /// </summary>
        /// <param name="SalaryLog">要删除的工资领取状况实体</param>
        /// <returns></returns>
        public bool DeleteSalaryLog(int SalaryLogID)
        {
            User_SalaryLog SL = DB_SalaryLog.Select(P => P.SalaryLog_ID == SalaryLogID).Single();
            return DB_SalaryLog.Delete(SL);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改工资领取状况信息
        /// </summary>
        /// <param name="New_SalaryLog">新的工资领取状况实体</param>
        /// <returns></returns>
        public bool UpdateSalaryLog(User_SalaryLog TempSalaryLog)
        {
            User_SalaryLog OldSalaryLog = DB_SalaryLog.Select(P => P.SalaryLog_ID == TempSalaryLog.SalaryLog_ID).Single();
            User_SalaryLog NewSalaryLog = OldSalaryLog;
            NewSalaryLog.SalaryLog_Mark = TempSalaryLog.SalaryLog_Mark;
            NewSalaryLog.SalaryLog_Time = TempSalaryLog.SalaryLog_Time;
            NewSalaryLog.SalaryLog_User = TempSalaryLog.SalaryLog_User;
            return DB_SalaryLog.Update(OldSalaryLog, NewSalaryLog);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询工资领取状况信息
        /// </summary>
        /// <param name="SalaryLogID">工资领取状况ID</param>
        /// <returns></returns>
        public User_SalaryLog SelectSalaryLog_ID(int SalaryLogID)
        {
            return DB_SalaryLog.Select(P => P.SalaryLog_ID == SalaryLogID).Single();
        }
        /// <summary>
        /// 查询工资领取状况信息
        /// </summary>
        /// <returns>返回所有工资领取状况</returns>
        public List<User_SalaryLog> SelectAllSalaryLogs()
        {
            return DB_SalaryLog.Select(P => P.SalaryLog_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询工资领取状况信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<User_SalaryLog> SelectSalaryLogDIY_Func(Func<User_SalaryLog, bool> where)
        {
            return DB_SalaryLog.Select(where).ToList();
        }
        /// <summary>
        /// 查询工资领取状况信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<User_SalaryLog> SelectSalaryLogDIY_Field(Func<User_SalaryLog, bool> where, Func<User_SalaryLog, User_SalaryLog> select)
        {
            return DB_SalaryLog.Select<User_SalaryLog>(where, select).ToList();
        }
        #endregion
    }
}
