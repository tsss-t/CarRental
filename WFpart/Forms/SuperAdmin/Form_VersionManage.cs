using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.CarSummeryService;
using WFpart.ProvinceService;
using WFpart.CityService;
using WFpart.ShopService;
using WFpart.BrandService;
using WFpart.TypeService;
using WFpart.VersionService;
using System.IO;
using System.Drawing.Imaging;
namespace WFpart
{
    public partial class Form_VersionManage : Form
    {
        #region 变量预声明
        String imgString;
        bool Mark;
        List<Car_ViewModel> List_VersionInfo;
        CarSummeryClient CarSummery_Client;
        ProvinceClient Province_Client;
        CityClient City_Client;
        ShopClient Shop_Client;
        BrandClient Brand_Client;
        TypeClient Type_Client;
        VersionClient Version_Client;
        List<Car_Province> List_Car_Province;
        List<WFpart.CityService.Car_City> List_City;
        List<WFpart.ShopService.Car_Shop> List_Shop;
        List<Car_Brand> List_Brand;
        List<WFpart.TypeService.Car_Type> List_Type;
        #endregion
        #region 构造方法
        public Form_VersionManage()
        {
            InitializeComponent();
            Mark = false;
            CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            Province_Client = (ProvinceClient)ClientFactory.GetClient(ClientType.Type.Province);
            City_Client = (CityClient)ClientFactory.GetClient(ClientType.Type.City);
            Shop_Client = (ShopClient)ClientFactory.GetClient(ClientType.Type.Shop);
            Brand_Client = (BrandClient)ClientFactory.GetClient(ClientType.Type.Brand);
            Type_Client = (TypeClient)ClientFactory.GetClient(ClientType.Type.Type);
            Version_Client = (VersionClient)ClientFactory.GetClient(ClientType.Type.Version);
            List_VersionInfo = CarSummery_Client.SelectAllCar().ToList();
            List_Car_Province = Province_Client.SelectAllProvinces().ToList();
            List_City = City_Client.SelectAllCitys().ToList();
            List_Shop = Shop_Client.SelectAllShops().ToList();
            List_Brand = Brand_Client.SelectAllBrands().ToList();
            List_Type = Type_Client.SelectAllTypes().ToList();
            CB_ProviceBind();
            CB_BrandBind();
            CB_TypeBind();
            BT_UpdateVersion.Visible = false;
        }
        #endregion
        #region 辅助方法
        private void CB_ProviceBind()
        {
            List<String> List_Province = new List<string>();
            List_Province.Clear();
            List_Province.Add("<—请选择省份—>");
            foreach (Car_Province Temp in List_Car_Province)
            {
                List_Province.Add(Temp.Province_Name);
            }
            CB_Province.DataSource = List_Province;
        }
        private void CB_CityBind()
        {
            List<WFpart.CityService.Car_City> Temp = List_City;
            List<String> List_CityName = new List<string>();
            List_CityName.Clear();
            List_CityName.Add("<—请选择城市—>");
            if (CB_Province.SelectedIndex > 0)
            {
                Temp = List_City.Where(P => P.City_Province == List_Car_Province.Where(T => T.Province_Name == CB_Province.SelectedItem.ToString()).Single().Province_ID).ToList();
                foreach (WFpart.CityService.Car_City TempView in Temp)
                {
                    List_CityName.Add(TempView.City_Name);
                }
            }
            CB_City.DataSource = List_CityName;
        }
        private void CB_ShopBind()
        {
            List<WFpart.ShopService.Car_Shop> Temp = List_Shop;
            List<String> List_ShopName = new List<string>();
            List_ShopName.Clear();
            List_ShopName.Add("<—请选择店铺—>");
            if (CB_City.SelectedIndex > 0)
            {
                Temp = List_Shop.Where(P => P.Shop_City == List_City.Where(T => T.City_Name == CB_City.SelectedItem.ToString() && T.City_Province == List_Car_Province.Where(K => K.Province_Name == CB_Province.SelectedItem.ToString()).Single().Province_ID).Single().City_ID).ToList();
                foreach (WFpart.ShopService.Car_Shop TempView in Temp)
                {
                    List_ShopName.Add(TempView.Shop_Name);
                }
            }
            CB_Shop.DataSource = List_ShopName;
        }
        private void LB_VersionBind()
        {
            if (CB_Shop.SelectedIndex > 0)
            {
                List<Car_ViewModel> List_Temp = List_VersionInfo.Where(
                    P => P.Province_Name == CB_Province.SelectedItem.ToString() &&
                    P.City_Name == CB_City.SelectedItem.ToString() &&
                    P.Shop_Name == CB_Shop.SelectedItem.ToString()
                    ).ToList();
                LB_Version.DataSource = List_Temp.Select(P => P.Version_Name).ToList();
            }
        }
        private void CB_BrandBind()
        {
            List<String> List_BrandName = new List<string>();
            List_BrandName.Add("<—请选择品牌—>");
            List_BrandName.AddRange(List_Brand.Select(K => K.Brand_Name).ToList());
            CB_Brand.DataSource = List_BrandName;
        }
        private void CB_TypeBind()
        {
            List<String> List_TypeName = new List<string>();
            List_TypeName.Add("<—请车辆类型—>");
            List_TypeName.AddRange(List_Type.Select(K => K.Type_Name).ToList());
            CB_Type.DataSource = List_TypeName;
        }
        #region 不能输入字幕
        /// <summary>
        /// 不能输入字幕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kc = e.KeyChar;
            TextBox txtMoney = (TextBox)sender;
            if ((kc < 48 || kc > 57) && kc != 8)
            {
                e.Handled = true;
            }
            if (kc == 46)                       //小数点
            {
                if (txtMoney.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtMoney.Text, out oldf);
                    b2 = float.TryParse(txtMoney.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        #endregion
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
            CB_ShopBind();
        }
        #endregion
        #region 店铺选择框变动事件
        private void CB_Shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_VersionBind();
        }
        #endregion
        #region 车型选择框变动事件
        /// <summary>
        /// 车型选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Version.SelectedIndex < 0 || !Mark)
            {
                return;
            }

            Car_ViewModel temp = List_VersionInfo.Where(
                P => P.Province_Name == CB_Province.SelectedItem.ToString() &&
                    P.City_Name == CB_City.SelectedItem.ToString() &&
                    P.Shop_Name == CB_Shop.SelectedItem.ToString() &&
                    P.Version_Name == LB_Version.SelectedItem.ToString()
                    ).First();
            TB_Count.Text = temp.Version_Count.ToString();
            TB_Info.Text = temp.Version_Info;
            TB_Name.Text = temp.Version_Name;
            TB_Person.Text = temp.Version_Person.ToString();
            TB_PriceOver.Text = temp.Version_Price_Deposit.ToString();
            TB_PriceMemberCatch.Text = temp.Version_Price_Member_Catch.ToString();
            TB_PriceMemberRental.Text = temp.Version_Price_Member_Rental.ToString();
            TB_PriceNormalCatch.Text = temp.Version_Price_Normal_Catch.ToString();
            TB_PriceNormalRental.Text = temp.Version_Price_Normal_Rental.ToString();
            TB_BaseKM.Text = temp.Version_BaseKM.ToString();
            TB_PriceOverRiding.Text = temp.Version_Price_Over_Riding.ToString();
            TB_PriceRiding.Text = temp.Version_Price_Riding.ToString();
            TB_PriceDeposit.Text = temp.Version_Price_Deposit.ToString();
            CB_Type.SelectedItem = temp.Type_Name.ToString();
            CB_Brand.SelectedItem = temp.Brand_Name.ToString();
            imgString = null;
            try
            {
                string[] imgArr = temp.Version_IMG.ToString().Split(new char[] { ',' });

                byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

                Bitmap bmp = new Bitmap(bty.FromBytes(320,null));
                PB_Pic.Image = bmp;
                imgString = temp.Version_IMG;
            }
            catch
            {
                MessageBox.Show("载入图片出现错误，请重新上传图片更新数据库或联系管理员！", "错误！！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
        #region 状态切换按钮事件
        /// <summary>
        /// 状态切换按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Change_Click(object sender, EventArgs e)
        {
            if (Mark)
            {
                Mark = false;
                BT_UpdateVersion.Visible = false;
                BT_AddVersion.Visible = true;
                LB_Version.ClearSelected();
                TB_Info.Text = "";
                TB_Name.Text = "";
                TB_Count.Text = "";
                TB_Person.Text = "";
                TB_PriceOver.Text = "";
                TB_PriceDeposit.Text = "";
                TB_BaseKM.Text = "";
                TB_PriceOver.Text = "";
                TB_PriceOverRiding.Text = "";
                TB_PriceRiding.Text = "";
                TB_PriceMemberCatch.Text = "";
                TB_PriceMemberRental.Text = "";
                TB_PriceNormalRental.Text = "";
                TB_PriceNormalCatch.Text = "";
                PB_Pic.Image = null;
                BT_Change.Text = "切换到修改模式";
            }
            else
            {
                Mark = true;
                BT_UpdateVersion.Visible = true;
                BT_AddVersion.Visible = false;
                LB_Version_SelectedIndexChanged(null, null);
                BT_Change.Text = "切换到添加模式";
            }
        }
        #endregion
        #region 图片拖拽到指定位置时发生的事件
        /// <summary>
        /// 图片拖拽到指定位置时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PL_AddPic_DragDrop(object sender, DragEventArgs e)
        {
            string patch = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            //获得2进制图片数据流
            imgString = patch.ImagePatchToBaniryString();

            string[] imgArr = imgString.ToString().Split(new char[] { ',' });

            byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

            Bitmap bmp = new Bitmap(bty.FromBytes(320,null));
            PB_Pic.Image = bmp;

        }
        private void PL_AddPic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
        #endregion
        #region 修改按钮
        private void BT_UpdateVersion_Click(object sender, EventArgs e)
        {
            if (LB_Version.SelectedIndex < 0)
            {
                MessageBox.Show("您想要修改神马!!");
            }
            if (TB_BaseKM.IsEmpty() &&
                TB_Count.IsEmpty() &&
                TB_Name.IsEmpty() &&
                TB_Person.IsEmpty() &&
                TB_PriceOver.IsEmpty() &&
                TB_PriceMemberCatch.IsEmpty() &&
                TB_PriceMemberRental.IsEmpty() &&
                TB_PriceNormalCatch.IsEmpty() &&
                TB_PriceNormalRental.IsEmpty() &&
                TB_PriceOverRiding.IsEmpty() &&
                TB_PriceRiding.IsEmpty() &&
                TB_PriceDeposit.IsEmpty()&&
                CB_Brand.SelectedIndex > 0 &&
                CB_Type.SelectedIndex > 0
                )
            {
                List<Car_ViewModel> List_Temp = List_VersionInfo.Where(
                P => P.Province_Name == CB_Province.SelectedItem.ToString() &&
                P.City_Name == CB_City.SelectedItem.ToString() &&
                P.Shop_Name == CB_Shop.SelectedItem.ToString()
                ).ToList();
                List<WFpart.ShopService.Car_Shop> Temp = List_Shop.Where(
                    P => P.Shop_City == List_City.Where(
                        T => T.City_Name == CB_City.SelectedItem.ToString() &&
                            T.City_Province == List_Car_Province.Where(
                            K => K.Province_Name == CB_Province.SelectedItem.ToString()).Single().Province_ID).Single().City_ID
                            ).ToList();
                if (Version_Client.UpdateVersion(new VersionService.Car_Version()
                {
                    Version_ID = List_Temp.Where(P => P.Version_Name == LB_Version.SelectedItem.ToString()).Single().Version_ID,
                    Version_Shop = Temp.Where(P => P.Shop_Name == CB_Shop.SelectedItem.ToString()).Single().Shop_ID,
                    Version_BaseKM = Convert.ToInt32(TB_BaseKM.Text),
                    Version_Brand = List_Brand.Where(P => P.Brand_Name == CB_Brand.SelectedItem.ToString()).Single().Brand_ID,
                    Version_Count = Convert.ToInt32(TB_Count.Text),
                    Version_IMG = imgString,
                    Version_Info = TB_Info.Text,
                    Version_Name = TB_Name.Text,
                    Version_Type = List_Type.Where(P => P.Type_Name == CB_Type.SelectedItem.ToString()).Single().Type_ID,
                    Version_Person = Convert.ToInt32(TB_Person.Text),
                    Version_Price_Deposit = Convert.ToDecimal(TB_PriceDeposit.Text),
                    Version_Price_Member_Catch = Convert.ToDecimal(TB_PriceMemberCatch.Text),
                    Version_Price_Member_Rental = Convert.ToDecimal(TB_PriceMemberRental.Text),
                    Version_Price_Normal_Catch = Convert.ToDecimal(TB_PriceNormalCatch.Text),
                    Version_Price_Normal_Rental = Convert.ToDecimal(TB_PriceNormalRental.Text),
                    Version_Price_Over = Convert.ToDecimal(TB_PriceOver.Text),
                    Version_Price_Over_Riding = Convert.ToDecimal(TB_PriceOverRiding.Text),
                    Version_Price_Riding = Convert.ToDecimal(TB_PriceRiding.Text)
                }))
                {
                    MessageBox.Show("修改车型成功!");
                    List_VersionInfo = CarSummery_Client.SelectAllCar().ToList();
                    LB_VersionBind();
                }
                else
                {
                    MessageBox.Show("修改车型失败,请检查拼写,如错误依旧,请联系管理员!", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }
        #endregion
        #region 添加车型按钮
        private void BT_AddVersion_Click(object sender, EventArgs e)
        {
            if (CB_City.SelectedIndex <= 0)
            {
                MessageBox.Show("请先选择好要添加到的店铺");
                return;
            }
            if (List_VersionInfo.Where(P => P.Version_Name == TB_Name.Text&&P.Shop_Name==CB_Shop.SelectedItem.ToString()).Count() != 0)
            {
                MessageBox.Show("已经存在此种车型!");
                return;
            }
            //判断选择框都不为空
            if (TB_BaseKM.IsEmpty() &&
                TB_Count.IsEmpty() &&
                TB_Name.IsEmpty() &&
                TB_Person.IsEmpty() &&
                TB_PriceOver.IsEmpty() &&
                TB_PriceMemberCatch.IsEmpty() &&
                TB_PriceMemberRental.IsEmpty() &&
                TB_PriceNormalCatch.IsEmpty() &&
                TB_PriceNormalRental.IsEmpty() &&
                TB_PriceOverRiding.IsEmpty() &&
                TB_PriceRiding.IsEmpty() &&
                TB_PriceDeposit.IsEmpty()&&
                CB_Brand.SelectedIndex > 0 &&
                CB_Type.SelectedIndex > 0
                )
            {
                List<WFpart.ShopService.Car_Shop> Temp = List_Shop.Where(P => P.Shop_City == List_City.Where(T => T.City_Name == CB_City.SelectedItem.ToString() && T.City_Province == List_Car_Province.Where(K => K.Province_Name == CB_Province.SelectedItem.ToString()).Single().Province_ID).Single().City_ID).ToList();

                if (Version_Client.AddVersion(new VersionService.Car_Version()
                {
                    Version_Shop = Temp.Where(P => P.Shop_Name == CB_Shop.SelectedItem.ToString()).Single().Shop_ID,
                    Version_BaseKM = Convert.ToInt32(TB_BaseKM.Text),
                    Version_Brand = List_Brand.Where(P => P.Brand_Name == CB_Brand.SelectedItem.ToString()).Single().Brand_ID,
                    Version_Count = Convert.ToInt32(TB_Count.Text),
                    Version_IMG = imgString,
                    Version_Info = TB_Info.Text,
                    Version_Name = TB_Name.Text,
                    Version_Type = List_Type.Where(P => P.Type_Name == CB_Type.SelectedItem.ToString()).Single().Type_ID,
                    Version_Person = Convert.ToInt32(TB_Person.Text),
                    Version_Price_Deposit = Convert.ToDecimal(TB_PriceDeposit.Text),
                    Version_Price_Member_Catch = Convert.ToDecimal(TB_PriceMemberCatch.Text),
                    Version_Price_Member_Rental = Convert.ToDecimal(TB_PriceMemberRental.Text),
                    Version_Price_Normal_Catch = Convert.ToDecimal(TB_PriceNormalCatch.Text),
                    Version_Price_Normal_Rental = Convert.ToDecimal(TB_PriceNormalRental.Text),
                    Version_Price_Over = Convert.ToDecimal(TB_PriceOver.Text),
                    Version_Price_Over_Riding = Convert.ToDecimal(TB_PriceOverRiding.Text),
                    Version_Price_Riding = Convert.ToDecimal(TB_PriceRiding.Text)
                }
                ))
                {
                    MessageBox.Show("添加车型成功!");
                    List_VersionInfo = CarSummery_Client.SelectAllCar().ToList();
                    LB_VersionBind();
                }
                else
                {
                    MessageBox.Show("添加车型失败,请检查拼写,如错误依旧,请联系管理员!", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }



            }
        }
        #endregion


        #endregion
    }
}
