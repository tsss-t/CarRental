namespace WFpart
{
    partial class Form_ShopManage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.CB_Province = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_ShopName = new System.Windows.Forms.TextBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ShopPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_ShopInfo = new System.Windows.Forms.TextBox();
            this.LB_Shop = new System.Windows.Forms.ListBox();
            this.BT_DeletShop = new System.Windows.Forms.Button();
            this.BT_UpdateShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "城市：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "省份：";
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(73, 44);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 20);
            this.CB_City.TabIndex = 2;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // CB_Province
            // 
            this.CB_Province.FormattingEnabled = true;
            this.CB_Province.Location = new System.Drawing.Point(73, 18);
            this.CB_Province.Name = "CB_Province";
            this.CB_Province.Size = new System.Drawing.Size(121, 20);
            this.CB_Province.TabIndex = 1;
            this.CB_Province.SelectedIndexChanged += new System.EventHandler(this.CB_Province_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "店铺名：";
            // 
            // TB_ShopName
            // 
            this.TB_ShopName.Location = new System.Drawing.Point(73, 76);
            this.TB_ShopName.Name = "TB_ShopName";
            this.TB_ShopName.Size = new System.Drawing.Size(121, 21);
            this.TB_ShopName.TabIndex = 3;
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(12, 259);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 6;
            this.BT_Add.Text = "添加店铺";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "店铺电话：";
            // 
            // TB_ShopPhone
            // 
            this.TB_ShopPhone.Location = new System.Drawing.Point(73, 103);
            this.TB_ShopPhone.Name = "TB_ShopPhone";
            this.TB_ShopPhone.Size = new System.Drawing.Size(121, 21);
            this.TB_ShopPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "店铺描述：";
            // 
            // TB_ShopInfo
            // 
            this.TB_ShopInfo.Location = new System.Drawing.Point(12, 160);
            this.TB_ShopInfo.Multiline = true;
            this.TB_ShopInfo.Name = "TB_ShopInfo";
            this.TB_ShopInfo.Size = new System.Drawing.Size(194, 83);
            this.TB_ShopInfo.TabIndex = 5;
            // 
            // LB_Shop
            // 
            this.LB_Shop.FormattingEnabled = true;
            this.LB_Shop.ItemHeight = 12;
            this.LB_Shop.Location = new System.Drawing.Point(212, 18);
            this.LB_Shop.Name = "LB_Shop";
            this.LB_Shop.Size = new System.Drawing.Size(146, 220);
            this.LB_Shop.TabIndex = 0;
            this.LB_Shop.SelectedIndexChanged += new System.EventHandler(this.LB_Shop_SelectedIndexChanged);
            // 
            // BT_DeletShop
            // 
            this.BT_DeletShop.Location = new System.Drawing.Point(283, 259);
            this.BT_DeletShop.Name = "BT_DeletShop";
            this.BT_DeletShop.Size = new System.Drawing.Size(75, 23);
            this.BT_DeletShop.TabIndex = 8;
            this.BT_DeletShop.Text = "删除店铺";
            this.BT_DeletShop.UseVisualStyleBackColor = true;
            this.BT_DeletShop.Click += new System.EventHandler(this.BT_DeletShop_Click);
            // 
            // BT_UpdateShop
            // 
            this.BT_UpdateShop.Location = new System.Drawing.Point(131, 259);
            this.BT_UpdateShop.Name = "BT_UpdateShop";
            this.BT_UpdateShop.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateShop.TabIndex = 7;
            this.BT_UpdateShop.Text = "修改店铺";
            this.BT_UpdateShop.UseVisualStyleBackColor = true;
            this.BT_UpdateShop.Click += new System.EventHandler(this.BT_UpdateShop_Click);
            // 
            // Form_ShopManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 294);
            this.Controls.Add(this.BT_DeletShop);
            this.Controls.Add(this.LB_Shop);
            this.Controls.Add(this.BT_UpdateShop);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_ShopInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_ShopPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_ShopName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.CB_Province);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ShopManage";
            this.Text = "店铺管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.ComboBox CB_Province;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_ShopName;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ShopPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_ShopInfo;
        private System.Windows.Forms.ListBox LB_Shop;
        private System.Windows.Forms.Button BT_DeletShop;
        private System.Windows.Forms.Button BT_UpdateShop;
    }
}