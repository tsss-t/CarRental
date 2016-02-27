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
using WFpart.RAPService;
using WFpart.WorkRAPService;
namespace WFpart
{
    public partial class Form_RAP : Form
    {
        #region 参数预定义
        bool mark;
        int ShopID;
        UserManagerClient UserManager_Client;
        SalaryInfoSummeryClient SalaryInfoSummery_Client;
        UserSummeryClient UserSummery_Client;
        RAPClient RAP_Client;
        WorkRAPClient WorkRAP_Client;
        List<RAP_ViewModel> List_RAP;
        #endregion
        #region 构造方法
        public Form_RAP()
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
            RAP_Client = (RAPClient)ClientFactory.GetClient(ClientType.Type.RAP);
            List_RAP = SalaryInfoSummery_Client.SelectAllRAP().Where(P => P.WorkRAP_Time.Year == DateTime.Now.Year && P.WorkRAP_Time.Month == DateTime.Now.Month).ToList();

            CB_Action.DisplayMember = "RAP_Name";
            CB_Action.ValueMember = "RAP_ID";
            List<User_RAP> ListRap= RAP_Client.SelectAllRAPs().ToList();
            ListRap.RemoveAt(3);
            CB_Action.DataSource = ListRap;

            LB_User.DisplayMember = "UserName";
            LB_User.ValueMember = "UserId";
            LB_User.DataSource = UserManager_Client.GetAllShops(null, null, ShopID).ToList();


            mark = true;
            BT_Change_Click(null, null);
        }
        #endregion
        #region 事件
        private void LB_RAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mark)
            {
                try
                {
                    DTP_Date.Value = List_RAP.Where(P => P.WorkRAP_ID == ((RAP_ViewModel)LB_RAP.SelectedItem).WorkRAP_ID).FirstOrDefault().WorkRAP_Time;
                }
                catch
                {

                }
                }
        }

        private void LB_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_RAP.DisplayMember = "RAP_Name";
            LB_RAP.ValueMember = "WorkRAP_ID";
            LB_RAP.DataSource = List_RAP.Where(P => P.UserName == ((Shop_ViewModel)LB_User.SelectedItem).UserName.ToString()).ToList();
            TB_RName.Text = UserSummery_Client.SelectUserEXInfo(Guid.Parse(LB_User.SelectedValue.ToString())).User_RealName;
        }
        private void BT_Update_Click(object sender, EventArgs e)
        {
            WorkRAPService.User_WorkRAP model = WorkRAP_Client.SelectWorkRAP_ID((int)LB_RAP.SelectedValue);
            model.WorkRAP_Time = DTP_Date.Value;
            model.WorkRAP_Type = (int)CB_Action.SelectedValue;
            if (WorkRAP_Client.UpdateWorkRAP(model))
            {
                MessageBox.Show("修改成功!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List_RAP = SalaryInfoSummery_Client.SelectAllRAP().Where(P => P.WorkRAP_Time.Year == DateTime.Now.Year && P.WorkRAP_Time.Month == DateTime.Now.Month).ToList();
                LB_User.DataSource = UserManager_Client.GetAllShops(null, null, ShopID).ToList();
            }
            else
            {
                MessageBox.Show("修改失败!请联系管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (WorkRAP_Client.AddWorkRAP(new WorkRAPService.User_WorkRAP()
            {
                WorkRAP_User = Guid.Parse(LB_User.SelectedValue.ToString()),
                WorkRAP_Time = DTP_Date.Value,
                WorkRAP_Type = (int)CB_Action.SelectedValue
            }))
            {
                MessageBox.Show("添加成功!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List_RAP = SalaryInfoSummery_Client.SelectAllRAP().Where(P => P.WorkRAP_Time.Year == DateTime.Now.Year && P.WorkRAP_Time.Month == DateTime.Now.Month).ToList();
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
                this.CB_Action.SelectedIndex = 0;
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
                LB_RAP_SelectedIndexChanged(null, null);
            }
        }
        #endregion

    }
}
