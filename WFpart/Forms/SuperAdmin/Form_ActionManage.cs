using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.ActionService;
/*
 * 编写人:杜天行
 * 编写时间:2012年4月23日19:54:18
 * 编写版本:v0.5
 * */
namespace WFpart
{
    public partial class Form_ActionManage : Form
    {
        #region 参数预定义
        bool Mark;
        ActionClient Action_Client;
        List<Car_Action> List_Action;
        #endregion
        #region 构造方法
        public Form_ActionManage()
        {
            InitializeComponent();
            Action_Client = (ActionClient)ClientFactory.GetClient(ClientType.Type.Action);
            LB_ActionBind();
            BT_Update.Visible = false;
            Mark = false;
        }
        #endregion
        #region 辅助方法
        #region 绑定活动选择框
        private void LB_ActionBind()
        {
            List_Action = Action_Client.SelectAllActions().ToList();
            LB_Action.DataSource = List_Action.Select(K => K.Action_Name).ToList();
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
                BT_Update.Visible = false;
                BT_Add.Visible = true;
                TB_Action.Text = "";
                TB_Price.Text = "";
                TB_Info.Text = "";
                BT_Change.Text = "切换到修改模式";
            }
            else
            {
                Mark = true;
                BT_Update.Visible = true;
                BT_Add.Visible = false;
                LB_Action_SelectedIndexChanged(null, null);
                BT_Change.Text = "切换到添加模式";
            }
        }
        #endregion
        #region 不能输入字母
        /// <summary>
        /// 不能输入字母
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
        #region 活动选择框改变事件
        private void LB_Action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mark)
            {
                Car_Action Temp_Action = List_Action.Where(P => P.Action_Name == LB_Action.SelectedItem.ToString()).Single();
                TB_Action.Text = Temp_Action.Action_Name;
                TB_Price.Text = Temp_Action.Action_Price.ToString();
                TB_Info.Text = Temp_Action.Action_Info;
            }
        }
        #endregion
        #region 更新活动按钮
        /// <summary>
        /// 更新活动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Update_Click(object sender, EventArgs e)
        {
            if (TB_Action.Text.Trim() == "" || TB_Price.Text.Trim() == "")
            {
                MessageBox.Show("请完善您填写的资料", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (List_Action.Where(P => P.Action_Name == TB_Action.Text.Trim()).Count() > 0&&TB_Action.Text.Trim()!=LB_Action.SelectedItem.ToString().Trim())
            {
                MessageBox.Show("已经存在此项活动,请勿重复添加!", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            if (Action_Client.UpdateAction(new Car_Action() 
            { 
                Action_Name=TB_Action.Text.Trim(),
                Action_Price=Convert.ToInt32( TB_Price.Text.Trim()),
                Action_Info=TB_Info.Text
            }))
            {
                MessageBox.Show("添加活动成功!");
                LB_ActionBind();
            }
        }
        #endregion
        #region 添加活动按钮
        /// <summary>
        /// 添加活动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (TB_Action.Text.Trim() == "" || TB_Price.Text.Trim() == "")
            {
                MessageBox.Show("请完善您填写的资料", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (List_Action.Where(P => P.Action_Name == TB_Action.Text.Trim()).Count() > 0)
            {
                MessageBox.Show("已经存在此项活动,请勿重复添加!", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            if (Action_Client.AddAction(new Car_Action()
            {
                Action_Name = TB_Action.Text.Trim(),
                Action_Price = Convert.ToInt32(TB_Price.Text.Trim()),
                Action_Info = TB_Info.Text
            }))
            {
                MessageBox.Show("添加活动成功!");
                LB_ActionBind();
            }
        }
        #endregion
        #endregion
    }
}
