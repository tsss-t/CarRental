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
    public partial class Form_CancelOrder : Form
    {
        OrderSummeryClient OrderSummery_Client;
        Order_ViewModel SelectOrder;
        int OrderID;
        public Form_CancelOrder(int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            SelectOrder = OrderSummery_Client.SelectOrderSummery_OrderID(OrderID);

            Label_Count1.Text = SelectOrder.Order_Count.ToString();
            Label_PriceDeposit.Text = SelectOrder.Version_Price_Deposit.ToString();
            decimal TotalDeposit = SelectOrder.Version_Price_Deposit * SelectOrder.Order_Count;
            Label_TotalDeposit.Text = TotalDeposit.ToString();


            Label_Count2.Text = SelectOrder.Order_Count.ToString();
            Label_CastPrice.Text = "1000";
            decimal TotalCast = 1000 * SelectOrder.Order_Count;
            Label_TotalCast.Text = TotalCast.ToString();

            Label_Total.Text = (TotalDeposit - TotalCast).ToString();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("您是否确定要取消该订单?!", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                if (OrderSummery_Client.Order_Cancel(OrderID,GlobalParams.UserID))
                {
                    MessageBox.Show("取消订单成功,欢迎您下次光临");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("取消订单失败,请联系管理员");
                }
            }
        }



    }
}
