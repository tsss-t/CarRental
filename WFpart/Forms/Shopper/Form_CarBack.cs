using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.OrderSummeryService;

namespace WFpart
{
    public partial class Form_CarBack : Form
    {
        int OrderID;
        OrderSummeryClient OrderSummery_Client;
        Order_ViewModel Order_Temp;
        public Form_CarBack(int OrderID)
        {
            InitializeComponent();
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            Order_Temp = OrderSummery_Client.SelectOrderSummery_OrderID(OrderID);
            TimeSpan TS_Start = new TimeSpan(Order_Temp.Order_Start_Time.Ticks);
            TimeSpan TS_End = new TimeSpan(Order_Temp.Checkout_Time.Ticks);
            TimeSpan TS = TS_Start.Subtract(TS_End);
            decimal RentalPrice;
            decimal CatchPrice;
            decimal OverPrice;
            decimal RentalType;
            #region 设定4差别项

            if (Order_Temp.RentalType_Name == "自驾")
            {
                RentalType = 0;
                OverPrice = Order_Temp.Version_Price_Over;
            }
            else
            {
                RentalType = Order_Temp.Version_Price_Riding;
                OverPrice = Order_Temp.Version_Price_Over_Riding;
            }
            if (Order_Temp.Client_RoleName == "普通会员")
            {
                RentalPrice = Order_Temp.Version_Price_Normal_Rental;
                if (Order_Temp.Order_IsCatch)
                {
                    CatchPrice = Order_Temp.Version_Price_Normal_Catch;
                }
                else
                {
                    CatchPrice = 0;
                }
            }
            else
            {
                RentalPrice = Order_Temp.Version_Price_Member_Rental;
                if (Order_Temp.Order_IsCatch)
                {
                    CatchPrice = Order_Temp.Version_Price_Member_Catch;
                }
                else
                {
                    CatchPrice = 0;
                }
            }
            #endregion
            //租借车型
            Label_Version.Text = Order_Temp.Version_Name;
            Label_Type.Text = Order_Temp.Type_Name;
            Label_Brand.Text = Order_Temp.Brand_Name;
            this.OrderID = OrderID;

            //基本租金
            Label_Count1.Text = Order_Temp.Order_Count.ToString();
            Label_Day1.Text = TS.Duration().Days.ToString();
            Label_PriceRental.Text = RentalPrice.ToString();
            decimal Total_Rental = RentalPrice * TS.Duration().Days * Order_Temp.Order_Count;
            Label_TotalRental.Text = Total_Rental.ToString();

            //接送费用
            Label_Count2.Text = Order_Temp.Order_Count.ToString();
            Label_PriceCatch.Text = CatchPrice.ToString();
            decimal Total_Catch= Order_Temp.Order_Count*CatchPrice;
            Label_TotalCatch.Text = Total_Catch.ToString();

            //行驶费用
            Label_BaseKM.Text = Order_Temp.Version_BaseKM.ToString();
            Label_OverKM.Text = Order_Temp.Checkout_KM.ToString();
            Label_PriceOver.Text = OverPrice.ToString();
            decimal Total_Over = Order_Temp.Checkout_KM * OverPrice;
            Label_TotalOver.Text = Total_Over.ToString();

            //代驾费用
            Label_Count3.Text = Order_Temp.Order_Count.ToString();
            Label_Day2.Text = TS.Duration().Days.ToString();
            Label_PriceRiding.Text = RentalType.ToString();
            decimal Total_RentalType = Order_Temp.Order_Count * TS.Duration().Days * RentalType;
            Label_TotalRentalType.Text = Total_RentalType.ToString();

            //活动优惠
            Label_Count5.Text = Order_Temp.Order_Count.ToString();
            Label_ActionPrice.Text = Order_Temp.Action_Price.ToString();
            decimal Total_Action = Order_Temp.Order_Count * Order_Temp.Action_Price;
            Label_TotalAction.Text = Total_Action.ToString();

            //押金退还
            Label_Count4.Text = Order_Temp.Order_Count.ToString();
            Label_PriceDeposit.Text = Order_Temp.Version_Price_Deposit.ToString();
            decimal Total_Deposit = Order_Temp.Order_Count * Order_Temp.Version_Price_Deposit;
            Label_TotalDeposit.Text = Total_Deposit.ToString();


            Label_Total.Text = (Total_Rental + Total_Catch + Total_Over + Total_RentalType + Total_Action - Total_Deposit).ToString();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
           DialogResult res=MessageBox.Show("您确定已收银并买单吗？","警告！",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
           if(res==DialogResult.OK)
           {
               if (OrderSummery_Client.Pay_Order(OrderID))
               {
                   MessageBox.Show("您已经完成了买单操作，谢谢您的惠顾！欢迎再次光临!");
                   this.Close();
               }
               else
               {
                   MessageBox.Show("系统内部错误！请联系管理员！");
               }

           }
        }





    }
}
