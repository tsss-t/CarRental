using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日10:55:21
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SalaryAppendAppend”。
    /// <summary>
    /// 员工额外奖惩情况服务方法
    /// </summary>
    public class SalaryAppend : ISalaryAppend
    {
        public DB_Helper<User_SalaryAppend> DB_SalaryAppend = new DB_Helper<User_SalaryAppend>();
        #region 增
        /// <summary>
        /// 新增员工额外奖惩情况信息
        /// </summary>
        /// <param name="SalaryAppend">要增加的员工额外奖惩情况实体</param>
        /// <returns></returns>
        public bool AddSalaryAppend(User_SalaryAppend SalaryAppend)
        {
            return DB_SalaryAppend.Insert(SalaryAppend);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除员工额外奖惩情况信息
        /// </summary>
        /// <param name="SalaryAppend">要删除的员工额外奖惩情况实体</param>
        /// <returns></returns>
        public bool DeleteSalaryAppend(int SalaryAppendID)
        {
            User_SalaryAppend SA = DB_SalaryAppend.Select(P => P.SalaryAppend_ID == SalaryAppendID).Single();
            return DB_SalaryAppend.Delete(SA);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改员工额外奖惩情况信息
        /// </summary>
        /// <param name="New_SalaryAppend">新的员工额外奖惩情况实体</param>
        /// <returns></returns>
        public bool UpdateSalaryAppend(User_SalaryAppend TempSalaryAppend)
        {
            User_SalaryAppend OldSalaryAppend = DB_SalaryAppend.Select(P => P.SalaryAppend_ID == TempSalaryAppend.SalaryAppend_ID).SingleOrDefault();
            User_SalaryAppend NewSalaryAppend = OldSalaryAppend;
            NewSalaryAppend.SalaryAppend_Info = TempSalaryAppend.SalaryAppend_Info;
            NewSalaryAppend.SalaryAppend_Price = TempSalaryAppend.SalaryAppend_Price;
            NewSalaryAppend.SalaryAppend_Time = TempSalaryAppend.SalaryAppend_Time;
            NewSalaryAppend.SalaryAppend_User = TempSalaryAppend.SalaryAppend_User;
            return DB_SalaryAppend.Update(OldSalaryAppend, NewSalaryAppend);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询员工额外奖惩情况信息
        /// </summary>
        /// <param name="SalaryAppendID">员工额外奖惩情况ID</param>
        /// <returns></returns>
        public User_SalaryAppend SelectSalaryAppend_ID(int SalaryAppendID)
        {
            return DB_SalaryAppend.Select(P => P.SalaryAppend_ID == SalaryAppendID).Single();
        }
        /// <summary>
        /// 查询员工额外奖惩情况信息
        /// </summary>
        /// <returns>返回所有员工额外奖惩情况</returns>
        public List<User_SalaryAppend> SelectAllSalaryAppends()
        {
            return DB_SalaryAppend.Select(P => P.SalaryAppend_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询员工额外奖惩情况信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<User_SalaryAppend> SelectSalaryAppendDIY_Func(Func<User_SalaryAppend, bool> where)
        {
            return DB_SalaryAppend.Select(where).ToList();
        }
        /// <summary>
        /// 查询员工额外奖惩情况信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<User_SalaryAppend> SelectSalaryAppendDIY_Field(Func<User_SalaryAppend, bool> where, Func<User_SalaryAppend, User_SalaryAppend> select)
        {
            return DB_SalaryAppend.Select<User_SalaryAppend>(where, select).ToList();
        }
        #endregion
    }
}
