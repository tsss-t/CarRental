namespace WFpart
{
    partial class Form_UserInRole
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
            this.LB_UserName = new System.Windows.Forms.ListBox();
            this.LB_Role = new System.Windows.Forms.ListBox();
            this.LB_UserInRole = new System.Windows.Forms.ListBox();
            this.BT_UserPutInRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DeleteUserRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_UserName
            // 
            this.LB_UserName.FormattingEnabled = true;
            this.LB_UserName.ItemHeight = 12;
            this.LB_UserName.Location = new System.Drawing.Point(12, 12);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(159, 268);
            this.LB_UserName.TabIndex = 0;
            this.LB_UserName.SelectedIndexChanged += new System.EventHandler(this.LB_UserName_SelectedIndexChanged);
            // 
            // LB_Role
            // 
            this.LB_Role.FormattingEnabled = true;
            this.LB_Role.ItemHeight = 12;
            this.LB_Role.Location = new System.Drawing.Point(400, 12);
            this.LB_Role.Name = "LB_Role";
            this.LB_Role.Size = new System.Drawing.Size(159, 268);
            this.LB_Role.TabIndex = 0;
            // 
            // LB_UserInRole
            // 
            this.LB_UserInRole.FormattingEnabled = true;
            this.LB_UserInRole.ItemHeight = 12;
            this.LB_UserInRole.Location = new System.Drawing.Point(203, 302);
            this.LB_UserInRole.Name = "LB_UserInRole";
            this.LB_UserInRole.Size = new System.Drawing.Size(159, 136);
            this.LB_UserInRole.TabIndex = 0;
            // 
            // BT_UserPutInRole
            // 
            this.BT_UserPutInRole.Location = new System.Drawing.Point(203, 99);
            this.BT_UserPutInRole.Name = "BT_UserPutInRole";
            this.BT_UserPutInRole.Size = new System.Drawing.Size(159, 74);
            this.BT_UserPutInRole.TabIndex = 1;
            this.BT_UserPutInRole.Text = "——添加用户到该角色—→";
            this.BT_UserPutInRole.UseVisualStyleBackColor = true;
            this.BT_UserPutInRole.Click += new System.EventHandler(this.BT_UserPutInRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(200, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "目前该用户的权限：";
            // 
            // BT_DeleteUserRole
            // 
            this.BT_DeleteUserRole.Location = new System.Drawing.Point(400, 390);
            this.BT_DeleteUserRole.Name = "BT_DeleteUserRole";
            this.BT_DeleteUserRole.Size = new System.Drawing.Size(159, 48);
            this.BT_DeleteUserRole.TabIndex = 3;
            this.BT_DeleteUserRole.Text = "←—取消选定权限";
            this.BT_DeleteUserRole.UseVisualStyleBackColor = true;
            this.BT_DeleteUserRole.Click += new System.EventHandler(this.BT_DeleteUserRole_Click);
            // 
            // Form_UserInRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.BT_DeleteUserRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_UserPutInRole);
            this.Controls.Add(this.LB_UserInRole);
            this.Controls.Add(this.LB_Role);
            this.Controls.Add(this.LB_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_UserInRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户角色管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_UserName;
        private System.Windows.Forms.ListBox LB_Role;
        private System.Windows.Forms.ListBox LB_UserInRole;
        private System.Windows.Forms.Button BT_UserPutInRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_DeleteUserRole;
    }
}