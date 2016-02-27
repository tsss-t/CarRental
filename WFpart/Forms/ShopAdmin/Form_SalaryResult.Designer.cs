namespace WFpart
{
    partial class Form_SalaryResult
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
            this.BT_Canncel = new System.Windows.Forms.Button();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_LastMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Canncel
            // 
            this.BT_Canncel.Location = new System.Drawing.Point(266, 84);
            this.BT_Canncel.Name = "BT_Canncel";
            this.BT_Canncel.Size = new System.Drawing.Size(88, 23);
            this.BT_Canncel.TabIndex = 3;
            this.BT_Canncel.Text = "否";
            this.BT_Canncel.UseVisualStyleBackColor = true;
            this.BT_Canncel.Click += new System.EventHandler(this.BT_Canncel_Click);
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(72, 84);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(89, 23);
            this.BT_Submit.TabIndex = 4;
            this.BT_Submit.Text = "是";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "您是否确认要结算这个月的工资?";
            // 
            // BT_LastMonth
            // 
            this.BT_LastMonth.Location = new System.Drawing.Point(266, 123);
            this.BT_LastMonth.Name = "BT_LastMonth";
            this.BT_LastMonth.Size = new System.Drawing.Size(88, 23);
            this.BT_LastMonth.TabIndex = 4;
            this.BT_LastMonth.Text = "结算上月工资";
            this.BT_LastMonth.UseVisualStyleBackColor = true;
            this.BT_LastMonth.Click += new System.EventHandler(this.BT_LastMonth_Click);
            // 
            // Form_SalaryResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 149);
            this.Controls.Add(this.BT_Canncel);
            this.Controls.Add(this.BT_LastMonth);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SalaryResult";
            this.Text = "工资结算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Canncel;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_LastMonth;

    }
}