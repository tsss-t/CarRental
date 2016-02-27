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
    public partial class Form_Delete : Form
    {
        OrderSummeryClient OrderSummery_Client;
        public Form_Delete()
        {
            InitializeComponent();
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            GV_OverTime.DataSource = OrderSummery_Client.Select_OverTime(GlobalParams.ShopID).ToList();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            DialogResult RS=
            MessageBox.Show("您确定要删除所有已过期的订单吗?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (RS == DialogResult.Yes)
            {
                int length = OrderSummery_Client.Delete_OverTime(GlobalParams.ShopID);
                if (length!=0)
                {
                    MessageBox.Show(String.Format("删除成功!共删除{0}条记录!",length));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("删除失败!请联系管理员!");
                }
            }
        }

        private void BT_Canncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
