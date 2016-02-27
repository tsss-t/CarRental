namespace WFpart
{
    partial class Form_SalaryAppend
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
            this.TB_RName = new System.Windows.Forms.TextBox();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Change = new System.Windows.Forms.Button();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_SalaryAppend = new System.Windows.Forms.ListBox();
            this.LB_User = new System.Windows.Forms.ListBox();
            this.TB_Action = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_RName
            // 
            this.TB_RName.Location = new System.Drawing.Point(225, 119);
            this.TB_RName.Name = "TB_RName";
            this.TB_RName.ReadOnly = true;
            this.TB_RName.Size = new System.Drawing.Size(121, 21);
            this.TB_RName.TabIndex = 17;
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(271, 233);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 14;
            this.BT_Update.Text = "确认修改";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(271, 233);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 15;
            this.BT_Add.Text = "确认添加";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(180, 233);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(75, 23);
            this.BT_Change.TabIndex = 16;
            this.BT_Change.Text = "改变模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(225, 196);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(121, 21);
            this.DTP_Date.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "事件：";
            // 
            // LB_SalaryAppend
            // 
            this.LB_SalaryAppend.FormattingEnabled = true;
            this.LB_SalaryAppend.ItemHeight = 12;
            this.LB_SalaryAppend.Location = new System.Drawing.Point(190, 12);
            this.LB_SalaryAppend.Name = "LB_SalaryAppend";
            this.LB_SalaryAppend.Size = new System.Drawing.Size(156, 100);
            this.LB_SalaryAppend.TabIndex = 8;
            this.LB_SalaryAppend.SelectedIndexChanged += new System.EventHandler(this.LB_SalaryAppend_SelectedIndexChanged);
            // 
            // LB_User
            // 
            this.LB_User.FormattingEnabled = true;
            this.LB_User.ItemHeight = 12;
            this.LB_User.Location = new System.Drawing.Point(12, 12);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(156, 244);
            this.LB_User.TabIndex = 9;
            this.LB_User.SelectedIndexChanged += new System.EventHandler(this.LB_User_SelectedIndexChanged);
            // 
            // TB_Action
            // 
            this.TB_Action.Location = new System.Drawing.Point(225, 145);
            this.TB_Action.Name = "TB_Action";
            this.TB_Action.Size = new System.Drawing.Size(121, 21);
            this.TB_Action.TabIndex = 18;
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(225, 172);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(121, 21);
            this.TB_Price.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "金额：";
            // 
            // Form_SalaryAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 270);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Action);
            this.Controls.Add(this.TB_RName);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_SalaryAppend);
            this.Controls.Add(this.LB_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SalaryAppend";
            this.Text = "特殊工资追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_RName;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_SalaryAppend;
        private System.Windows.Forms.ListBox LB_User;
        private System.Windows.Forms.TextBox TB_Action;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label label4;
    }
}