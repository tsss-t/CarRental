namespace WFpart
{
    partial class Form_SalaryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SalaryInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.PL_Salary = new System.Windows.Forms.TableLayoutPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.BT_ViewPrint = new System.Windows.Forms.Button();
            this.BT_SetPrint = new System.Windows.Forms.Button();
            this.BT_Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(807, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本工资";
            this.label1.Visible = false;
            // 
            // PL_Salary
            // 
            this.PL_Salary.ColumnCount = 2;
            this.PL_Salary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PL_Salary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PL_Salary.Dock = System.Windows.Forms.DockStyle.Left;
            this.PL_Salary.Location = new System.Drawing.Point(0, 0);
            this.PL_Salary.Name = "PL_Salary";
            this.PL_Salary.RowCount = 2;
            this.PL_Salary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01478F));
            this.PL_Salary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98522F));
            this.PL_Salary.Size = new System.Drawing.Size(200, 406);
            this.PL_Salary.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BT_ViewPrint
            // 
            this.BT_ViewPrint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_ViewPrint.Location = new System.Drawing.Point(263, 78);
            this.BT_ViewPrint.Name = "BT_ViewPrint";
            this.BT_ViewPrint.Size = new System.Drawing.Size(112, 60);
            this.BT_ViewPrint.TabIndex = 2;
            this.BT_ViewPrint.Text = "打印预览";
            this.BT_ViewPrint.UseVisualStyleBackColor = true;
            this.BT_ViewPrint.Click += new System.EventHandler(this.BT_ViewPrint_Click);
            // 
            // BT_SetPrint
            // 
            this.BT_SetPrint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_SetPrint.Location = new System.Drawing.Point(263, 12);
            this.BT_SetPrint.Name = "BT_SetPrint";
            this.BT_SetPrint.Size = new System.Drawing.Size(112, 60);
            this.BT_SetPrint.TabIndex = 2;
            this.BT_SetPrint.Text = "打印设置";
            this.BT_SetPrint.UseVisualStyleBackColor = true;
            this.BT_SetPrint.Click += new System.EventHandler(this.BT_SetPrint_Click);
            // 
            // BT_Print
            // 
            this.BT_Print.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_Print.Location = new System.Drawing.Point(263, 144);
            this.BT_Print.Name = "BT_Print";
            this.BT_Print.Size = new System.Drawing.Size(112, 60);
            this.BT_Print.TabIndex = 2;
            this.BT_Print.Text = "打印";
            this.BT_Print.UseVisualStyleBackColor = true;
            this.BT_Print.Click += new System.EventHandler(this.BT_Print_Click);
            // 
            // Form_SalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 406);
            this.Controls.Add(this.BT_Print);
            this.Controls.Add(this.BT_SetPrint);
            this.Controls.Add(this.BT_ViewPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PL_Salary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SalaryInfo";
            this.Text = "工资明细";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel PL_Salary;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button BT_ViewPrint;
        private System.Windows.Forms.Button BT_SetPrint;
        private System.Windows.Forms.Button BT_Print;
    }
}