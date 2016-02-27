namespace WFpart
{
    partial class Form_PayDeposit
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
            this.LB_Number = new System.Windows.Forms.Label();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.BT_Canncel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_EveryPrice = new System.Windows.Forms.Label();
            this.LB_TotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "定金金额";
            // 
            // LB_Number
            // 
            this.LB_Number.AutoSize = true;
            this.LB_Number.Font = new System.Drawing.Font("宋体", 11F);
            this.LB_Number.Location = new System.Drawing.Point(85, 9);
            this.LB_Number.Name = "LB_Number";
            this.LB_Number.Size = new System.Drawing.Size(55, 15);
            this.LB_Number.TabIndex = 1;
            this.LB_Number.Text = "label2";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(43, 109);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 2;
            this.BT_Submit.Text = "确认支付";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // BT_Canncel
            // 
            this.BT_Canncel.Location = new System.Drawing.Point(149, 109);
            this.BT_Canncel.Name = "BT_Canncel";
            this.BT_Canncel.Size = new System.Drawing.Size(75, 23);
            this.BT_Canncel.TabIndex = 3;
            this.BT_Canncel.Text = "返回";
            this.BT_Canncel.UseVisualStyleBackColor = true;
            this.BT_Canncel.Click += new System.EventHandler(this.BT_Canncel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "预订数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(40, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "总额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(146, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "辆";
            // 
            // LB_EveryPrice
            // 
            this.LB_EveryPrice.AutoSize = true;
            this.LB_EveryPrice.Font = new System.Drawing.Font("宋体", 11F);
            this.LB_EveryPrice.Location = new System.Drawing.Point(85, 36);
            this.LB_EveryPrice.Name = "LB_EveryPrice";
            this.LB_EveryPrice.Size = new System.Drawing.Size(55, 15);
            this.LB_EveryPrice.TabIndex = 1;
            this.LB_EveryPrice.Text = "label2";
            // 
            // LB_TotalPrice
            // 
            this.LB_TotalPrice.AutoSize = true;
            this.LB_TotalPrice.Font = new System.Drawing.Font("宋体", 11F);
            this.LB_TotalPrice.Location = new System.Drawing.Point(85, 67);
            this.LB_TotalPrice.Name = "LB_TotalPrice";
            this.LB_TotalPrice.Size = new System.Drawing.Size(55, 15);
            this.LB_TotalPrice.TabIndex = 1;
            this.LB_TotalPrice.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11F);
            this.label8.Location = new System.Drawing.Point(146, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "元/辆";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(146, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "元";
            // 
            // Form_PayDispot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 145);
            this.Controls.Add(this.BT_Canncel);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.LB_TotalPrice);
            this.Controls.Add(this.LB_EveryPrice);
            this.Controls.Add(this.LB_Number);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Form_PayDispot";
            this.Text = "Form_PayDispot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Number;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Button BT_Canncel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_EveryPrice;
        private System.Windows.Forms.Label LB_TotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}