namespace WFpart
{
    partial class Form_RAP
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
            this.CB_Action = new System.Windows.Forms.ComboBox();
            this.LB_User = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Change = new System.Windows.Forms.Button();
            this.LB_RAP = new System.Windows.Forms.ListBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_RName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB_Action
            // 
            this.CB_Action.FormattingEnabled = true;
            this.CB_Action.Location = new System.Drawing.Point(225, 170);
            this.CB_Action.Name = "CB_Action";
            this.CB_Action.Size = new System.Drawing.Size(121, 20);
            this.CB_Action.TabIndex = 0;
            // 
            // LB_User
            // 
            this.LB_User.FormattingEnabled = true;
            this.LB_User.ItemHeight = 12;
            this.LB_User.Location = new System.Drawing.Point(12, 12);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(156, 244);
            this.LB_User.TabIndex = 1;
            this.LB_User.SelectedIndexChanged += new System.EventHandler(this.LB_User_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "事件：";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(225, 196);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(121, 21);
            this.DTP_Date.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "时间：";
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(180, 233);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(75, 23);
            this.BT_Change.TabIndex = 5;
            this.BT_Change.Text = "改变模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // LB_RAP
            // 
            this.LB_RAP.FormattingEnabled = true;
            this.LB_RAP.ItemHeight = 12;
            this.LB_RAP.Location = new System.Drawing.Point(190, 12);
            this.LB_RAP.Name = "LB_RAP";
            this.LB_RAP.Size = new System.Drawing.Size(156, 124);
            this.LB_RAP.TabIndex = 1;
            this.LB_RAP.SelectedIndexChanged += new System.EventHandler(this.LB_RAP_SelectedIndexChanged);
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(271, 233);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 5;
            this.BT_Add.Text = "确认添加";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(271, 234);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 5;
            this.BT_Update.Text = "确认修改";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // TB_RName
            // 
            this.TB_RName.Location = new System.Drawing.Point(225, 144);
            this.TB_RName.Name = "TB_RName";
            this.TB_RName.ReadOnly = true;
            this.TB_RName.Size = new System.Drawing.Size(121, 21);
            this.TB_RName.TabIndex = 6;
            // 
            // Form_RAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 269);
            this.Controls.Add(this.TB_RName);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_RAP);
            this.Controls.Add(this.LB_User);
            this.Controls.Add(this.CB_Action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_RAP";
            this.Text = "员工出勤工资管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Action;
        private System.Windows.Forms.ListBox LB_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.ListBox LB_RAP;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_RName;
    }
}