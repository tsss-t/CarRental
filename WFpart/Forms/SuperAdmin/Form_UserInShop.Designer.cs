namespace WFpart
{
    partial class Form_UserInShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_Province = new System.Windows.Forms.ComboBox();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_User = new System.Windows.Forms.ListBox();
            this.BT_UserSeach = new System.Windows.Forms.Button();
            this.TB_User = new System.Windows.Forms.TextBox();
            this.LB_Shop = new System.Windows.Forms.ListBox();
            this.BT_AddShop = new System.Windows.Forms.Button();
            this.TB_UserInShop = new System.Windows.Forms.TextBox();
            this.BT_DeleteUserFromShop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Province
            // 
            this.CB_Province.FormattingEnabled = true;
            this.CB_Province.Location = new System.Drawing.Point(407, 12);
            this.CB_Province.Name = "CB_Province";
            this.CB_Province.Size = new System.Drawing.Size(121, 20);
            this.CB_Province.TabIndex = 3;
            this.CB_Province.SelectedIndexChanged += new System.EventHandler(this.CB_Province_SelectedIndexChanged);
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(407, 38);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 20);
            this.CB_City.TabIndex = 4;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(360, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "省份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(360, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "城市：";
            // 
            // LB_User
            // 
            this.LB_User.FormattingEnabled = true;
            this.LB_User.ItemHeight = 12;
            this.LB_User.Location = new System.Drawing.Point(15, 85);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(165, 208);
            this.LB_User.TabIndex = 5;
            this.LB_User.SelectedIndexChanged += new System.EventHandler(this.LB_User_SelectedIndexChanged);
            // 
            // BT_UserSeach
            // 
            this.BT_UserSeach.Location = new System.Drawing.Point(105, 44);
            this.BT_UserSeach.Name = "BT_UserSeach";
            this.BT_UserSeach.Size = new System.Drawing.Size(75, 23);
            this.BT_UserSeach.TabIndex = 2;
            this.BT_UserSeach.Text = "用户名搜索";
            this.BT_UserSeach.UseVisualStyleBackColor = true;
            this.BT_UserSeach.Click += new System.EventHandler(this.BT_UserSeach_Click);
            // 
            // TB_User
            // 
            this.TB_User.Location = new System.Drawing.Point(67, 14);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(113, 21);
            this.TB_User.TabIndex = 1;
            this.TB_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_User_KeyDown);
            // 
            // LB_Shop
            // 
            this.LB_Shop.FormattingEnabled = true;
            this.LB_Shop.ItemHeight = 12;
            this.LB_Shop.Location = new System.Drawing.Point(363, 85);
            this.LB_Shop.Name = "LB_Shop";
            this.LB_Shop.Size = new System.Drawing.Size(165, 208);
            this.LB_Shop.TabIndex = 6;
            // 
            // BT_AddShop
            // 
            this.BT_AddShop.Location = new System.Drawing.Point(213, 131);
            this.BT_AddShop.Name = "BT_AddShop";
            this.BT_AddShop.Size = new System.Drawing.Size(120, 56);
            this.BT_AddShop.TabIndex = 7;
            this.BT_AddShop.Text = "—添加到店铺→";
            this.BT_AddShop.UseVisualStyleBackColor = true;
            this.BT_AddShop.Click += new System.EventHandler(this.BT_AddShop_Click);
            // 
            // TB_UserInShop
            // 
            this.TB_UserInShop.Location = new System.Drawing.Point(213, 216);
            this.TB_UserInShop.Name = "TB_UserInShop";
            this.TB_UserInShop.ReadOnly = true;
            this.TB_UserInShop.Size = new System.Drawing.Size(120, 21);
            this.TB_UserInShop.TabIndex = 8;
            // 
            // BT_DeleteUserFromShop
            // 
            this.BT_DeleteUserFromShop.Location = new System.Drawing.Point(209, 243);
            this.BT_DeleteUserFromShop.Name = "BT_DeleteUserFromShop";
            this.BT_DeleteUserFromShop.Size = new System.Drawing.Size(124, 23);
            this.BT_DeleteUserFromShop.TabIndex = 9;
            this.BT_DeleteUserFromShop.Text = "从店铺中删除该成员";
            this.BT_DeleteUserFromShop.UseVisualStyleBackColor = true;
            this.BT_DeleteUserFromShop.Click += new System.EventHandler(this.BT_DeleteUserFromShop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "用户名：";
            // 
            // Form_UserInShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_DeleteUserFromShop);
            this.Controls.Add(this.TB_UserInShop);
            this.Controls.Add(this.BT_AddShop);
            this.Controls.Add(this.TB_User);
            this.Controls.Add(this.BT_UserSeach);
            this.Controls.Add(this.LB_Shop);
            this.Controls.Add(this.LB_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.CB_Province);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_UserInShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户、店铺关系管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Province;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_User;
        private System.Windows.Forms.Button BT_UserSeach;
        private System.Windows.Forms.TextBox TB_User;
        private System.Windows.Forms.ListBox LB_Shop;
        private System.Windows.Forms.Button BT_AddShop;
        private System.Windows.Forms.TextBox TB_UserInShop;
        private System.Windows.Forms.Button BT_DeleteUserFromShop;
        private System.Windows.Forms.Label label3;
    }
}