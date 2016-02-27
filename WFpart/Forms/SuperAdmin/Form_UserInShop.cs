using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月17日13:25:22
 * 编写版本：v0.5
 * */
namespace WFpart
{
    /// <summary>
    /// 店铺、用户管理管理窗体
    /// </summary>
    public partial class Form_UserInShop : Form
    {
        #region 参数预声明
        UserManagerClient UserManager_Clinent;
        List<Shop_ViewModel> List_ShopInfo;
        #endregion
        #region 构造方法
        public Form_UserInShop()
        {
            InitializeComponent();
            UserManager_Clinent = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            List_ShopInfo = UserManager_Clinent.GetAllShops(null, null, null).ToList();
            CB_ProviceBind();
            LB_UserBind();
        }
        #endregion
        #region 辅助方法
        private void LB_UserBind()
        {
            List<String> List_User = new List<string>();
            List_User = UserManager_Clinent.UserSelectAll().ToList();
            LB_User.DataSource = List_User;
        }
        private void CB_ProviceBind()
        {
            List<String> List_Province = new List<string>();
            List_Province.Clear();
            List_Province.Add("<—请选择省份—>");
            foreach (Shop_ViewModel TempView in List_ShopInfo)
            {
                if (List_Province.Where(P => P == TempView.Province_Name).Count() == 0)
                {
                    List_Province.Add(TempView.Province_Name);
                }
            }
            CB_Province.DataSource = List_Province;
        }
        private void CB_CityBind()
        {
            List<String> List_City = new List<string>();
            List<Shop_ViewModel> Temp = List_ShopInfo;
            List_City.Clear();
            List_City.Add("<—请选择城市—>");
            if (CB_Province.SelectedIndex != 0)
            {
                Temp = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString()).ToList();
                foreach (Shop_ViewModel TempView in Temp)
                {
                    if (List_City.Where(P => P == TempView.City_Name).Count() == 0)
                    {
                        List_City.Add(TempView.City_Name);
                    }
                }
            }
            CB_City.DataSource = List_City;

        }
        private void LB_ShopBind()
        {
            List<String> List_Shop = new List<string>();
            List<Shop_ViewModel> Temp = List_ShopInfo;

            if (CB_City.SelectedIndex != 0)
            {
                Temp = Temp.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString()).ToList();
                Temp = Temp.Where(P => P.City_Name == CB_City.SelectedItem.ToString()).ToList();
                foreach (Shop_ViewModel TempView in Temp)
                {
                    if (List_Shop.Where(P => P == TempView.Shop_Name).Count() == 0)
                    {
                        List_Shop.Add(TempView.Shop_Name);
                    }
                }
            }
            LB_Shop.DataSource = List_Shop;
        }
        #endregion
        #region 事件
        
        #region 省份选择框变动事件
        /// <summary>
        /// 省份选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_CityBind();
            LB_ShopBind();
        }
        #endregion
        #region 城市选择框变动事件
        /// <summary>
        /// 城市选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_ShopBind();
        }
        #endregion
        #region 用户选择框变动事件
        /// <summary>
        /// 用户选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_ShopInfo.Where(P => P.UserName == LB_User.SelectedItem.ToString()).Count() != 0)
            {
                TB_UserInShop.Text = List_ShopInfo.Where(P => P.UserName == LB_User.SelectedItem.ToString()).First().Shop_Name ?? "";
            }
            else
            {
                TB_UserInShop.Text = "";
            }
        }
        #endregion 
        #region 搜索用户按钮
        /// <summary>
        /// 搜索用户按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_UserSeach_Click(object sender, EventArgs e)
        {
            List<String> List_User = new List<string>();
            List_User = UserManager_Clinent.UserSelectAll().ToList();
            List_User = List_User.Where(P => P.Contains(TB_User.Text)).ToList();
            LB_User.DataSource = List_User;
        }
        #endregion
        #region 输入框回车事件
        /// <summary>
        /// 输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BT_UserSeach_Click(null, null);
            }
        }
        #endregion
        #region 添加用户到店铺按钮
        /// <summary>
        /// 添加用户到店铺按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_AddShop_Click(object sender, EventArgs e)
        {
            if (LB_Shop.SelectedIndex < 0)
            {
                MessageBox.Show("请指定店铺!");
                return;
            }
            if (TB_UserInShop.Text != "")
            {
                MessageBox.Show("该用户已经属于从业于一个店铺！");
                return;
            }
            else
            {
                Guid UserID = ((UserSummeryService.UserSummeryClient)ClientFactory.GetClient(ClientType.Type.UserSummery)).SelectUserID(LB_User.SelectedItem.ToString());
                int ShopID = List_ShopInfo.Where(P => P.Shop_Name == LB_Shop.SelectedItem.ToString() && P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString()).First().Shop_ID;
                UserManager_Clinent.UserPutInShop(UserID, ShopID);
            }
            List_ShopInfo = UserManager_Clinent.GetAllShops(null, null, null).ToList();
            LB_User_SelectedIndexChanged(null, null);
        }
        #endregion
        #region 删除用户所属店铺按钮
        /// <summary>
        /// 删除用户所属店铺按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_DeleteUserFromShop_Click(object sender, EventArgs e)
        {
            if (TB_UserInShop.Text != "")
            {
                UserManager_Clinent.UserDropShop_UserID((Guid)List_ShopInfo.Where(P => P.UserName == LB_User.SelectedItem.ToString()).Single().UserId);
            }
            else
            {
                MessageBox.Show("该用户不属于任何店铺");
            }
            List_ShopInfo = UserManager_Clinent.GetAllShops(null, null, null).ToList();
            LB_User_SelectedIndexChanged(null, null);
        }
        #endregion
        #endregion


    }
}
