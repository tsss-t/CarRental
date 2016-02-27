using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using WFpart.ShopService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月18日14:49:01
 * 编写版本：v0.5
 * */
namespace WFpart
{
    public partial class Form_ShopManage : Form
    {
        #region 参数预声明
        UserManagerClient UserManager_Client;
        List<Shop_ViewModel> List_ShopInfo;
        ShopClient Shop_Client;
        #endregion
        #region 构造方法
        public Form_ShopManage()
        {
            InitializeComponent();
            Shop_Client = (ShopClient)ClientFactory.GetClient(ClientType.Type.Shop);
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            List_ShopInfo = UserManager_Client.GetAllShops(null, null, null).ToList();
            CB_ProviceBind();
        }
        #endregion
        #region 辅助方法
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
            }
            foreach (Shop_ViewModel TempView in Temp)
            {
                if (List_City.Where(P => P == TempView.City_Name).Count() == 0)
                {
                    List_City.Add(TempView.City_Name);
                }
            }
            CB_City.DataSource = List_City;

        }
        private void LB_ShopBind()
        {
            List<String> List_Shop = new List<string>();
            List<Shop_ViewModel> Temp = List_ShopInfo;
            if (CB_Province.SelectedIndex == 0 || CB_City.SelectedIndex == 0)
            {
                Temp = null;
            }
            if (CB_City.SelectedIndex != 0)
            {
                Temp = Temp.Where(P => P.City_Name == CB_City.SelectedItem.ToString()&&P.Province_Name==CB_Province.SelectedItem.ToString()).ToList();
            }
            if (Temp != null)
            {
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
        #region 删除店铺按钮事件
        /// <summary>
        /// 删除店铺按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_DeletShop_Click(object sender, EventArgs e)
        {
            if (CB_City.SelectedIndex <= 0)
            {
                MessageBox.Show("为了精确定位到您选择的店铺，请指定好城市名称！");
                return;
            }
            DialogResult result = MessageBox.Show("该操作会删除该店铺以及该店铺下所有的成员关系，您确定要删除吗？", "警告！！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                int CityID = List_ShopInfo.Where(P => P.City_Name == CB_City.SelectedItem.ToString()).First().City_ID;
                UserManager_Client.UserDropShop_ShopID(List_ShopInfo.Where(P => P.Shop_Name == LB_Shop.SelectedItem.ToString()).First().Shop_ID);
                int ShopID = Shop_Client.SelectShop_Name(LB_Shop.SelectedItem.ToString(), CityID).Shop_ID;
                Shop_Client.DeleteShop(ShopID);
                List_ShopInfo = UserManager_Client.GetAllShops(null, null, null).ToList();
                LB_ShopBind();
            }
            else
            {
                return;
            }
        }
        #endregion
        #region 添加店铺按钮事件
        /// <summary>
        /// 添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (CB_Province.SelectedIndex <= 0 || CB_City.SelectedIndex <= 0)
            {
                MessageBox.Show("您必须先选择一个省份以及城市以定位您的店铺！");
                return;
            }
            foreach(Object ShopName in LB_Shop.Items)
            {
                if (ShopName.ToString() == TB_ShopName.Text)
                {
                    MessageBox.Show("您不能再一个城市建立两个完全相同名字的店铺！","错误！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult res= MessageBox.Show("您确定要在" + CB_Province.SelectedItem.ToString() + CB_City.SelectedItem.ToString() + "设立" + TB_ShopName.Text + "吗？", "确认！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res ==DialogResult.OK)
            {
                int CityID = List_ShopInfo.Where(P => P.City_Name == CB_City.SelectedItem.ToString()).First().City_ID;
                if (Shop_Client.AddShop(new Car_Shop()
                {
                    Shop_Name = TB_ShopName.Text.Trim(),
                    Shop_Phone = TB_ShopPhone.Text.Trim(),
                    Shop_Info = TB_ShopInfo.Text.Trim(),
                    Shop_City = CityID
                }))
                {
                    MessageBox.Show("店铺添加成功！");
                    List_ShopInfo = UserManager_Client.GetAllShops(null, null, null).ToList();
                    LB_ShopBind();
                }
            }
        }
        #endregion
        #region 更新店铺按钮事件
        /// <summary>
        /// 更新店铺按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_UpdateShop_Click(object sender, EventArgs e)
        {
            if (CB_Province.SelectedIndex <= 0 || CB_City.SelectedIndex <= 0)
            {
                MessageBox.Show("您必须先选择一个省份以及城市以定位您的店铺！");
                return;
            }
            Shop_ViewModel tempmodel = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString() && P.Shop_Name == LB_Shop.SelectedItem.ToString()).Single();
            int ShopID = tempmodel.Shop_ID;
            int CityID = tempmodel.City_ID;
            if (Shop_Client.UpdateShop(new Car_Shop()
            {
                Shop_ID = ShopID,
                Shop_Name = TB_ShopName.Text,
                Shop_Phone = TB_ShopPhone.Text,
                Shop_Info = TB_ShopInfo.Text,
                Shop_City = CityID
            }))
            {
                MessageBox.Show("店铺资料修改成功！");
                List_ShopInfo = UserManager_Client.GetAllShops(null, null, null).ToList();
                LB_ShopBind();
            }
            else
            {
                MessageBox.Show("店铺资料修改失败!");
            }
        }
        #endregion

        #region  省份选择框变动事件
        /// <summary>
        /// 省份选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_CityBind();
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
        #region 店铺选择框变动事件
        /// <summary>
        /// 店铺选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_Shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Province.SelectedIndex <= 0 || CB_City.SelectedIndex <= 0)
            {
                MessageBox.Show("您必须先选择一个省份以及城市以定位您的店铺！");
                return;
            }
            Shop_ViewModel tempmodel = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString() && P.Shop_Name == LB_Shop.SelectedItem.ToString()).First();
            TB_ShopName.Text = tempmodel.Shop_Name;
            TB_ShopPhone.Text = tempmodel.Shop_Phone;
            TB_ShopInfo.Text = tempmodel.Shop_Info;
        }
        #endregion
        #endregion


    }
}
