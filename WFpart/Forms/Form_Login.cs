using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using System.ServiceModel.Security;
using WFpart.UserSummeryService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月15日22:28:35
 * 更新时间：2012年4月23日19:54:44
 * 编写版本：v0.9
 * */
namespace WFpart
{
    /// <summary>
    /// 登陆&主窗体
    /// </summary>
    public partial class Form_Login : Form
    {
        #region 预申明变量
        UserSummeryClient UserSummery_Client;
        UserNamePasswordClientCredential UNPCC_UserSummery;

        UserManagerClient UserManager_Client;
        UserNamePasswordClientCredential UNPCC_UserManager;
        #endregion
        #region 构造方法
        public Form_Login()
        {
            InitializeComponent();
            MS_Admin.Visible = false;
            MS_Shopper.Visible = false;
            MS_SuperAdmin.Visible = false;
        }
        #endregion
        #region 按钮方法
        #region 重置按钮
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Reset_Click(object sender, EventArgs e)
        {
            TB_UserName.Text = null;
            TB_Password.Text = null;
        }
        #endregion
        #region 登陆按钮
        /// <summary>
        /// 登陆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Login_Click(object sender, EventArgs e)
        {

            UserSummery_Client = new UserSummeryClient();
            UNPCC_UserSummery = UserSummery_Client.ClientCredentials.UserName;
            UNPCC_UserSummery.UserName = TB_UserName.Text;
            UNPCC_UserSummery.Password = TB_Password.Text;
            try
            {
                GlobalParams.UserID = Guid.Parse(UserSummery_Client.UserLogOn(TB_UserName.Text, TB_Password.Text));
                GlobalParams.UserName = TB_UserName.Text;
                GlobalParams.Password = TB_Password.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("账号或密码错误，请检查拼写");
                return;
            }
            UserManager_Client = new UserManagerClient();
            UNPCC_UserManager = UserManager_Client.ClientCredentials.UserName;
            UNPCC_UserManager.UserName = GlobalParams.UserName;
            UNPCC_UserManager.Password = GlobalParams.Password;
            ClientFactory.AddClient<UserManagerClient>(ClientType.Type.UserManager, UserManager_Client);
            List<String> List_Role = UserManager_Client.RoleSelect_UserName(GlobalParams.UserName).ToList();
            GlobalParams.ShopID = UserManager_Client.SelectShopID_UserID(GlobalParams.UserID);

            if (List_Role.Count != 0)
            {
                bool mark = false;
                foreach (String rolename in List_Role)
                {
                    if (rolename == "普通员工" || rolename == "管理员" || rolename == "超级管理员")
                    {
                        mark = true;
                        continue;
                    }
                }
                if (mark)
                {
                    Form_LoginRole form = new Form_LoginRole(List_Role);
                    form.Owner = this;
                    form.OnSave += new Form_LoginRole.Save(Show_Work);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("您的账号不适用于操作本系统!!!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
            }
            else
            {
                Show_Work(List_Role.First());
            }
            //UserSummery_Client.UserReg(
            //new User_ViewModel() 
            //{ UserName = "dutianhang",
            //    UserPassword="1989410",
            //    Question="what's my name?",
            //    Answer="dutianhang",
            //    Email="644362532@qq.com" 
            //},
            //new aspnet_UsersEX() 
            //{User_RealName="杜天行",
            //    User_Validation="51390119900410021x",
            //    User_Phone="13882821913",
            //    User_Adress="no have" });
        }
        #endregion
        #region 登陆窗口的键盘提交方式
        private void TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Login_Click(null, null);
            }
        }
        #endregion

        #region 窗体
        #region 1.店员权限
        #region 下订单窗体
        private void TSMI_OrderManage_Click(object sender, EventArgs e)
        {
            Form_OrderManage form = new Form_OrderManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 订单付款/取消窗体
        private void TSMI_CarBack_Click(object sender, EventArgs e)
        {
            Form_SelectOrder form = new Form_SelectOrder();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 过期订单管理
        private void TSMI_OverTime_Click(object sender, EventArgs e)
        {
            Form_Delete form = new Form_Delete();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion 
        #endregion
        #region 2.店铺管理员权限
        #region 店铺车辆管理窗体
        private void TSMI_ShopVersion_Click(object sender, EventArgs e)
        {
            Form_ShopVerison form = new Form_ShopVerison();
            form.Owner = this;
            try
            {
                form.ShowDialog();
            }
            catch { }
        }
        #endregion
        #region 工资模块
        private void TSMI_RAP_Click(object sender, EventArgs e)
        {
            Form_RAP form = new Form_RAP();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TSMI_SalaryAppend_Click(object sender, EventArgs e)
        {
            Form_SalaryAppend form = new Form_SalaryAppend();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TSMI_SalaryResult_Click(object sender, EventArgs e)
        {
            Form_SalaryResult form = new Form_SalaryResult();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TSMI_SalaryGet_Click(object sender, EventArgs e)
        {
            Form_Salary form = new Form_Salary();
            form.Owner = this;
            form.ShowDialog();
        }

        #endregion
        #endregion
        #region 3.超级管理员权限
        #region 用户权限管理窗体
        private void TSMI_UserRole_Click(object sender, EventArgs e)
        {
            Form_UserInRole form = new Form_UserInRole();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 用户店铺关系窗体
        private void TSMI_UserShop_Click(object sender, EventArgs e)
        {
            Form_UserInShop form = new Form_UserInShop();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加、删除、修改店铺窗体
        private void TSMI_AddShop_Click(object sender, EventArgs e)
        {
            Form_ShopManage form = new Form_ShopManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加、删除、修改城市窗体
        private void TSMI_AddCity_Click(object sender, EventArgs e)
        {
            Form_CityManage form = new Form_CityManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加、删除、修改用户窗体
        /// <summary>
        /// 添加、删除、修改用户窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_RegUser_Click(object sender, EventArgs e)
        {
            Form_UserManage form = new Form_UserManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加、修改汽车品牌窗体
        /// <summary>
        ///添加汽车品牌窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_AddBrand_Click(object sender, EventArgs e)
        {
            Form_BrandManage form = new Form_BrandManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加、修改汽车分类窗体
        private void TSMI_AddType_Click(object sender, EventArgs e)
        {
            Form_CarTypeManage form = new Form_CarTypeManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 添加汽车类型窗体
        private void TSMI_AddVersion_Click(object sender, EventArgs e)
        {
            Form_VersionManage form = new Form_VersionManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 活动管理窗体
        private void TSMI_AddAction_Click(object sender, EventArgs e)
        {
            Form_ActionManage form = new Form_ActionManage();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #region 资金流动报表窗体
        private void TSMI_SelectMoney_Click(object sender, EventArgs e)
        {
            Form_Money form = new Form_Money();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #endregion

        #endregion
        #endregion
        #region 辅助方法
        #region 模式更改方法
        /// <summary>
        /// 模式更改方法
        /// </summary>
        /// <param name="RoleName">角色名称</param>
        public void Show_Work(String RoleName)
        {
            if (RoleName == "普通员工")
            {
                MS_Shopper.Visible = true;
            }
            else if (RoleName == "管理员")
            {
                MS_Admin.Visible = true;
            }
            else if (RoleName == "超级管理员")
            {
                MS_SuperAdmin.Visible = true;
            }
            else
            {
                MessageBox.Show("您的账号不支持该系统，谢谢您的使用，再见！");
                this.Close();
            }
            this.Text += "               模式：" + RoleName;
            PL_Login.Visible = false;
        }
        #endregion

        private void TSMI_MemberPrice_Click(object sender, EventArgs e)
        {
            Form_UserSalary from = new Form_UserSalary();
            from.Owner = this;
            from.ShowDialog();
        }



        #endregion

        
    }
}
