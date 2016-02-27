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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Account”。
    /// <summary>
    /// 资金变动服务方法
    /// </summary>
    public class Account : IAccount
    {
        public DB_Helper<Car_Account> DB_Account = new DB_Helper<Car_Account>();
        #region 终结点实现
        #region 增
        /// <summary>
        /// 新增资金变动信息
        /// </summary>
        /// <param name="Account">要增加的资金变动实体</param>
        /// <returns></returns>
        public bool AddAccount(Car_Account Account)
        {
            return DB_Account.Insert(Account);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除资金变动信息
        /// </summary>
        /// <param name="Account">要删除的资金变动实体</param>
        /// <returns></returns>
        public bool DeleteAccount(int AccountID)
        {
            Car_Account Acc = DB_Account.Select(P => P.Account_ID == AccountID).Single();
            return DB_Account.Delete(Acc);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改资金变动信息
        /// </summary>
        /// <param name="New_Account">新的资金变动实体</param>
        /// <returns></returns>
        public bool UpdateAccount(Car_Account TempAccount)
        {
            Car_Account OldAccount = DB_Account.Select(P => P.Account_ID == TempAccount.Account_ID).Single();
            Car_Account NewAccount = OldAccount;
            NewAccount.Account_Info = TempAccount.Account_Info;
            NewAccount.Account_Price = TempAccount.Account_Price;
            NewAccount.Account_Shop = TempAccount.Account_Shop;
            NewAccount.Account_Time = TempAccount.Account_Time;
            NewAccount.Account_User = TempAccount.Account_User;
            return DB_Account.Update(OldAccount, NewAccount);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询资金变动信息
        /// </summary>
        /// <param name="AccountID">资金变动ID</param>
        /// <returns></returns>
        public Car_Account SelectAccount_ID(int AccountID)
        {
            return DB_Account.Select(P => P.Account_ID == AccountID).Single();
        }
        /// <summary>
        /// 查询资金变动信息
        /// </summary>
        /// <returns>返回所有资金变动</returns>
        public List<Car_Account> SelectAllAccounts()
        {
            return DB_Account.Select(P => P.Account_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询资金变动信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Account> SelectAccountDIY_Func(Func<Car_Account, bool> where)
        {
            return DB_Account.Select(where).ToList();
        }
        /// <summary>
        /// 查询资金变动信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Account> SelectAccountDIY_Field(Func<Car_Account, bool> where, Func<Car_Account, Car_Account> select)
        {
            return DB_Account.Select<Car_Account>(where, select).ToList();
        }
        #endregion
        #endregion
        #region 事务辅助方法
        /// <summary>
        /// 新增资金变动信息
        /// </summary>
        /// <param name="Account">要增加的资金变动实体</param>
        /// <returns></returns>
        public bool AddAccount_Trans(Car_Account Account)
        {
            return DB_Account.Insert_NoSub(Account);
        }
        #endregion
    }
}
