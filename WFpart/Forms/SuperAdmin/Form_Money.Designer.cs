namespace WFpart
{
    partial class Form_Money
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.CB_Day = new System.Windows.Forms.ComboBox();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.Pic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.CB_Shop = new System.Windows.Forms.ComboBox();
            this.CB_Province = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Month
            // 
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Location = new System.Drawing.Point(255, 43);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(121, 20);
            this.CB_Month.TabIndex = 5;
            this.CB_Month.SelectedIndexChanged += new System.EventHandler(this.CB_Month_SelectedIndexChanged);
            // 
            // CB_Day
            // 
            this.CB_Day.FormattingEnabled = true;
            this.CB_Day.Location = new System.Drawing.Point(454, 40);
            this.CB_Day.Name = "CB_Day";
            this.CB_Day.Size = new System.Drawing.Size(121, 20);
            this.CB_Day.TabIndex = 6;
            this.CB_Day.SelectedIndexChanged += new System.EventHandler(this.CB_Day_SelectedIndexChanged);
            // 
            // CB_Year
            // 
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Location = new System.Drawing.Point(56, 43);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(121, 20);
            this.CB_Year.TabIndex = 4;
            this.CB_Year.SelectedIndexChanged += new System.EventHandler(this.CB_Year_SelectedIndexChanged);
            // 
            // Pic
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.AxisX2.Title = "fdf";
            chartArea2.Name = "ChartArea1";
            this.Pic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Pic.Legends.Add(legend2);
            this.Pic.Location = new System.Drawing.Point(12, 81);
            this.Pic.Name = "Pic";
            this.Pic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Yellow;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "交易额";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.Pic.Series.Add(series2);
            this.Pic.Size = new System.Drawing.Size(589, 262);
            this.Pic.TabIndex = 3;
            this.Pic.Text = "chart1";
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(255, 12);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 20);
            this.CB_City.TabIndex = 2;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // CB_Shop
            // 
            this.CB_Shop.FormattingEnabled = true;
            this.CB_Shop.Location = new System.Drawing.Point(454, 12);
            this.CB_Shop.Name = "CB_Shop";
            this.CB_Shop.Size = new System.Drawing.Size(121, 20);
            this.CB_Shop.TabIndex = 3;
            this.CB_Shop.SelectedIndexChanged += new System.EventHandler(this.CB_Shop_SelectedIndexChanged);
            // 
            // CB_Province
            // 
            this.CB_Province.FormattingEnabled = true;
            this.CB_Province.Location = new System.Drawing.Point(56, 12);
            this.CB_Province.Name = "CB_Province";
            this.CB_Province.Size = new System.Drawing.Size(121, 20);
            this.CB_Province.TabIndex = 1;
            this.CB_Province.SelectedIndexChanged += new System.EventHandler(this.CB_Province_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "省份:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "城市:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "日:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "年:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "月:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "店铺:";
            // 
            // Form_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.CB_Province);
            this.Controls.Add(this.CB_Year);
            this.Controls.Add(this.CB_Shop);
            this.Controls.Add(this.CB_Day);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.CB_Month);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Money";
            this.Text = "资金流向查询";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.ComboBox CB_Day;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.DataVisualization.Charting.Chart Pic;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.ComboBox CB_Shop;
        private System.Windows.Forms.ComboBox CB_Province;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}