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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Salary”。
    /// <summary>
    /// 员工工资服务方法
    /// </summary>
    public class Salary : ISalary
    {
        public DB_Helper<User_Salary> DB_Salary = new DB_Helper<User_Salary>();
        #region 增
        /// <summary>
        /// 新增员工工资情况信息
        /// </summary>
        /// <param name="Salary">要增加的员工工资情况实体</param>
        /// <returns></returns>
        public bool AddSalary(User_Salary Salary)
        {
            return DB_Salary.Insert(Salary);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除员工工资情况信息
        /// </summary>
        /// <param name="Salary">要删除的员工工资情况实体</param>
        /// <returns></returns>
        public bool DeleteSalary(int  SalaryID)
        {
            User_Salary Sala = DB_Salary.Select(P => P.Salary_ID == SalaryID).Single();
           return DB_Salary.Delete(Sala);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改员工工资情况信息
        /// </summary>
        /// <param name="New_Salary">新的员工工资情况实体</param>
        /// <returns></returns>
        public bool UpdateSalary(User_Salary TempSalary)
        {
            User_Salary OldSalary = DB_Salary.Select(P => P.Salary_ID == TempSalary.Salary_ID).Single();
            User_Salary NewSalary = OldSalary;
            NewSalary.Salary_Price = TempSalary.Salary_Price;
            NewSalary.Salary_Role = TempSalary.Salary_Role;
            return DB_Salary.Update(OldSalary, NewSalary);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询员工工资情况信息
        /// </summary>
        /// <param name="SalaryID">员工工资情况ID</param>
        /// <returns></returns>
        public User_Salary SelectSalary_ID(int SalaryID)
        {
            return DB_Salary.Select(P => P.Salary_ID == SalaryID).Single();
        }
        /// <summary>
        /// 查询员工工资情况信息
        /// </summary>
        /// <returns>返回所有员工工资情况</returns>
        public List<User_Salary> SelectAllSalarys()
        {
            return DB_Salary.Select(P => P.Salary_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询员工工资情况信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<User_Salary> SelectSalaryDIY_Func(Func<User_Salary, bool> where)
        {
            return DB_Salary.Select(where).ToList();
        }
        /// <summary>
        /// 查询员工工资情况信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<User_Salary> SelectSalaryDIY_Field(Func<User_Salary, bool> where, Func<User_Salary, User_Salary> select)
        {
            return DB_Salary.Select<User_Salary>(where, select).ToList();
        }
        #endregion
    }
}
