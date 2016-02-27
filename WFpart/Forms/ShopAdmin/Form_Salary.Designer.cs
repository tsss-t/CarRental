namespace WFpart
{
    partial class Form_Salary
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
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_GetSalary = new System.Windows.Forms.Button();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_SalaryInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Year
            // 
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Location = new System.Drawing.Point(230, 6);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(121, 20);
            this.CB_Year.TabIndex = 0;
            this.CB_Year.SelectedIndexChanged += new System.EventHandler(this.CB_Year_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // BT_GetSalary
            // 
            this.BT_GetSalary.Location = new System.Drawing.Point(461, 219);
            this.BT_GetSalary.Name = "BT_GetSalary";
            this.BT_GetSalary.Size = new System.Drawing.Size(75, 23);
            this.BT_GetSalary.TabIndex = 2;
            this.BT_GetSalary.Text = "领取工资";
            this.BT_GetSalary.UseVisualStyleBackColor = true;
            this.BT_GetSalary.Click += new System.EventHandler(this.BT_GetSalary_Click);
            // 
            // CB_Month
            // 
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Location = new System.Drawing.Point(388, 6);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(121, 20);
            this.CB_Month.TabIndex = 0;
            this.CB_Month.SelectedIndexChanged += new System.EventHandler(this.CB_Month_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(524, 181);
            this.dataGridView1.TabIndex = 4;
            // 
            // BT_SalaryInfo
            // 
            this.BT_SalaryInfo.Location = new System.Drawing.Point(359, 219);
            this.BT_SalaryInfo.Name = "BT_SalaryInfo";
            this.BT_SalaryInfo.Size = new System.Drawing.Size(75, 23);
            this.BT_SalaryInfo.TabIndex = 2;
            this.BT_SalaryInfo.Text = "查询详情";
            this.BT_SalaryInfo.UseVisualStyleBackColor = true;
            this.BT_SalaryInfo.Click += new System.EventHandler(this.BT_SalaryInfo_Click);
            // 
            // Form_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 254);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_SalaryInfo);
            this.Controls.Add(this.BT_GetSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.CB_Year);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Salary";
            this.Text = "工资领取";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_GetSalary;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_SalaryInfo;
    }
}