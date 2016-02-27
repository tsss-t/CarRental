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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Brand”。
    /// <summary>
    /// 品牌服务方法
    /// </summary>
    public class Brand : IBrand
    {

        public DB_Helper<Car_Brand> DB_Brand = new DB_Helper<Car_Brand>();
        #region 增
        /// <summary>
        /// 新增品牌信息
        /// </summary>
        /// <param name="Brand">要增加的品牌实体</param>
        /// <returns></returns>
        public bool AddBrand(Car_Brand Brand)
        {
            return DB_Brand.Insert(Brand);
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除品牌信息
        /// </summary>
        /// <param name="Brand">要删除的品牌实体</param>
        /// <returns></returns>
        public bool DeleteBrand(int BrandID)
        {
            Car_Brand Bra = DB_Brand.Select(P => P.Brand_ID == BrandID).Single();
            return DB_Brand.Delete(Bra);
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改品牌信息
        /// </summary>
        /// <param name="New_Brand">新的品牌实体</param>
        /// <returns></returns>
        public bool UpdateBrand(Car_Brand TempBrand)
        {
            Car_Brand OldBrand = DB_Brand.Select(P => P.Brand_ID == TempBrand.Brand_ID).Single();
            Car_Brand NewBrand = OldBrand;
            NewBrand.Brand_IMG = TempBrand.Brand_IMG;
            NewBrand.Brand_Info = TempBrand.Brand_Info;
            NewBrand.Brand_Name = TempBrand.Brand_Name;
            return DB_Brand.Update(OldBrand, NewBrand);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询品牌信息
        /// </summary>
        /// <param name="BrandID">品牌ID</param>
        /// <returns></returns>
        public Car_Brand SelectBrand_ID(int BrandID)
        {
            return DB_Brand.Select(P => P.Brand_ID == BrandID).Single();
        }
        /// <summary>
        /// 查询品牌信息
        /// </summary>
        /// <param name="BrandName">品牌名</param>
        /// <returns></returns>
        public Car_Brand SelectBrand_Name(String BrandName)
        {
            return DB_Brand.Select(P => P.Brand_Name == BrandName).Single();
        }
        /// <summary>
        /// 查询品牌信息
        /// </summary>
        /// <returns>返回所有品牌</returns>
        public List<Car_Brand> SelectAllBrands()
        {
            return DB_Brand.Select(P => P.Brand_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询品牌信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Brand> SelectBrandDIY_Func(Func<Car_Brand, bool> where)
        {
            return DB_Brand.Select(where).ToList();
        }
        /// <summary>
        /// 查询品牌信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Brand> SelectBrandDIY_Field(Func<Car_Brand, bool> where, Func<Car_Brand, Car_Brand> select)
        {
            return DB_Brand.Select<Car_Brand>(where, select).ToList();
        }
        #endregion
    }
}
