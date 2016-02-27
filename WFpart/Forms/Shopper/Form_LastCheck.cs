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
    public partial class Form_LastCheck : Form
    {
        int OrderID;
        OrderSummeryClient OrderSummery_Client;

        public delegate void Back();
        public event Back ToPayOrder;
        public Form_LastCheck(int OrderID)
        {
            InitializeComponent();
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            this.OrderID = OrderID;
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

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            if (
            OrderSummery_Client.LastCheakOrder(GlobalParams.UserName, OrderID, Convert.ToInt32(TB_OverKM.Text))
            )
            {
                MessageBox.Show("添加确认成功!现在转到付费页面");
                this.Close();
                ToPayOrder();
            }
            else
            {
                MessageBox.Show("操纵失败,请联系管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
