namespace WFpart
{
    partial class Form_UserSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Role = new System.Windows.Forms.ListBox();
            this.TB_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(82, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "工资：";
            // 
            // LB_Role
            // 
            this.LB_Role.FormattingEnabled = true;
            this.LB_Role.ItemHeight = 12;
            this.LB_Role.Location = new System.Drawing.Point(85, 42);
            this.LB_Role.Name = "LB_Role";
            this.LB_Role.Size = new System.Drawing.Size(165, 100);
            this.LB_Role.TabIndex = 5;
            this.LB_Role.SelectedIndexChanged += new System.EventHandler(this.LB_Role_SelectedIndexChanged);
            // 
            // TB_Salary
            // 
            this.TB_Salary.Location = new System.Drawing.Point(130, 148);
            this.TB_Salary.Name = "TB_Salary";
            this.TB_Salary.Size = new System.Drawing.Size(120, 21);
            this.TB_Salary.TabIndex = 8;
            this.TB_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(82, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "职务：";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(175, 175);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 11;
            this.BT_Submit.Text = "确认修改";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // Form_UserSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 204);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Salary);
            this.Controls.Add(this.LB_Role);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_UserSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "职务工资管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Role;
        private System.Windows.Forms.TextBox TB_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Submit;
    }
}