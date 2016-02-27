using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.CarSummeryService;
using WFpart.BrandService;
using WFpart.TypeService;
using WFpart.VersionService;
using System.IO;
using System.Drawing.Imaging;
/*
 * 编写人:杜天行
 * 编写时间:2012年4月22日16:16:14
 * 编写版本:v0.6
 * */
namespace WFpart
{
    public partial class Form_ShopVerison : Form
    {
        #region 参数预声明
        bool Mark;
        String imgString;
        CarSummeryClient CarSummery_Client;
        BrandClient Brand_Client;
        TypeClient Type_Client;
        VersionClient Version_Client;
        List<Car_ViewModel> List_VersionInfo;
        List<Car_Brand> List_Brand;
        List<Car_Type> List_Type;
        int ShopID;
        #endregion
        #region 构造方法
        public Form_ShopVerison()
        {

            InitializeComponent();


            ShopID = GlobalParams.ShopID;
            if(ShopID<0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            Brand_Client = (BrandClient)ClientFactory.GetClient(ClientType.Type.Brand);
            Type_Client = (TypeClient)ClientFactory.GetClient(ClientType.Type.Type);
            Version_Client = (VersionClient)ClientFactory.GetClient(ClientType.Type.Version);

            List_Brand = Brand_Client.SelectAllBrands().ToList();
            List_Type = Type_Client.SelectAllTypes().ToList();
            List_VersionInfo = CarSummery_Client.SelectAllCar().ToList();
            Mark = false;
            LB_VersionBind();
            CB_BrandBind();
            CB_TypeBind();
            BT_UpdateVersion.Visible = false;
        }
        #endregion
        #region 辅助方法

        private void LB_VersionBind()
        {
            List<Car_ViewModel> List_Temp = List_VersionInfo.Where(P => P.Shop_ID == ShopID).ToList();
            LB_Version.DataSource = List_Temp.Select(P => P.Version_Name).ToList();
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

            Car_ViewModel temp = List_VersionInfo.Where(P => P.Shop_ID == ShopID &&
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

                Bitmap bmp = new Bitmap(bty.FromBytes(230,null));
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

            Image img = Image.FromFile(patch);
            ImageConverter converter = new ImageConverter();

            byte[] bmpSrc = (byte[])converter.ConvertTo(img, typeof(byte[]));

            MemoryStream ms = new MemoryStream(bmpSrc);

            MemoryStream msjpg = new MemoryStream();

            Bitmap myBitmap = new Bitmap(ms);

            myBitmap.Save(msjpg, ImageFormat.Jpeg);

            byte[] bjpeg = msjpg.GetBuffer();
            //获得2进制图片数据流
            imgString = String.Join(",", Array.ConvertAll(bjpeg, (Converter<byte, string>)Convert.ToString));

            string[] imgArr = imgString.ToString().Split(new char[] { ',' });

            byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

            Bitmap bmp = new Bitmap(bty.FromBytes(230,null));
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
                List<Car_ViewModel> List_Temp = List_VersionInfo.Where(P => P.Shop_ID == ShopID).ToList();
                if (Version_Client.UpdateVersion(new VersionService.Car_Version()
                {
                    Version_ID = List_Temp.Where(P => P.Version_Name == LB_Version.SelectedItem.ToString()).Single().Version_ID,
                    Version_Shop = ShopID,
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
            if (List_VersionInfo.Where(P => P.Version_Name == TB_Name.Text && P.Shop_ID ==ShopID).Count() != 0)
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

                if (Version_Client.AddVersion(new VersionService.Car_Version()
                {
                    Version_Shop =ShopID,
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
                    Version_Price_Riding = Convert.ToDecimal(TB_PriceRiding.Text),

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
