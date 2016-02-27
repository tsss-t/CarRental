using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFpart
{
    public partial class Form_LoginRole : Form
    {
        public delegate void Save(String Role);
        public event Save OnSave;
        public Form_LoginRole(List<String> List_Role)
        {
            InitializeComponent();
            foreach(string role in List_Role)
            {
                if (role == "普通员工")
                {
                    RB_Shopper.Visible = true;
                }
                else if (role == "管理员")
                {
                    RB_Admin.Visible = true;
                }
                else if (role == "超级管理员")
                {
                    RB_SuperAdmin.Visible = true;
                }

            }
            MessageBox.Show("您的身份含有多个管理权限，请选择您要进行登陆的权限");
        }

        public void BT_Submit_Click(object sender, EventArgs e)
        {
            String Role=null;
            if(RB_Shopper.Checked)
            {
                Role="普通员工";
            }
            else if(RB_Admin.Checked)
            {
                Role="管理员";
            }
            else if (RB_SuperAdmin.Checked)
            {
                Role="超级管理员";
            }
            this.Close();
            OnSave(Role);
        }
    }
}
