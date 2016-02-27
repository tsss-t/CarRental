using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
using WCFpart.SOA.EndPoint;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月12日9:18:42
 * 版本：v0.5
 * */
namespace WCFpart.SOA.Function
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SalaryInfoSummery”。
    /// <summary>
    /// 员工工资详情服务方法
    /// </summary>
    public class SalaryInfoSummery : ISalaryInfoSummery
    {
        DB_Helper<SalaryInfo_ViewModel> DB_SalaryInfo = new DB_Helper<SalaryInfo_ViewModel>();
        DB_Helper<Salary_ViewModel> DB_Salary = new DB_Helper<Salary_ViewModel>();
        DB_Helper<RAP_ViewModel> DB_RAP = new DB_Helper<RAP_ViewModel>();
        DB_Helper<SalaryAppend_ViewModel> DB_SalaryAppend = new DB_Helper<SalaryAppend_ViewModel>();
        DB_Helper<User_SalaryLog> DB_SalaryLog = new DB_Helper<User_SalaryLog>();
        DB_Helper<Car_Account> DB_Account = new DB_Helper<Car_Account>();
        DB_Helper<Error> DB_Error = new DB_Helper<Error>();
        #region 查询所有的追加工资项
        /// <summary>
        /// 查询所有的追加工资项
        /// </summary>
        /// <returns></returns>
        public List<SalaryAppend_ViewModel> SelectSalaryAppend()
        {
            return DB_SalaryAppend.getTable().ToList();
        }
        #endregion
        #region 查询追加工资项(员工ID
        /// <summary>
        /// 查询追加工资项(员工ID
        /// </summary>
        /// <param name="UID">员工ID</param>
        /// <returns></returns>
        public List<SalaryAppend_ViewModel> SelectSalaryAppend_UID(Guid UID)
        {
            return DB_SalaryAppend.Select(P => P.SalaryAppend_User==UID).ToList();
        }
        #endregion
        #region 查询所有的基础工资项
        /// <summary>
        /// 查询所有的基础工资项
        /// </summary>
        /// <returns></returns>
        public List<Salary_ViewModel> SelectAllSalary()
        {
            return DB_Salary.getTable().ToList();
        }
        #endregion
        //#region 查询基础工资项(员工ID
        //public Salary_ViewModel SelectSalary_UID(Guid UID)
        //{
        //    UserManager S=new UserManager();
        //    UserSummery D=new UserSummery();
 
        //    return DB_Salary.Select(P=>P.)
        //}
        //#endregion
        #region 查询所有考勤工资
        /// <summary>
        ///  查询所有考勤工资
        /// </summary>
        /// <returns></returns>
        public List<RAP_ViewModel> SelectAllRAP()
        {
            return DB_RAP.getTable().ToList();
        }
        #endregion
        #region 查询考勤工资(员工ID
        public List<RAP_ViewModel> SelectRAP_UID(Guid UID)
        {
            return DB_RAP.Select(P => P.WorkRAP_User == UID).ToList();
        }
        #endregion 
        #region 查询工资总体情况
        /// <summary>
        /// 查询工资总体情况
        /// </summary>
        /// <param name="ShopID">店铺ID（默认所有店铺</param>
        /// <param name="UserName">员工名（默认所有员工</param>
        /// <param name="RoleName">职务名（默认所有职务</param>
        /// <param name="Year">年份（默认所有年份</param>
        /// <param name="Month">月份（默认所有月份</param>
        /// <returns></returns>
        public List<SalaryInfo_ViewModel> SelectSalaryInfo(int? ShopID, string UserName, string RealName, string RoleName, int? Year, int? Month)
        {
            List<SalaryInfo_ViewModel> List_SalaryInfo = new List<SalaryInfo_ViewModel>();
            ShopID = ShopID ?? 0;
            Month = Month ?? 0;

            List_SalaryInfo = DB_SalaryInfo.getTable().ToList();
            //公司店铺量大的时候应该优先执行店铺筛选
            if (ShopID != 0)
            {
                List_SalaryInfo = List_SalaryInfo.Where(P => P.Shop_ID == ShopID).ToList();
            }
            //公司员工多的情况先应优先执行员工筛选
            if (UserName != null)
            {
                List_SalaryInfo = List_SalaryInfo.Where(P => P.UserName == UserName).ToList();
            }
            if (RealName != null)
            {
                List_SalaryInfo = List_SalaryInfo.Where(P => P.User_RealName == RealName).ToList();
            }
            if (RoleName != null)
            {
                List_SalaryInfo = List_SalaryInfo.Where(P => P.RoleName == RoleName).ToList();
            }
            //公司历史悠久，数据量大的时候应该先执行时间筛选
            if (Month != 0)
            {
                Year = Year ?? DateTime.Now.Year;
                List_SalaryInfo = List_SalaryInfo.Where(P => Convert.ToInt32(P.Time.Substring(5)) == Month).ToList();
            }
            else
            {
                Year = Year ?? 0;
            }
            if (Year != 0)
            {
                List_SalaryInfo = List_SalaryInfo.Where(P => Convert.ToInt32(P.Time.Substring(0, 4)) == Year).ToList();
            }
            return List_SalaryInfo;
        }
        #endregion
        #region 领工资
        /// <summary>
        /// 领工资
        /// </summary>
        /// <param name="SalaryLogID">工资单号</param>
        /// <returns></returns>
        public bool GetSalary(int SalaryLogID, Guid UID, String RealName, decimal Price)
        {
            User_SalaryLog OldLog = DB_SalaryLog.Select(P => P.SalaryLog_ID == SalaryLogID).SingleOrDefault();
            User_SalaryLog NewLog = OldLog;
            NewLog.SalaryLog_Mark = true;
            UserManager s = new UserManager();
            int ShopID = s.SelectShopID_UserID(OldLog.SalaryLog_User);
            using (TransactionScope TS = new TransactionScope())
            {
                try
                {
                    DB_Account.dt = DB_SalaryLog.dt;
                    DB_Account.Insert_NoSub(new Car_Account()
                    {
                        Account_Info = String.Format("这笔款项属于工资发放,店铺编号:{0},工资领取人:{1},工资领取时间:{2}", ShopID, RealName, DateTime.Now),
                        Account_Price = Price,
                        Account_Shop = ShopID,
                        Account_Time = DateTime.Now,
                        Account_User = UID
                    });
                    DB_SalaryLog.Update_NoSub(OldLog, NewLog);
                    DB_SalaryLog.dt.SubmitChanges();
                    TS.Complete();
                    return true;
                }
                catch(Exception EX)
                {
                    DB_Error.Insert(new Error() {Error_Messege=EX.Message,Error_Time=DateTime.Now });   
                    return false;
                }
            }
        }
        #endregion

    }
}
