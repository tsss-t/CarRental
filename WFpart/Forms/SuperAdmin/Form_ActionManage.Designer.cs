namespace WFpart
{
    partial class Form_ActionManage
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
            this.LB_Action = new System.Windows.Forms.ListBox();
            this.TB_Action = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Action
            // 
            this.LB_Action.FormattingEnabled = true;
            this.LB_Action.ItemHeight = 12;
            this.LB_Action.Location = new System.Drawing.Point(12, 12);
            this.LB_Action.Name = "LB_Action";
            this.LB_Action.Size = new System.Drawing.Size(139, 136);
            this.LB_Action.TabIndex = 0;
            this.LB_Action.SelectedIndexChanged += new System.EventHandler(this.LB_Action_SelectedIndexChanged);
            // 
            // TB_Action
            // 
            this.TB_Action.Location = new System.Drawing.Point(245, 17);
            this.TB_Action.Name = "TB_Action";
            this.TB_Action.Size = new System.Drawing.Size(100, 21);
            this.TB_Action.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "活动名称：";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(245, 44);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(100, 21);
            this.TB_Price.TabIndex = 1;
            this.TB_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "活动优惠：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "元";
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(305, 154);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 4;
            this.BT_Add.Text = "确认添加";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(305, 154);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 5;
            this.BT_Update.Text = "确认删除";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(12, 154);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(139, 23);
            this.BT_Change.TabIndex = 6;
            this.BT_Change.Text = "切换到修改模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "活动详情：";
            // 
            // TB_Info
            // 
            this.TB_Info.Location = new System.Drawing.Point(245, 77);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.Size = new System.Drawing.Size(123, 71);
            this.TB_Info.TabIndex = 1;
            this.TB_Info.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // Form_ActionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 181);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Info);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Action);
            this.Controls.Add(this.LB_Action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ActionManage";
            this.Text = "活动管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Action;
        private System.Windows.Forms.TextBox TB_Action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Info;
    }
}