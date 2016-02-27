using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.OrderSummeryService;
using WFpart.GetCarService;
namespace WFpart
{
    public partial class Form_SelectOrder : Form
    {
        int ShopID;
        OrderSummeryClient OrderSummery_Client;
        GetCarClient GetCar_Client;
        List<Order_ViewModel> List_Order;
        public Form_SelectOrder()
        {
            InitializeComponent();
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            GetCar_Client = (GetCarClient)ClientFactory.GetClient(ClientType.Type.GetCar);
            ShopID = GlobalParams.ShopID;
            if (ShopID < 0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            List_Order = OrderSummery_Client.SelectOrderSummerys_ShopID(ShopID,null,null).ToList();
        }

        private void BT_Searck_Click(object sender, EventArgs e)
        {
            LB_Order.DataSource = List_Order.Where(P => P.Client_RealName.Contains(TB_RealName.Text.Trim()) && P.Client_Validaton.Contains(TB_Validation.Text.Trim())).Select(K=>K.Order_ID).ToList();
        }

        private void LB_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Order.SelectedIndex < 0)
            {
                return;
            }
            Order_ViewModel Select_Order = List_Order.Where(P => P.Order_ID == Convert.ToInt32(LB_Order.SelectedItem.ToString())).Single();
            Label_Version.Text = Select_Order.Version_Name;
            Label_TMstart.Text = Select_Order.Order_Start_Time.ToShortDateString();
            Label_TMend.Text = Select_Order.Order_End_Time.ToShortDateString();
            Label_OrderCount.Text = Select_Order.Order_Count.ToString();
            if (Select_Order.Checkout_Mark)
            {
                Label_IsPay.Text = "已付款";
            }
            else
            {
                Label_IsPay.Text = "未付款";
            }
            if (Select_Order.Order_DepositPay)
            {
                Label_Deposit.Text = "已付款";
            }
            else
            {
                Label_Deposit.Text = "未付款";
            }
        }

        private void BT_LastCheck_Click(object sender, EventArgs e)
        {
            if (LB_Order.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择订单!");
                return;
            }
            Form_LastCheck form = new Form_LastCheck(Convert.ToInt32(LB_Order.SelectedItem.ToString()));
            form.Owner = this;
            form.ToPayOrder += new Form_LastCheck.Back(ToPayOrder);
            form.ShowDialog();
        }
        public void ToPayOrder()
        {
            Form_CarBack form = new Form_CarBack(Convert.ToInt32(LB_Order.SelectedItem.ToString()));
            form.Owner = this;
            form.ShowDialog();
            this.Close();
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
                Order_ViewModel Select_Order = List_Order.Where(P => P.Order_ID == Convert.ToInt32(LB_Order.SelectedItem.ToString())).Single();
                if (DateTime.Now > Select_Order.Order_Start_Time)
                {
                    MessageBox.Show("您的订车服务正在进行中,您已经超过取消订单的时间");
                }
                Form_CancelOrder form = new Form_CancelOrder(Convert.ToInt32(LB_Order.SelectedItem.ToString()));
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void BT_PayDispot_Click(object sender, EventArgs e)
        {
            Form_PayDeposit form = new Form_PayDeposit(Convert.ToInt32(LB_Order.SelectedItem.ToString()));
            form.Owner = this;
            form.ShowDialog();
        }

        private void BT_CatchCar_Click(object sender, EventArgs e)
        {
            if (LB_Order.SelectedIndex < 0)
            {
                return;
            }
            Order_ViewModel Select_Order = List_Order.Where(P => P.Order_ID == Convert.ToInt32(LB_Order.SelectedItem.ToString())).Single();
            if (GetCar_Client.SelectAllCarGets().Where(P => P.GetCar_Order == Select_Order.Order_ID).Count() > 0)
            {
                MessageBox.Show("您的订单已经提车,请勿重复操作!", "错误!");
                return;
            }
            if (Select_Order.Order_End_Time < DateTime.Now)
            {
                MessageBox.Show("您的订单已经过期!","错误!");
                return;
            }
            Form_CatchCar form = new Form_CatchCar(Select_Order.Order_Count, Select_Order.Order_ID,1);
            form.Owner = this;
            form.ShowDialog();
        }

        private void BT_GetInfo_Click(object sender, EventArgs e)
        {
            if (LB_Order.SelectedIndex < 0)
            {
                return;
            }
            Order_ViewModel Select_Order = List_Order.Where(P => P.Order_ID == Convert.ToInt32(LB_Order.SelectedItem.ToString())).Single();
            if (GetCar_Client.SelectAllCarGets().Where(P => P.GetCar_Order == Select_Order.Order_ID).Count() == 0)
            {
                MessageBox.Show("您还没有进行提车操作!", "错误!");
                return;
            }
            Form_CatchCar form = new Form_CatchCar(Select_Order.Order_Count, Select_Order.Order_ID,2);
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
