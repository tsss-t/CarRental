namespace WFpart
{
    partial class Form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PL_Login = new System.Windows.Forms.Panel();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.BT_Login = new System.Windows.Forms.Button();
            this.MS_Admin = new System.Windows.Forms.MenuStrip();
            this.车辆管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ShopVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Salary = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RAP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SalaryAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SalaryResult = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SalaryGet = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Shopper = new System.Windows.Forms.MenuStrip();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OrderManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CarBack = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OverTime = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SuperAdmin = new System.Windows.Forms.MenuStrip();
            this.TSMI_BaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddShop = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddCity = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MemberPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_User = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UserRole = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UserShop = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.活动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddAction = new System.Windows.Forms.ToolStripMenuItem();
            this.资金liuxiangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SelectMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.PL_Login.SuspendLayout();
            this.MS_Admin.SuspendLayout();
            this.MS_Shopper.SuspendLayout();
            this.MS_SuperAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("宋体", 12F);
            this.TB_UserName.Location = new System.Drawing.Point(118, 25);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(146, 26);
            this.TB_UserName.TabIndex = 0;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("宋体", 12F);
            this.TB_Password.Location = new System.Drawing.Point(118, 62);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(146, 26);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "密  码";
            // 
            // PL_Login
            // 
            this.PL_Login.Controls.Add(this.BT_Reset);
            this.PL_Login.Controls.Add(this.BT_Login);
            this.PL_Login.Controls.Add(this.TB_Password);
            this.PL_Login.Controls.Add(this.label3);
            this.PL_Login.Controls.Add(this.TB_UserName);
            this.PL_Login.Controls.Add(this.label2);
            this.PL_Login.Controls.Add(this.label1);
            this.PL_Login.Location = new System.Drawing.Point(307, 460);
            this.PL_Login.Name = "PL_Login";
            this.PL_Login.Size = new System.Drawing.Size(342, 145);
            this.PL_Login.TabIndex = 2;
            // 
            // BT_Reset
            // 
            this.BT_Reset.Font = new System.Drawing.Font("宋体", 10F);
            this.BT_Reset.Location = new System.Drawing.Point(118, 103);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(74, 30);
            this.BT_Reset.TabIndex = 2;
            this.BT_Reset.Text = "重  置";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_Login
            // 
            this.BT_Login.Font = new System.Drawing.Font("宋体", 10F);
            this.BT_Login.Location = new System.Drawing.Point(198, 103);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(66, 30);
            this.BT_Login.TabIndex = 2;
            this.BT_Login.Text = "登  陆";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // MS_Admin
            // 
            this.MS_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆管理ToolStripMenuItem1,
            this.TSMI_Salary});
            this.MS_Admin.Location = new System.Drawing.Point(0, 25);
            this.MS_Admin.Name = "MS_Admin";
            this.MS_Admin.Size = new System.Drawing.Size(1008, 25);
            this.MS_Admin.TabIndex = 3;
            this.MS_Admin.Text = "menuStrip1";
            // 
            // 车辆管理ToolStripMenuItem1
            // 
            this.车辆管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ShopVersion});
            this.车辆管理ToolStripMenuItem1.Name = "车辆管理ToolStripMenuItem1";
            this.车辆管理ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.车辆管理ToolStripMenuItem1.Text = "车辆管理";
            // 
            // TSMI_ShopVersion
            // 
            this.TSMI_ShopVersion.Name = "TSMI_ShopVersion";
            this.TSMI_ShopVersion.Size = new System.Drawing.Size(148, 22);
            this.TSMI_ShopVersion.Text = "本店车辆管理";
            this.TSMI_ShopVersion.Click += new System.EventHandler(this.TSMI_ShopVersion_Click);
            // 
            // TSMI_Salary
            // 
            this.TSMI_Salary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RAP,
            this.TSMI_SalaryAppend,
            this.TSMI_SalaryResult,
            this.TSMI_SalaryGet});
            this.TSMI_Salary.Name = "TSMI_Salary";
            this.TSMI_Salary.Size = new System.Drawing.Size(68, 21);
            this.TSMI_Salary.Text = "工资管理";
            // 
            // TSMI_RAP
            // 
            this.TSMI_RAP.Name = "TSMI_RAP";
            this.TSMI_RAP.Size = new System.Drawing.Size(172, 22);
            this.TSMI_RAP.Text = "员工出勤工资变动";
            this.TSMI_RAP.Click += new System.EventHandler(this.TSMI_RAP_Click);
            // 
            // TSMI_SalaryAppend
            // 
            this.TSMI_SalaryAppend.Name = "TSMI_SalaryAppend";
            this.TSMI_SalaryAppend.Size = new System.Drawing.Size(172, 22);
            this.TSMI_SalaryAppend.Text = "员工特殊工资变动";
            this.TSMI_SalaryAppend.Click += new System.EventHandler(this.TSMI_SalaryAppend_Click);
            // 
            // TSMI_SalaryResult
            // 
            this.TSMI_SalaryResult.Name = "TSMI_SalaryResult";
            this.TSMI_SalaryResult.Size = new System.Drawing.Size(172, 22);
            this.TSMI_SalaryResult.Text = "每月工资结算";
            this.TSMI_SalaryResult.Click += new System.EventHandler(this.TSMI_SalaryResult_Click);
            // 
            // TSMI_SalaryGet
            // 
            this.TSMI_SalaryGet.Name = "TSMI_SalaryGet";
            this.TSMI_SalaryGet.Size = new System.Drawing.Size(172, 22);
            this.TSMI_SalaryGet.Text = "发工资";
            this.TSMI_SalaryGet.Click += new System.EventHandler(this.TSMI_SalaryGet_Click);
            // 
            // MS_Shopper
            // 
            this.MS_Shopper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MS_Shopper.Location = new System.Drawing.Point(0, 0);
            this.MS_Shopper.Name = "MS_Shopper";
            this.MS_Shopper.Size = new System.Drawing.Size(1008, 25);
            this.MS_Shopper.TabIndex = 4;
            this.MS_Shopper.Text = "menuStrip1";
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_OrderManage,
            this.TSMI_CarBack,
            this.TSMI_OverTime});
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.订单管理ToolStripMenuItem.Text = "订单管理";
            // 
            // TSMI_OrderManage
            // 
            this.TSMI_OrderManage.Name = "TSMI_OrderManage";
            this.TSMI_OrderManage.Size = new System.Drawing.Size(182, 22);
            this.TSMI_OrderManage.Text = "订单管理";
            this.TSMI_OrderManage.Click += new System.EventHandler(this.TSMI_OrderManage_Click);
            // 
            // TSMI_CarBack
            // 
            this.TSMI_CarBack.Name = "TSMI_CarBack";
            this.TSMI_CarBack.Size = new System.Drawing.Size(182, 22);
            this.TSMI_CarBack.Text = "订单取消/付款/定金";
            this.TSMI_CarBack.Click += new System.EventHandler(this.TSMI_CarBack_Click);
            // 
            // TSMI_OverTime
            // 
            this.TSMI_OverTime.Name = "TSMI_OverTime";
            this.TSMI_OverTime.Size = new System.Drawing.Size(182, 22);
            this.TSMI_OverTime.Text = "过期订单管理";
            this.TSMI_OverTime.Click += new System.EventHandler(this.TSMI_OverTime_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // MS_SuperAdmin
            // 
            this.MS_SuperAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BaseInfo,
            this.TSMI_User,
            this.车辆管理ToolStripMenuItem,
            this.活动管理ToolStripMenuItem,
            this.资金liuxiangToolStripMenuItem});
            this.MS_SuperAdmin.Location = new System.Drawing.Point(0, 50);
            this.MS_SuperAdmin.Name = "MS_SuperAdmin";
            this.MS_SuperAdmin.Size = new System.Drawing.Size(1008, 25);
            this.MS_SuperAdmin.TabIndex = 6;
            this.MS_SuperAdmin.Text = "menuStrip1";
            // 
            // TSMI_BaseInfo
            // 
            this.TSMI_BaseInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RegUser,
            this.TSMI_AddShop,
            this.TSMI_AddCity,
            this.TSMI_MemberPrice});
            this.TSMI_BaseInfo.Name = "TSMI_BaseInfo";
            this.TSMI_BaseInfo.Size = new System.Drawing.Size(92, 21);
            this.TSMI_BaseInfo.Text = "基本信息管理";
            // 
            // TSMI_RegUser
            // 
            this.TSMI_RegUser.Name = "TSMI_RegUser";
            this.TSMI_RegUser.Size = new System.Drawing.Size(182, 22);
            this.TSMI_RegUser.Text = "用户新建/修改/删除";
            this.TSMI_RegUser.Click += new System.EventHandler(this.TSMI_RegUser_Click);
            // 
            // TSMI_AddShop
            // 
            this.TSMI_AddShop.Name = "TSMI_AddShop";
            this.TSMI_AddShop.Size = new System.Drawing.Size(182, 22);
            this.TSMI_AddShop.Text = "店铺新增/修改/删除";
            this.TSMI_AddShop.Click += new System.EventHandler(this.TSMI_AddShop_Click);
            // 
            // TSMI_AddCity
            // 
            this.TSMI_AddCity.Name = "TSMI_AddCity";
            this.TSMI_AddCity.Size = new System.Drawing.Size(182, 22);
            this.TSMI_AddCity.Text = "城市新增/修改/删除";
            this.TSMI_AddCity.Click += new System.EventHandler(this.TSMI_AddCity_Click);
            // 
            // TSMI_MemberPrice
            // 
            this.TSMI_MemberPrice.Name = "TSMI_MemberPrice";
            this.TSMI_MemberPrice.Size = new System.Drawing.Size(182, 22);
            this.TSMI_MemberPrice.Text = "职务工资管理";
            this.TSMI_MemberPrice.Click += new System.EventHandler(this.TSMI_MemberPrice_Click);
            // 
            // TSMI_User
            // 
            this.TSMI_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UserInfo,
            this.TSMI_UserRole,
            this.TSMI_UserShop});
            this.TSMI_User.Name = "TSMI_User";
            this.TSMI_User.Size = new System.Drawing.Size(92, 21);
            this.TSMI_User.Text = "用户关系管理";
            // 
            // TSMI_UserInfo
            // 
            this.TSMI_UserInfo.Name = "TSMI_UserInfo";
            this.TSMI_UserInfo.Size = new System.Drawing.Size(148, 22);
            this.TSMI_UserInfo.Text = "用户资料管理";
            // 
            // TSMI_UserRole
            // 
            this.TSMI_UserRole.Name = "TSMI_UserRole";
            this.TSMI_UserRole.Size = new System.Drawing.Size(148, 22);
            this.TSMI_UserRole.Text = "用户权限管理";
            this.TSMI_UserRole.Click += new System.EventHandler(this.TSMI_UserRole_Click);
            // 
            // TSMI_UserShop
            // 
            this.TSMI_UserShop.Name = "TSMI_UserShop";
            this.TSMI_UserShop.Size = new System.Drawing.Size(148, 22);
            this.TSMI_UserShop.Text = "用户所属管理";
            this.TSMI_UserShop.Click += new System.EventHandler(this.TSMI_UserShop_Click);
            // 
            // 车辆管理ToolStripMenuItem
            // 
            this.车辆管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AddBrand,
            this.TSMI_AddType,
            this.TSMI_AddVersion});
            this.车辆管理ToolStripMenuItem.Name = "车辆管理ToolStripMenuItem";
            this.车辆管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.车辆管理ToolStripMenuItem.Text = "车辆管理";
            // 
            // TSMI_AddBrand
            // 
            this.TSMI_AddBrand.Name = "TSMI_AddBrand";
            this.TSMI_AddBrand.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AddBrand.Text = "汽车商标管理";
            this.TSMI_AddBrand.Click += new System.EventHandler(this.TSMI_AddBrand_Click);
            // 
            // TSMI_AddType
            // 
            this.TSMI_AddType.Name = "TSMI_AddType";
            this.TSMI_AddType.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AddType.Text = "车辆种类管理";
            this.TSMI_AddType.Click += new System.EventHandler(this.TSMI_AddType_Click);
            // 
            // TSMI_AddVersion
            // 
            this.TSMI_AddVersion.Name = "TSMI_AddVersion";
            this.TSMI_AddVersion.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AddVersion.Text = "车辆型号管理";
            this.TSMI_AddVersion.Click += new System.EventHandler(this.TSMI_AddVersion_Click);
            // 
            // 活动管理ToolStripMenuItem
            // 
            this.活动管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AddAction});
            this.活动管理ToolStripMenuItem.Name = "活动管理ToolStripMenuItem";
            this.活动管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.活动管理ToolStripMenuItem.Text = "活动管理";
            // 
            // TSMI_AddAction
            // 
            this.TSMI_AddAction.Name = "TSMI_AddAction";
            this.TSMI_AddAction.Size = new System.Drawing.Size(124, 22);
            this.TSMI_AddAction.Text = "活动管理";
            this.TSMI_AddAction.Click += new System.EventHandler(this.TSMI_AddAction_Click);
            // 
            // 资金liuxiangToolStripMenuItem
            // 
            this.资金liuxiangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SelectMoney});
            this.资金liuxiangToolStripMenuItem.Name = "资金liuxiangToolStripMenuItem";
            this.资金liuxiangToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.资金liuxiangToolStripMenuItem.Text = "资金流向";
            // 
            // TSMI_SelectMoney
            // 
            this.TSMI_SelectMoney.Name = "TSMI_SelectMoney";
            this.TSMI_SelectMoney.Size = new System.Drawing.Size(148, 22);
            this.TSMI_SelectMoney.Text = "资金流向查询";
            this.TSMI_SelectMoney.Click += new System.EventHandler(this.TSMI_SelectMoney_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 617);
            this.Controls.Add(this.MS_SuperAdmin);
            this.Controls.Add(this.PL_Login);
            this.Controls.Add(this.MS_Admin);
            this.Controls.Add(this.MS_Shopper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MS_Admin;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.Text = "欢迎使用本管理系统";
            this.PL_Login.ResumeLayout(false);
            this.PL_Login.PerformLayout();
            this.MS_Admin.ResumeLayout(false);
            this.MS_Admin.PerformLayout();
            this.MS_Shopper.ResumeLayout(false);
            this.MS_Shopper.PerformLayout();
            this.MS_SuperAdmin.ResumeLayout(false);
            this.MS_SuperAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PL_Login;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.MenuStrip MS_Admin;
        private System.Windows.Forms.MenuStrip MS_Shopper;
        private System.Windows.Forms.MenuStrip MS_SuperAdmin;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BaseInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddShop;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddCity;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RegUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_User;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UserRole;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UserShop;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OrderManage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CarBack;
        private System.Windows.Forms.ToolStripMenuItem 活动管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddAction;
        private System.Windows.Forms.ToolStripMenuItem 车辆管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ShopVersion;
        private System.Windows.Forms.ToolStripMenuItem 车辆管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddBrand;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddType;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddVersion;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Salary;
        private System.Windows.Forms.ToolStripMenuItem 资金liuxiangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SelectMoney;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OverTime;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MemberPrice;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RAP;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SalaryAppend;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SalaryResult;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SalaryGet;
    }
}

