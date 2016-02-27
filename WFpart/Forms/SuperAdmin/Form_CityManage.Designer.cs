namespace WFpart
{
    partial class Form_CityManage
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
            this.BT_DeletCity = new System.Windows.Forms.Button();
            this.LB_City = new System.Windows.Forms.ListBox();
            this.BT_AddCity = new System.Windows.Forms.Button();
            this.TB_CityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Province = new System.Windows.Forms.ComboBox();
            this.BT_UpdateCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_DeletCity
            // 
            this.BT_DeletCity.Location = new System.Drawing.Point(209, 192);
            this.BT_DeletCity.Name = "BT_DeletCity";
            this.BT_DeletCity.Size = new System.Drawing.Size(75, 23);
            this.BT_DeletCity.TabIndex = 5;
            this.BT_DeletCity.Text = "删除城市";
            this.BT_DeletCity.UseVisualStyleBackColor = true;
            this.BT_DeletCity.Click += new System.EventHandler(this.BT_DeletCity_Click);
            // 
            // LB_City
            // 
            this.LB_City.FormattingEnabled = true;
            this.LB_City.ItemHeight = 12;
            this.LB_City.Location = new System.Drawing.Point(29, 79);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(165, 136);
            this.LB_City.TabIndex = 2;
            this.LB_City.SelectedIndexChanged += new System.EventHandler(this.LB_City_SelectedIndexChanged);
            // 
            // BT_AddCity
            // 
            this.BT_AddCity.Location = new System.Drawing.Point(209, 37);
            this.BT_AddCity.Name = "BT_AddCity";
            this.BT_AddCity.Size = new System.Drawing.Size(75, 23);
            this.BT_AddCity.TabIndex = 3;
            this.BT_AddCity.Text = "添加城市";
            this.BT_AddCity.UseVisualStyleBackColor = true;
            this.BT_AddCity.Click += new System.EventHandler(this.BT_AddCity_Click);
            // 
            // TB_CityName
            // 
            this.TB_CityName.Location = new System.Drawing.Point(73, 39);
            this.TB_CityName.Name = "TB_CityName";
            this.TB_CityName.Size = new System.Drawing.Size(121, 21);
            this.TB_CityName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "城市：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "省份：";
            // 
            // CB_Province
            // 
            this.CB_Province.FormattingEnabled = true;
            this.CB_Province.Location = new System.Drawing.Point(73, 13);
            this.CB_Province.Name = "CB_Province";
            this.CB_Province.Size = new System.Drawing.Size(121, 20);
            this.CB_Province.TabIndex = 0;
            this.CB_Province.SelectedIndexChanged += new System.EventHandler(this.CB_Province_SelectedIndexChanged);
            // 
            // BT_UpdateCity
            // 
            this.BT_UpdateCity.Location = new System.Drawing.Point(209, 113);
            this.BT_UpdateCity.Name = "BT_UpdateCity";
            this.BT_UpdateCity.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateCity.TabIndex = 4;
            this.BT_UpdateCity.Text = "修改城市";
            this.BT_UpdateCity.UseVisualStyleBackColor = true;
            this.BT_UpdateCity.Click += new System.EventHandler(this.BT_UpdateCity_Click);
            // 
            // Form_CityManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 247);
            this.Controls.Add(this.BT_UpdateCity);
            this.Controls.Add(this.BT_DeletCity);
            this.Controls.Add(this.LB_City);
            this.Controls.Add(this.BT_AddCity);
            this.Controls.Add(this.TB_CityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Province);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_CityManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "城市信息管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_DeletCity;
        private System.Windows.Forms.ListBox LB_City;
        private System.Windows.Forms.Button BT_AddCity;
        private System.Windows.Forms.TextBox TB_CityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Province;
        private System.Windows.Forms.Button BT_UpdateCity;
    }
}