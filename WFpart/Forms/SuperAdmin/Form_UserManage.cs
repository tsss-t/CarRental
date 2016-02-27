using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserSummeryService;
using WFpart.UserManagerService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月19日16:45:39
 * 编写版本：v0.5
 * */
namespace WFpart
{
    /// <summary>
    /// 用户管理窗体
    /// </summary>
    public partial class Form_UserManage : Form
    {
        #region 预声明变量
        bool Mark = false;
        UserSummeryClient UserSummery_Client;
        UserManagerClient UserManager_Client;
        List<WFpart.UserManagerService.aspnet_UsersEX> List_UserEX;
        List<WFpart.UserManagerService.User_ViewModel> List_User;
        #endregion
        #region 构造方法
        public Form_UserManage()
        {
            InitializeComponent();
            this.Width = 320;
            UserSummery_Client = (UserSummeryClient)ClientFactory.GetClient(ClientType.Type.UserSummery);
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
            List_User = UserManager_Client.SelectUserInfo_All().ToList();
        }
        #endregion
        #region 事件
        #region 添加用户按钮
        /// <summary>
        /// 添加用户按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_AddUser_Click(object sender, EventArgs e)
        {
            if (TB_RealName.Text == "" || TB_UserPhone.Text == "" || TB_UserValidation.Text == "")
            {
                MessageBox.Show("您必须完成所有必填项目！！");
                return;
            }
            else
            {
                if (TB_Password.Text.Length<7)
                {
                    MessageBox.Show("密码长度必须大于7位");
                    return;
                }
                DialogResult res = MessageBox.Show("您确定您要将现在有信息注册到用户？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.OK)
                {
                    if (
                    UserSummery_Client.UserReg(new WFpart.UserSummeryService.User_ViewModel()
                    {
                        UserName = TB_UserName.Text,
                        UserPassword = TB_Password.Text,
                        Email = TB_Email.Text,
                        Answer = TB_Answer.Text,
                        Question = TB_Question.Text
                    },
                    new WFpart.UserSummeryService.aspnet_UsersEX()
                    {
                        User_RealName = TB_RealName.Text,
                        User_Phone = TB_UserPhone.Text,
                        User_Adress = TB_UserAdress.Text,
                        User_Info = TB_UserInfo.Text,
                        User_Validation = TB_UserValidation.Text
                    })
                    )
                    {
                        MessageBox.Show("用户注册成功！");
                        List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
                        List_User = UserManager_Client.SelectUserInfo_All().ToList();
                    }
                    else
                    {
                        MessageBox.Show("用户注册失败！");
                    }
                }
            }
        }
        #endregion
        #region 扩展按钮事件
        /// <summary>
        /// 扩展按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_EX_Click(object sender, EventArgs e)
        {
            if (!Mark)
            {
                this.Width = 590;
                BT_EX.Text = "←添加用户";
                BT_AddUser.Visible = false;
                BT_Delete.Visible = true;
                BT_Update.Visible = true;
                TB_SeachName.Text = "";
                TB_SeachRName.Text = "";
                TB_SearchValidation.Text = "";
                LB_UserName.DataSource = null;
                TB_UserName.ReadOnly = true;
                TB_Email.ReadOnly = true ;
                Mark = true;
            }
            else
            {
                Mark = false;
                this.Width = 320;
                BT_EX.Text = "→搜索并修改用户";
                BT_AddUser.Visible = true;
                BT_Delete.Visible = false;
                BT_Update.Visible = false;
                TB_Answer.Text = "";
                TB_Email.Text = "";
                TB_Password.Text = "";
                TB_Question.Text = "";
                TB_RealName.Text = "";
                TB_UserAdress.Text = "";
                TB_UserInfo.Text = "";
                TB_UserName.Text = "";
                TB_UserPhone.Text = "";
                TB_UserValidation.Text = "";
                TB_UserName.ReadOnly = false ;
                TB_Email.ReadOnly = false;
            }
        }
        #endregion
        #region 查找用户按钮事件
        /// <summary>
        /// 查找用户按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Search_Click(object sender, EventArgs e)
        {
            List<WFpart.UserManagerService.aspnet_UsersEX> List_UserEX_Temp = List_UserEX;
            List<WFpart.UserManagerService.User_ViewModel> List_User_Temp = List_User;
            List<string> List_UserName = new List<string>();
            if (TB_SeachName.Text.Trim() != "")
            {
                List_User_Temp = List_User_Temp.Where(P => P.UserName.Contains(TB_SeachName.Text.Trim())).ToList();
            }
            if (TB_SeachRName.Text.Trim() != "")
            {
                List_UserEX_Temp = List_UserEX_Temp.Where(P => P.User_RealName.Contains(TB_SeachRName.Text.Trim())).ToList();
            }
            if (TB_SearchValidation.Text.Trim() != "")
            {
                List_UserEX_Temp = List_UserEX_Temp.Where(P => P.User_Validation.Contains(TB_SearchValidation.Text.Trim())).ToList();
            }
            foreach (WFpart.UserManagerService.aspnet_UsersEX UserEX_Temp in List_UserEX_Temp)
            {
                foreach (WFpart.UserManagerService.User_ViewModel User_Temp in List_User_Temp)
                {
                    if (UserEX_Temp.User_ID == User_Temp.UserID)
                    {
                        List_UserName.Add(User_Temp.UserName);
                    }
                }
            }
            LB_UserName.DataSource = List_UserName;
            if (List_UserName.Count == 0)
            {
                TB_Answer.Text = "";
                TB_Email.Text = "";
                TB_Password.Text = "";
                TB_Question.Text = "";
                TB_RealName.Text = "";
                TB_UserAdress.Text = "";
                TB_UserInfo.Text = "";
                TB_UserName.Text = "";
                TB_UserPhone.Text = "";
                TB_UserValidation.Text = "";
            }
        }
        #endregion
        #region 更新用户按钮
        private void BT_Update_Click(object sender, EventArgs e)
        {
            if (TB_Password.Text.Length < 7)
            {
                MessageBox.Show("密码长度必须大于7位");
            }
            if (TB_RealName.Text.Trim() == "" || TB_UserPhone.Text.Trim() == "" || TB_UserValidation.Text.Trim() == "")
            {
                MessageBox.Show("您必须完成所有必填项目！！");
            }

            if (TB_Password.Text.Trim() != "为空时保持原来的值")
            {
                UserManager_Client.UserUpdate_NoOldPassword(TB_UserName.Text.Trim(), TB_Password.Text.Trim());
            }

            if (TB_Answer.Text.Trim() != "为空时保持原来的值")
            {
                UserManager_Client.UserAQUpdate_NoOldPassword(TB_UserName.Text.Trim(), TB_Question.Text.Trim(), TB_Answer.Text.Trim());
            }
            Guid UserID = List_User.Where(P => P.UserName == TB_UserName.Text.Trim()).Single().UserID;
            UserManager_Client.UserEXUpdate(new WFpart.UserManagerService.aspnet_UsersEX()
            {
                User_RealName = TB_RealName.Text.Trim(),
                User_Validation = TB_UserValidation.Text.Trim(),
                User_Phone = TB_UserPhone.Text.Trim(),
                User_Adress = TB_UserAdress.Text.Trim(),
                User_Info = TB_UserInfo.Text.Trim(),
                User_ID = UserID
            }
            );
            List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
            List_User = UserManager_Client.SelectUserInfo_All().ToList();
            LB_UserName_SelectedIndexChanged(null, null);
        }
        #endregion
        #region 删除用户按钮
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            DialogResult res=
            MessageBox.Show("您正在试图删除一个用户,该操作是不可逆的,您是否确定要进行此操作?!","警告!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                UserManager_Client.DropUser(TB_UserName.Text.Trim());
            }
            catch
            {
                MessageBox.Show("请先删除其他对该用户的引用！如订单以及各种处理痕迹");
            }
            List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
            List_User = UserManager_Client.SelectUserInfo_All().ToList();
            LB_UserName_SelectedIndexChanged(null, null);
        }
        #endregion
        #region 用户选择框改变事件
        /// <summary>
        /// 用户选择框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_UserName.SelectedIndex < 0)
            {
                return;
            }
            try
            {
                WFpart.UserManagerService.User_ViewModel user = List_User.Where(P => P.UserName == LB_UserName.SelectedItem.ToString()).Single();
                WFpart.UserManagerService.aspnet_UsersEX userEX = List_UserEX.Where(P => P.User_ID == user.UserID).Single();
                TB_Answer.Text = "为空时保持原来的值";
                TB_Password.Text = "为空时保持原来的值";
                TB_Email.Text = user.Email;
                TB_Question.Text = user.Question;
                TB_RealName.Text = userEX.User_RealName;
                TB_UserAdress.Text = userEX.User_Adress;
                TB_UserInfo.Text = userEX.User_Info;
                TB_UserName.Text = user.UserName;
                TB_UserPhone.Text = userEX.User_Phone;
                TB_UserValidation.Text = userEX.User_Validation;
            }
            catch (InvalidOperationException)
            {
                TB_Answer.Text = "";
                TB_Email.Text = "";
                TB_Password.Text = "";
                TB_Question.Text = "";
                TB_RealName.Text = "";
                TB_UserAdress.Text = "";
                TB_UserInfo.Text = "";
                TB_UserName.Text = "";
                TB_UserPhone.Text = "";
                TB_UserValidation.Text = "";
                LB_UserName.DataSource = null;
            }
        }
        #endregion

        #endregion
    }
}
