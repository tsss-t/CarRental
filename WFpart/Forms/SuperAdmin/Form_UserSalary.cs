using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.SalaryInfoSummeryService;
using WFpart.SalaryService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月17日13:25:22
 * 编写版本：v0.5
 * */
namespace WFpart
{
    /// <summary>
    /// 店铺、用户管理管理窗体
    /// </summary>
    public partial class Form_UserSalary : Form
    {
        #region 参数预声明
        SalaryInfoSummeryClient SalaryInfoSummery_Client;
        SalaryClient Salary_Client;
        List<Salary_ViewModel> List_Salary;
        #endregion
        #region 构造方法
        public Form_UserSalary()
        {
            InitializeComponent();
            SalaryInfoSummery_Client = (SalaryInfoSummeryClient)ClientFactory.GetClient(ClientType.Type.SalaryInfoSummery);
            Salary_Client = (SalaryClient)ClientFactory.GetClient(ClientType.Type.Salary);
            BindLB();
        }
        #endregion

        #region 辅助方法
        public void BindLB()
        {

            List_Salary= SalaryInfoSummery_Client.SelectAllSalary().ToList();
            List<String> ListSalary = List_Salary.Select(P => P.RoleName).ToList();
            LB_Role.DataSource = ListSalary;
        }
        #endregion
        #region 事件

        private void LB_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Salary.Text = List_Salary.Where(P => P.RoleName == LB_Role.SelectedItem.ToString()).FirstOrDefault().Salary_Price.ToString();
        }
        private void BT_Submit_Click(object sender, EventArgs e)
        {
            int Salary_id = List_Salary.Where(P => P.RoleName == LB_Role.SelectedItem.ToString()).FirstOrDefault().Salary_ID;
            Guid Role_ID=List_Salary.Where(P=>P.RoleName==LB_Role.SelectedItem.ToString()).FirstOrDefault().Salary_Role;
            if (
            Salary_Client.UpdateSalary(new User_Salary() {Salary_ID=Salary_id, Salary_Price = Convert.ToDecimal(TB_Salary.Text.ToString()), Salary_Role = Role_ID }))
            {
                MessageBox.Show("修改成功!", "提示");
                BindLB();
            }
            else
            {
                MessageBox.Show("修改失败!", "错误");
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


    }
}
