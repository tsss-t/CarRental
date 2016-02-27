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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Shop”。
    /// <summary>
    /// 店铺服务方法
    /// </summary>
    public class Shop : IShop
    {
        public DB_Helper<Car_Shop> DB_Shop = new DB_Helper<Car_Shop>();
        #region 增
        /// <summary>
        /// 新增店铺信息
        /// </summary>
        /// <param name="Shop">要增加的店铺实体</param>
        /// <returns></returns>
        public bool AddShop(Car_Shop Shop)
        {
            if (DB_Shop.Select(P => P.Shop_Name == Shop.Shop_Name && P.Shop_City == Shop.Shop_City).Count() == 0)
            {
                return DB_Shop.Insert(Shop);
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region 删
        /// <summary>
        /// 删除店铺信息
        /// </summary>
        /// <param name="ShopID">要删除的店铺ID</param>
        /// <returns></returns>
        public bool DeleteShop(int ShopID)
        {
            DB_Shop.Delete(DB_Shop.Select(P => P.Shop_ID == ShopID).Single());
            return DB_Shop.SubmitChanges();
        }
        #endregion
        #region 改
        /// <summary>
        /// 更改店铺信息
        /// </summary>
        /// <param name="New_Shop">新的店铺实体</param>
        /// <returns></returns>
        public bool UpdateShop(Car_Shop TempShop)
        {
            Car_Shop OldShop = DB_Shop.Select(P => P.Shop_ID == TempShop.Shop_ID).Single();
            Car_Shop NewShop=OldShop;
            NewShop.Shop_Name = TempShop.Shop_Name;
            NewShop.Shop_Phone = TempShop.Shop_Phone;
            NewShop.Shop_Info = TempShop.Shop_Info;
            return DB_Shop.Update(OldShop, NewShop);
        }
        #endregion
        #region 查
        /// <summary>
        /// 查询店铺信息
        /// </summary>
        /// <param name="ShopID">店铺ID</param>
        /// <returns></returns>
        public Car_Shop SelectShop_ID(int ShopID)
        {
            return DB_Shop.Select(P => P.Shop_ID == ShopID).Single();
        }
        /// <summary>
        /// 查询店铺信息
        /// </summary>
        /// <param name="ShopName">店铺名</param>
        /// <returns></returns>
        public Car_Shop SelectShop_Name(String ShopName,int CityID)
        {
            return DB_Shop.Select(P => P.Shop_Name == ShopName&&P.Shop_City==CityID).Single();
        }
        /// <summary>
        /// 查询店铺信息
        /// </summary>
        /// <param name="CityID">城市ID</param>
        /// <returns></returns>
        public List<Car_Shop> SelectShop_CityID(int CityID)
        {
            return DB_Shop.Select(P => P.Shop_City == CityID).ToList();
        }
        /// <summary>
        /// 查询店铺信息
        /// </summary>
        /// <returns>返回所有店铺</returns>
        public List<Car_Shop> SelectAllShops()
        {
            return DB_Shop.Select(P => P.Shop_ID >= 0).ToList();
        }
        /// <summary>
        /// 查询店铺信息(根据自己指定的Lambda表达式)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <returns></returns>
        public List<Car_Shop> SelectShopDIY_Func(Func<Car_Shop,bool> where)
        {
            return DB_Shop.Select(where).ToList();
        }
        /// <summary>
        /// 查询店铺信息(根据自己指定的Lambda表达式以及需要的字段)
        /// *重要！：如果不是必要请不要使用该方法
        /// </summary>
        /// <param name="where">查找条件</param>
        /// <param name="select">查找字段</param>
        /// <returns></returns>
        public List<Car_Shop> SelectShopDIY_Field(Func<Car_Shop,bool> where,Func<Car_Shop,Car_Shop> select)
        {
            return DB_Shop.Select<Car_Shop>(where, select).ToList();
        }
        #endregion
    }
}
