using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
/*
* 作者：杜天行
* 创建时间：2011年10月12日22时51分
* 类说明：DAL层查询处理核心类
*/
namespace WCFpart
{
    public class DB_Helper<T> where T : class
    {
        public CarRentalDBDataContext dt { get; set; }
        public DB_Helper()
        {
            dt = new CarRentalDBDataContext() { };
        }
        #region 不使用事务提交
        #region 从数据库中取出整张T表
        /// <summary>
        /// 从数据库中取出整张T表
        /// </summary>
        /// <returns></returns>
        public Table<T> getTable()
        {
            return dt.GetTable<T>();
        }
        #endregion
        #region 从数据库的T表中查询数据
        /// <summary>
        /// 从数据库的T表中查询全字段的值集合对象实例
        /// </summary>
        /// <param name="selectExpression">查询条件Lambda表达式</param>
        /// <returns></returns>
        public IEnumerable<T> Select(Func<T, bool> whereExpression)
        {
            return dt.GetTable<T>().Where<T>(whereExpression);
        }
        /// <summary>
        /// 从数据库的T表中查询某一个字段(类型为K)的值
        /// </summary>
        /// <param name="whereExpression">查询条件Lambda表达式</param>
        /// <param name="selectExpression">查询字段Lambda表达式</param>
        /// <returns></returns>
        public IEnumerable<K> Select<K>(Func<T, bool> whereExpression,Func<T,K> selectExpression) where K:class
        {
            return dt.GetTable<T>().Where<T>(whereExpression).Select(selectExpression);
        }
        #endregion
        #region 向数据库的T表中插入数据
        /// <summary>
        /// 向数据库的T表中插入一条数据
        /// </summary>
        /// <param name="newEntity">T类实例</param>
        /// <returns></returns>
        public bool Insert(T newEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().InsertOnSubmit(newEntity);
                dt.SubmitChanges();
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        /// <summary>
        ///  向数据库的T表中插入数据集合
        /// </summary>
        /// <param name="L_Entity">List数据集合</param>
        /// <returns></returns>
        public bool Insert(List<T> L_Entity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().InsertAllOnSubmit(L_Entity);
                dt.SubmitChanges();
            }
            catch(Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region 更新数据库
        /// <summary>
        /// 更新数据库
        /// </summary>
        /// <param name="oldentity">更新之前的实例</param>
        /// <param name="update">更新方法（可以传入一个匿名方法）</param>
        /// <returns></returns>
        public bool Update(T oldentity,T newentity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                oldentity = newentity;
                dt.SubmitChanges();
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region  从数据库中删除数据
        /// <summary>
        /// 从数据库中删除数据
        /// </summary>
        /// <param name="deleteEntity">要删除的数据实例</param>
        public bool Delete(T deleteEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().DeleteOnSubmit(deleteEntity);
                dt.SubmitChanges();
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);

            }
            return RS;
        }
        #endregion
        #region  从数据库中删除数据集
        /// <summary>
        /// 从数据库中删除数据集
        /// </summary>
        /// <param name="deleteEntity">要删除的数据实例对象List</param>
        public bool Delete_ALL(List<T> deleteEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                for (int i = 0; i < deleteEntity.Count; i++)
                {
                    dt.GetTable<T>().DeleteOnSubmit(deleteEntity[i]);
                }
                dt.SubmitChanges();
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #endregion
        #region 事务处理方法
        #region 向数据库的T表中插入数据,不提交
        /// <summary>
        /// 向数据库的T表中插入一条数据
        /// </summary>
        /// <param name="newEntity">T类实例</param>
        /// <returns></returns>
        public bool Insert_NoSub(T newEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().InsertOnSubmit(newEntity);
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        /// <summary>
        ///  向数据库的T表中插入数据集合
        /// </summary>
        /// <param name="L_Entity">List数据集合</param>
        /// <returns></returns>
        public bool Insert_NoSub(List<T> L_Entity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().InsertAllOnSubmit(L_Entity);
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region 更新数据库，不提交
        /// <summary>
        /// 更新数据库
        /// </summary>
        /// <param name="oldentity">更新之前的实例</param>
        /// <param name="update">更新方法（可以传入一个匿名方法）</param>
        /// <returns></returns>
        public bool Update_NoSub(T oldentity, T newentity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                oldentity = newentity;
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region  从数据库中删除数据，不提交
        /// <summary>
        /// 从数据库中删除数据
        /// </summary>
        /// <param name="deleteEntity">要删除的数据实例</param>
        public bool Delete_NoSub(T deleteEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                dt.GetTable<T>().DeleteOnSubmit(deleteEntity);
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region  从数据库中删除数据集，不提交
        /// <summary>
        /// 从数据库中删除数据集
        /// </summary>
        /// <param name="deleteEntity">要删除的数据实例对象List</param>
        public bool Delete_ALL_Nosub(List<T> deleteEntity)
        {
            bool RS = true;
            String ErrorMessage = String.Empty;
            try
            {
                    dt.GetTable<T>().DeleteAllOnSubmit(deleteEntity);
            }
            catch (Exception EX)
            {
                RS = false;
                ErrorHS(EX.Message);
            }
            return RS;
        }
        #endregion
        #region 提交修改
        public bool SubmitChanges()
        {
            try
            {
                dt.SubmitChanges();
                return true;
            }
            catch(Exception EX)//提交失败，事务回滚
            {
                ErrorHS(EX.Message);
                return false;
            }
        }
        #endregion
        
        #endregion
        #region 发生错误的解决方法
        private void ErrorHS(String Mess)
        {
            CarRentalDBDataContext DB = new CarRentalDBDataContext();
            Error ER = new Error() { Error_Messege = Mess, Error_Time = DateTime.Now };
            DB.Error.InsertOnSubmit(ER);
            DB.SubmitChanges();
        }
        #endregion
    }
}
