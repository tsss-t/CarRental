using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.OrderService;
using WFpart.VersionService;
namespace WFpart
{
    public partial class Form_PayDeposit : Form
    {
        OrderClient Order_Client;
        VersionClient Version_Client;
        Car_Version Version;
        OrderService.Car_Order Order;
        int Order_ID;
        public Form_PayDeposit(int Order_ID)
        {
            InitializeComponent();
            this.Order_ID = Order_ID;
            Order_Client = (OrderClient)ClientFactory.GetClient(ClientType.Type.Order);
            Version_Client = (VersionClient)ClientFactory.GetClient(ClientType.Type.Version);
            Order = Order_Client.SelectOrder_ID(Order_ID);
            Version = Version_Client.SelectVersion_ID(Order.Order_Version);
            this.LB_Number.Text = Order.Order_Count.ToString();
            this.LB_EveryPrice.Text = Version.Version_Price_Deposit.ToString();
            this.LB_TotalPrice.Text = (Version.Version_Price_Deposit * Order.Order_Count).ToString();
        }

        private void BT_Canncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            DialogResult DR=
            MessageBox.Show("请确认是否已收齐货款", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DR == DialogResult.Yes)
            {
                if (Order_Client.PayDeposit(Order_ID))
                {
                    MessageBox.Show("恭喜!您已经支付成功!","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("对不起,支付失败,请联系管理员!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
