using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using WFpart.CityService;
using WFpart.ProvinceService;
using WFpart.ShopService;

/*
 * 编写人：杜天行
 * 编写时间：2012年4月18日18:48:04
 * 编写版本：v0.5
 * */
namespace WFpart
{
    public partial class Form_CityManage : Form
    {
        #region 参数预声明
        List<WFpart.CityService.Car_City> List_City;
        CityClient City_Client;
        ProvinceClient Province_Client;
        ShopClient Shop_Client;
        UserManagerClient UserManager_Client;
        #endregion
        #region 构造方法
        public Form_CityManage()
        {
            InitializeComponent();
            City_Client = (CityClient)ClientFactory.GetClient(ClientType.Type.City);
            Province_Client = (ProvinceClient)ClientFactory.GetClient(ClientType.Type.Province);
            List_City = City_Client.SelectAllCitys().ToList();
            CB_ProviceBind();
        }
        #endregion
        #region 辅助方法
        private void CB_ProviceBind()
        {
            List<String> List_Province = new List<string>();
            List_Province.Clear();
            List_Province.Add("<—请选择省份—>");
            List<Car_Province> List_Car_Province = Province_Client.SelectAllProvinces().ToList();
            foreach (Car_Province Temp in List_Car_Province)
            {
                List_Province.Add(Temp.Province_Name);
            }
            CB_Province.DataSource = List_Province;
        }
        private void LB_CityBind()
        {

            List<String> List_CityName = new List<string>();
            List<WFpart.CityService.Car_City> Temp = List_City;
            List_CityName.Clear();
            if (CB_Province.SelectedIndex != 0)
            {
                Temp = List_City.Where(P => P.City_Province == Province_Client.SelectProvince_Name(CB_Province.SelectedItem.ToString()).Province_ID).ToList();
                foreach (WFpart.CityService.Car_City TempView in Temp)
                {
                    List_CityName.Add(TempView.City_Name);

                }
            }
        
            LB_City.DataSource = List_CityName;

        }
        #endregion
        #region 事件
        /// <summary>
        /// 省份选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_CityBind();
        }
        /// <summary>
        /// 添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_AddCity_Click(object sender, EventArgs e)
        {
            if (TB_CityName.Text != "" && CB_Province.SelectedIndex > 0)
            {
                int ProvinceID = Province_Client.SelectProvince_Name(CB_Province.SelectedItem.ToString()).Province_ID;
                WFpart.CityService.Car_City City = new WFpart.CityService.Car_City() { City_Name = TB_CityName.Text, City_Province = ProvinceID };
                if (City_Client.AddCity(City))
                {
                    MessageBox.Show("添加城市成功!");
                }
                List_City = City_Client.SelectAllCitys().ToList();
                LB_CityBind();
            }
            else
            {
                MessageBox.Show("请先选定好所属省份并填写城市名称！");
            }
        }
        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_DeletCity_Click(object sender, EventArgs e)
        {
            if (CB_Province.SelectedIndex<=0)
            {
                MessageBox.Show("请先指定省份!");
                return;
            }
            if (LB_City.SelectedIndex<0)
            {
                MessageBox.Show("请选择您要删除的城市!");
                return;
            }
            DialogResult res= MessageBox.Show("该操作会将您选定的城市信息连同该城市的所有店铺等信息全部删除，该操作是不可逆的，是否继续进行？", "警告！！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0);
            if (res == DialogResult.OK)
            {
                UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
                Shop_Client = (ShopClient)ClientFactory.GetClient(ClientType.Type.Shop);
                int ProvinceID = Province_Client.SelectProvince_Name(CB_Province.SelectedItem.ToString()).Province_ID;
                int CityID = City_Client.SelectCity_Name(LB_City.SelectedItem.ToString(), ProvinceID).City_ID;
                if (Shop_Client.SelectShop_CityID(CityID).Count() != 0)
                {
                    List<WFpart.ShopService.Car_Shop> List_Shop = Shop_Client.SelectShop_CityID(CityID).ToList();
                    //删除店铺和店铺关系
                    foreach (WFpart.ShopService.Car_Shop temp in List_Shop)
                    {
                        UserManager_Client.UserDropShop_ShopID(temp.Shop_ID);
                        Shop_Client.DeleteShop(temp.Shop_ID);
                    }
                }
                City_Client.DeleteCity(CityID);
            }
            List_City = City_Client.SelectAllCitys().ToList();
            LB_CityBind();
        }
        #endregion

        private void BT_UpdateCity_Click(object sender, EventArgs e)
        {
            int ProvinceID = Province_Client.SelectProvince_Name(CB_Province.SelectedItem.ToString()).Province_ID;
            int CityID = List_City.Where(P => P.City_Name == LB_City.SelectedItem.ToString() && P.City_Province == ProvinceID).Single().City_ID;
            if (City_Client.UpdateCity(new CityService.Car_City()
             {
                 City_ID = CityID,
                 City_Name = TB_CityName.Text,
                 City_Province = ProvinceID
             }))
            {
                MessageBox.Show("城市名称修改成功！");
                List_City = City_Client.SelectAllCitys().ToList();
                LB_CityBind();
            }
            else
            {
                MessageBox.Show("城市名称修改失败！");
            }
        }

        private void LB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_CityName.Text = LB_City.SelectedItem.ToString();
        }

    }
}
