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
/*
 * 编写人：杜天行
 * 编写时间：2012年4月16日21:04:47
 * 编写版本：v0.5
 * */
namespace WFpart
{
    
    public partial class Form_UserInRole : Form
    {
        UserManagerClient UserManager_Client;
        #region 构造方法
        public Form_UserInRole()
        {
            InitializeComponent();
            UserManager_Client =(UserManagerClient) ClientFactory.GetClient(ClientType.Type.UserManager);
            LB_UserNameComplet();
            LB_UserName_SelectedIndexChanged(null, null);
            LB_RoleComplet();
        }
        #endregion
        #region 辅助绑定方法
        /// <summary>
        /// 角色ListBox绑定
        /// </summary>
        private void LB_RoleComplet()
        {
            LB_Role.DataSource = UserManager_Client.RoleSelectAll().ToList().Except(UserManager_Client.RoleSelect_UserName(LB_UserName.SelectedItem.ToString())).ToList() ;
        }
        /// <summary>
        /// 用户ListBox绑定
        /// </summary>
        private void LB_UserNameComplet()
        {
            LB_UserName.DataSource = UserManager_Client.UserSelectAll();
        }

        #endregion
        #region 事件
        #region 添加权限按钮事件
        /// <summary>
        /// 添加权限按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_UserPutInRole_Click(object sender, EventArgs e)
        {
            if (UserManager_Client.UserPutInRole(LB_UserName.SelectedItem.ToString(), LB_Role.SelectedItem.ToString()))
            {
                MessageBox.Show("添加用户权限成功！");
            }
            else
            {
                MessageBox.Show("添加用户权限失败！");
            }
            LB_UserName_SelectedIndexChanged(null, null);
        }
        #endregion
        #region 删除用户权限按钮
        /// <summary>
        /// 删除用户权限按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_DeleteUserRole_Click(object sender, EventArgs e)
        {
            UserManager_Client.RoleUserDelete(LB_UserName.SelectedItem.ToString(), LB_UserInRole.SelectedItem.ToString());
            LB_UserName_SelectedIndexChanged(null, null);
        }
        #endregion
        #region 用户ListBox改变之后触发事件
        /// <summary>
        /// 用户ListBox改变之后触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_UserInRole.DataSource = UserManager_Client.RoleSelect_UserName(LB_UserName.SelectedItem.ToString());
            LB_RoleComplet();
        }
        #endregion
        #endregion
    }
}
