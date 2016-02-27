using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Permissions;
using WCFpart.SOA.EndPoint;

namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“WCFtest”。
    public class WCFtest : IWCFtest
    {
        //[PrincipalPermission(SecurityAction.Demand,Role=
        public DB_Helper<Car_Action> DB_Action = new DB_Helper<Car_Action>();
        #region 增
        /// <summary>
        /// 新增活动信息
        /// </summary>
        /// <param name="Action">要增加的活动实体</param>
        /// <returns></returns>
        public bool AddAction(Car_Action Action)
        {
            DB_Action.Insert(Action);
            return DB_Action.SubmitChanges();
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除活动信息
        /// </summary>
        /// <param name="Action">要删除的活动实体</param>
        /// <returns></returns>
        public bool DeleteAction(Car_Action Action)
        {
            DB_Action.Delete(Action);
            return DB_Action.SubmitChanges();
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改活动信息
        /// </summary>
        /// <param name="New_Action">新的活动实体</param>
        /// <returns></returns>
        public bool UpdateAction(Car_Action NewAction)
        {
            Car_Action OldAction = DB_Action.Select(P => P.Action_ID == NewAction.Action_ID).Single();
            DB_Action.Update(OldAction, NewAction);
            return DB_Action.SubmitChanges();
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询活动信息
        /// </summary>
        /// <param name="ActionID">活动ID</param>
        /// <returns></returns>
        public Car_Action SelectAction_ID(int ActionID)
        {
            return DB_Action.Select(P => P.Action_ID == ActionID).Single();
        }
        /// <summary>
        /// 查询活动信息
        /// </summary>
        /// <param name="ActionName">活动名</param>
        /// <returns></returns>
        public Car_Action SelectAction_Name(String ActionName)
        {
            return DB_Action.Select(P => P.Action_Name == ActionName).Single();
        }
        /// <summary>
        /// 查询活动信息
        /// </summary>
        /// <returns>返回所有活动</returns>
        public List<Car_Action> SelectAllActions()
        {
            return DB_Action.Select(P => P.Action_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询活动信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Action> SelectActionDIY_Func(Func<Car_Action, bool> where)
        {
            return DB_Action.Select(where).ToList();
        }
        /// <summary>
        /// 查询活动信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Action> SelectActionDIY_Field(Func<Car_Action, bool> where, Func<Car_Action, Car_Action> select)
        {
            return DB_Action.Select<Car_Action>(where, select).ToList();
        }
        #endregion
    }
}
