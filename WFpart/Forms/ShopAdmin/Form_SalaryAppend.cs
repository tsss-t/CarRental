using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using WFpart.SalaryInfoSummeryService;
using WFpart.UserSummeryService;
using WFpart.WorkRAPService;
using WFpart.SalaryAppendService;
namespace WFpart
{
    public partial class Form_SalaryAppend : Form
    {
        #region 参数预定义
        bool mark;
        int ShopID;
        UserManagerClient UserManager_Client;
        SalaryInfoSummeryClient SalaryInfoSummery_Client;
        UserSummeryClient UserSummery_Client;
        SalaryAppendClient SalaryAppend_Client;
        WorkRAPClient WorkRAP_Client;
        List<SalaryAppend_ViewModel> List_SalaryAppend;
        #endregion
        #region 构造方法
        public Form_SalaryAppend()
        {
            InitializeComponent();
            ShopID = GlobalParams.ShopID;
            if (ShopID < 0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }

            UserSummery_Client = (UserSummeryClient)ClientFactory.GetClient(ClientType.Type.UserSummery);
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            SalaryInfoSummery_Client = (SalaryInfoSummeryClient)ClientFactory.GetClient(ClientType.Type.SalaryInfoSummery);
            WorkRAP_Client = (WorkRAPClient)ClientFactory.GetClient(ClientType.Type.WorkRAP);
            SalaryAppend_Client = (SalaryAppendClient)ClientFactory.GetClient(ClientType.Type.SalaryAppend);
            List_SalaryAppend = SalaryInfoSummery_Client.SelectSalaryAppend().Where(P => P.SalaryAppend_Time.Year == DateTime.Now.Year && P.SalaryAppend_Time.Month == DateTime.Now.Month).ToList();

            LB_User.DisplayMember = "UserName";
            LB_User.ValueMember = "UserId";
            LB_User.DataSource = UserManager_Client.GetAllShops(null, null, ShopID).ToList();


            mark = true;
            BT_Change_Click(null, null);
        }
        #endregion
        #region 事件
        private void LB_SalaryAppend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mark)
            {
                try
                {
                    SalaryAppend_ViewModel tempmodel = List_SalaryAppend.Where(P => P.SalaryAppend_ID == ((SalaryAppend_ViewModel)LB_SalaryAppend.SelectedItem).SalaryAppend_ID).FirstOrDefault();
                    TB_Action.Text = tempmodel.SalaryAppend_Info;
                    TB_Price.Text = tempmodel.SalaryAppend_Price.ToString();
                    DTP_Date.Value = tempmodel.SalaryAppend_Time;
                }
                catch{

                }
            }
        }

        private void LB_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_SalaryAppend.DisplayMember = "SalaryAppend_Info";
            LB_SalaryAppend.ValueMember = "SalaryAppend_ID";
            LB_SalaryAppend.DataSource = List_SalaryAppend.Where(P => P.UserName == ((Shop_ViewModel)LB_User.SelectedItem).UserName.ToString()).ToList();
            TB_RName.Text = UserSummery_Client.SelectUserEXInfo(Guid.Parse(LB_User.SelectedValue.ToString())).User_RealName;
        }
        private void BT_Update_Click(object sender, EventArgs e)
        {
            User_SalaryAppend model = SalaryAppend_Client.SelectSalaryAppend_ID((int)LB_SalaryAppend.SelectedValue);
            model.SalaryAppend_Time = DTP_Date.Value;
            model.SalaryAppend_Info = TB_Action.Text;
            model.SalaryAppend_Price = Convert.ToDecimal(TB_Price.Text);
            if (SalaryAppend_Client.UpdateSalaryAppend(model))
            {
                MessageBox.Show("修改成功!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List_SalaryAppend = SalaryInfoSummery_Client.SelectSalaryAppend().Where(P => P.SalaryAppend_Time.Year == DateTime.Now.Year && P.SalaryAppend_Time.Month == DateTime.Now.Month).ToList();
                LB_User.DataSource = UserManager_Client.GetAllShops(null, null, ShopID).ToList();
            }
            else
            {
                MessageBox.Show("修改失败!请联系管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (SalaryAppend_Client.AddSalaryAppend(new User_SalaryAppend
            {
                SalaryAppend_User = Guid.Parse(LB_User.SelectedValue.ToString()),
                SalaryAppend_Time = DTP_Date.Value,
                SalaryAppend_Info = TB_Action.Text,
                SalaryAppend_Price=Convert.ToDecimal( TB_Price.Text)
            }))
            {
                MessageBox.Show("添加成功!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List_SalaryAppend = SalaryInfoSummery_Client.SelectSalaryAppend().Where(P => P.SalaryAppend_Time.Year == DateTime.Now.Year && P.SalaryAppend_Time.Month == DateTime.Now.Month).ToList();
                LB_User.DataSource = UserManager_Client.GetAllShops(null, null, ShopID).ToList();
            }
            else
            {
                MessageBox.Show("添加失败!请联系管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BT_Change_Click(object sender, EventArgs e)
        {
            if (mark)
            {
                this.TB_Action.Text = "";
                this.TB_Price.Text = "";
                this.DTP_Date.Value = DateTime.Now;
                this.BT_Add.Visible = true;
                this.BT_Update.Visible = false;
                BT_Change.Text = "切换为修改模式";
                mark = false;
            }
            else
            {

                this.BT_Update.Visible = true;
                this.BT_Add.Visible = false;
                this.BT_Change.Text = "切换为添加模式";
                mark = true;
                LB_SalaryAppend_SelectedIndexChanged(null, null);

            }
        }
        #endregion





    }
}
