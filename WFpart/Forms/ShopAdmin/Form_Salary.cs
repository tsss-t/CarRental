using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.SalaryInfoSummeryService;
using WFpart.SalaryLogService;
/*
 * 员工工资查询类
 * 编写人:杜天行
 * 编写时间:2012年6月2日13:48:23
 * 版本:v1.0
 * */
namespace WFpart
{
    public partial class Form_Salary : Form
    {
        int ShopID;
        int year;
        int month;
        int day;
        SalaryInfoSummeryClient SalaryInfoSummery_Client;
        List<SalaryInfo_ViewModel> List_SalaryInfo;
        SalaryLogClient SalaryLog_Client;
        public Form_Salary()
        {
            InitializeComponent();
            if (ShopID < 0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            year = 2012;
            month = 1;
            SalaryInfoSummery_Client = (SalaryInfoSummeryClient)ClientFactory.GetClient(ClientType.Type.SalaryInfoSummery);
            SalaryLog_Client = (SalaryLogClient)ClientFactory.GetClient(ClientType.Type.SalaryLog);
            List_SalaryInfo = SalaryInfoSummery_Client.SelectSalaryInfo(ShopID, null, null, null, null, null).ToList();
            dataGridView1.DataSource = List_SalaryInfo;
            Bind_Year();
        }
        #region 年月2级联动
        private void Bind_Year()
        {
            List<String> List_Year = new List<string>();

            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                List_Year.Add(i.ToString());
            }
            CB_Year.DataSource = List_Year;
        }
        private void Bind_Month()
        {
            List<String> List_Month = new List<string>();
            if (CB_Year.SelectedIndex >= 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    List_Month.Add(i.ToString());
                }
                year = Convert.ToInt32(CB_Year.SelectedItem.ToString());
            }
            else
            {
                year = 0;
            }
            CB_Month.DataSource = List_Month;
        }
        private void CB_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Month();
        }


        private void CB_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SalaryInfo_ViewModel> List_Temp = List_SalaryInfo.Where(P=>P.Time!=null&&P.SalaryLog_Mark!=null).Where(P => Convert.ToInt32(P.Time.Substring(0, 4)) == Convert.ToInt32(CB_Year.SelectedItem.ToString()) && Convert.ToInt32(P.Time.Substring(5, 2)) == Convert.ToInt32(CB_Month.SelectedItem.ToString())).ToList();
            dataGridView1.DataSource = List_Temp.Select(K => new
            {
                姓名 = K.User_RealName,
                用户名 = K.UserName,
                职位 = K.RoleName,
                基本工资 = K.Salary_Price,
                出勤工资 = K.RAP_Price,
                奖金 = K.SalaryAppend_Price,
                工资总计 = K.TatalPrice,
                是否领取 = K.SalaryLog_Mark == false ? "否" : "是"
            }).ToList();
        }
        #endregion

        private void BT_GetSalary_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                String RoleName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                String RealName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int Year = Convert.ToInt32(CB_Year.SelectedItem.ToString());
                int Month = Convert.ToInt32(CB_Month.SelectedItem.ToString());
                decimal Price=Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                DialogResult RS =
                MessageBox.Show(String.Format("您确认现在为{0}发放{1}年{2}月的工资吗?", RealName, Year, Month), "警告!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (RS == DialogResult.Yes)
                {
                    if ((bool)List_SalaryInfo.Where(
                        P => P.RoleName == RoleName &&
                            P.UserName == UserName &&
                            Convert.ToInt32(P.Time.Substring(0, 4)) == Year &&
                            Convert.ToInt32(P.Time.Substring(5, 2)) == Month
                       ).FirstOrDefault().SalaryLog_Mark)
                    {
                        MessageBox.Show("您已经领取本月工资!请勿重复申请!");
                        return;
                    }

                    if(SalaryInfoSummery_Client.GetSalary(((int)
                        List_SalaryInfo.Where(
                        P => P.RoleName == RoleName &&
                            P.UserName == UserName &&
                            Convert.ToInt32(P.Time.Substring(0, 4)) == Year &&
                            Convert.ToInt32(P.Time.Substring(5, 2)) == Month
                       ).FirstOrDefault().SalaryLog_ID), GlobalParams.UserID, RealName, -Price))
                    {
                        MessageBox.Show("领取工资成功!");
                        List_SalaryInfo = SalaryInfoSummery_Client.SelectSalaryInfo(ShopID, null, null, null, null, null).ToList();
                        CB_Month_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("领取工资失败!");
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message + "           提示:请只选定您要进行操作的单列!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_SalaryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                String RoleName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                String RealName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                decimal BaseSalary=Convert.ToDecimal( dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                decimal TotalSalary=Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                int Year = Convert.ToInt32(CB_Year.SelectedItem.ToString());
                int Month = Convert.ToInt32(CB_Month.SelectedItem.ToString());
                Guid UID = List_SalaryInfo.Where(P => P.UserName == UserName && P.RoleName == RoleName && P.User_RealName == RealName &&Convert.ToInt32(P.Time.Substring(0, 4)) == Year&&Convert.ToInt32(P.Time.Substring(5,2))==Month).FirstOrDefault().UserId;

                Form_SalaryInfo form = new Form_SalaryInfo(UID,RealName,BaseSalary,TotalSalary);
                form.Show();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message + "           提示:请只选定您要进行操作的单列!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
