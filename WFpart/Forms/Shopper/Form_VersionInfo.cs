using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.CarSummeryService;
using WFpart.OrderSummeryService;

namespace WFpart
{
    public partial class Form_VersionInfo : Form
    {
        CarSummeryClient CarSummery_Client;
        OrderSummeryClient OrderSummery_Client;
        public Form_VersionInfo(int ShopID, int VersionID, string[] starttime, string[] endtime)
        {
            InitializeComponent();
            CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            Car_ViewModel SelectCar = CarSummery_Client.SelectAllCar().Where(P => P.Version_ID == VersionID).Single();
            int Versiontotal = SelectCar.Version_Count;

            int Car_Count = OrderSummery_Client.SelectRentaledCarCount_TimeAndVersion(
                ShopID, VersionID,
                Convert.ToInt32(starttime[0]),
                Convert.ToInt32(starttime[1]),
                Convert.ToInt32(starttime[2]),
                Convert.ToInt32(endtime[0]),
                Convert.ToInt32(endtime[1]),
                Convert.ToInt32(endtime[2])
                );
            int nokosite = Versiontotal - Car_Count;
            Label_BaseKM.Text = SelectCar.Version_BaseKM.ToString();
            Label_Brand.Text = SelectCar.Brand_Name.ToString();
            Label_Count.Text = nokosite.ToString();
            Label_Info.Text = SelectCar.Version_Info;
            Label_Person.Text = SelectCar.Version_Person.ToString();
            Label_PriceDeposit.Text = SelectCar.Version_Price_Deposit.ToString();
            Label_PriceMemberCatch.Text = SelectCar.Version_Price_Member_Catch.ToString();
            Label_PriceMemberRental.Text = SelectCar.Version_Price_Member_Rental.ToString();
            Label_PriceNormalCatch.Text = SelectCar.Version_Price_Normal_Catch.ToString();
            Label_PriceNormalRental.Text = SelectCar.Version_Price_Normal_Rental.ToString();
            Label_PriceOver.Text = SelectCar.Version_Price_Over.ToString();
            Label_PriceOverRiding.Text = SelectCar.Version_Price_Over_Riding.ToString();
            Label_PriceRiding.Text = SelectCar.Version_Price_Riding.ToString();
            Label_Type.Text = SelectCar.Type_Name;
            Label_Version.Text = SelectCar.Version_Name;
            try
            {
                string[] imgArr = SelectCar.Version_IMG.ToString().Split(new char[] { ',' });

                byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

                Bitmap bmp = new Bitmap(bty.FromBytes(520,null));
                PB_Pic.Image = bmp;
            }
            catch
            {
                MessageBox.Show("载入图片出现错误，请重新上传图片更新数据库或联系管理员！", "错误！！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BT_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
