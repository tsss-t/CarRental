namespace WFpart
{
    partial class Form_LoginRole
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
            this.RB_SuperAdmin = new System.Windows.Forms.RadioButton();
            this.RB_Admin = new System.Windows.Forms.RadioButton();
            this.RB_Shopper = new System.Windows.Forms.RadioButton();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RB_SuperAdmin
            // 
            this.RB_SuperAdmin.AutoSize = true;
            this.RB_SuperAdmin.Location = new System.Drawing.Point(96, 67);
            this.RB_SuperAdmin.Name = "RB_SuperAdmin";
            this.RB_SuperAdmin.Size = new System.Drawing.Size(83, 16);
            this.RB_SuperAdmin.TabIndex = 0;
            this.RB_SuperAdmin.TabStop = true;
            this.RB_SuperAdmin.Text = "超级管理员";
            this.RB_SuperAdmin.UseVisualStyleBackColor = true;
            this.RB_SuperAdmin.Visible = false;
            // 
            // RB_Admin
            // 
            this.RB_Admin.AutoSize = true;
            this.RB_Admin.Location = new System.Drawing.Point(96, 89);
            this.RB_Admin.Name = "RB_Admin";
            this.RB_Admin.Size = new System.Drawing.Size(59, 16);
            this.RB_Admin.TabIndex = 1;
            this.RB_Admin.TabStop = true;
            this.RB_Admin.Text = "管理员";
            this.RB_Admin.UseVisualStyleBackColor = true;
            this.RB_Admin.Visible = false;
            // 
            // RB_Shopper
            // 
            this.RB_Shopper.AutoSize = true;
            this.RB_Shopper.Location = new System.Drawing.Point(96, 111);
            this.RB_Shopper.Name = "RB_Shopper";
            this.RB_Shopper.Size = new System.Drawing.Size(71, 16);
            this.RB_Shopper.TabIndex = 2;
            this.RB_Shopper.TabStop = true;
            this.RB_Shopper.Text = "普通员工";
            this.RB_Shopper.UseVisualStyleBackColor = true;
            this.RB_Shopper.Visible = false;
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(96, 149);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 3;
            this.BT_Submit.Text = "确  定";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // Form_LoginRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.RB_Shopper);
            this.Controls.Add(this.RB_Admin);
            this.Controls.Add(this.RB_SuperAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_LoginRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择您的权限";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_SuperAdmin;
        private System.Windows.Forms.RadioButton RB_Admin;
        private System.Windows.Forms.RadioButton RB_Shopper;
        private System.Windows.Forms.Button BT_Submit;
    }
}