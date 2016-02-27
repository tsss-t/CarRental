namespace WFpart
{
    partial class Form_BrandManage
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
            this.LB_Brand = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_AddBrand = new System.Windows.Forms.Button();
            this.TB_BrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_Pic = new System.Windows.Forms.PictureBox();
            this.TB_BrandInfo = new System.Windows.Forms.TextBox();
            this.PL_AddPic = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_Change = new System.Windows.Forms.Button();
            this.BT_UpdateBrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).BeginInit();
            this.PL_AddPic.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Brand
            // 
            this.LB_Brand.FormattingEnabled = true;
            this.LB_Brand.ItemHeight = 12;
            this.LB_Brand.Location = new System.Drawing.Point(12, 24);
            this.LB_Brand.Name = "LB_Brand";
            this.LB_Brand.Size = new System.Drawing.Size(141, 316);
            this.LB_Brand.TabIndex = 0;
            this.LB_Brand.SelectedIndexChanged += new System.EventHandler(this.LB_Brand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "品牌列表";
            // 
            // BT_AddBrand
            // 
            this.BT_AddBrand.Location = new System.Drawing.Point(311, 353);
            this.BT_AddBrand.Name = "BT_AddBrand";
            this.BT_AddBrand.Size = new System.Drawing.Size(75, 23);
            this.BT_AddBrand.TabIndex = 3;
            this.BT_AddBrand.Text = "添加品牌";
            this.BT_AddBrand.UseVisualStyleBackColor = true;
            this.BT_AddBrand.Click += new System.EventHandler(this.BT_AddBrand_Click);
            // 
            // TB_BrandName
            // 
            this.TB_BrandName.Location = new System.Drawing.Point(224, 22);
            this.TB_BrandName.Name = "TB_BrandName";
            this.TB_BrandName.Size = new System.Drawing.Size(143, 21);
            this.TB_BrandName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "品牌名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "品牌标志:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "品牌说明:";
            // 
            // PB_Pic
            // 
            this.PB_Pic.Location = new System.Drawing.Point(224, 106);
            this.PB_Pic.Name = "PB_Pic";
            this.PB_Pic.Size = new System.Drawing.Size(162, 115);
            this.PB_Pic.TabIndex = 4;
            this.PB_Pic.TabStop = false;
            // 
            // TB_BrandInfo
            // 
            this.TB_BrandInfo.Location = new System.Drawing.Point(224, 236);
            this.TB_BrandInfo.Multiline = true;
            this.TB_BrandInfo.Name = "TB_BrandInfo";
            this.TB_BrandInfo.Size = new System.Drawing.Size(162, 103);
            this.TB_BrandInfo.TabIndex = 2;
            // 
            // PL_AddPic
            // 
            this.PL_AddPic.AllowDrop = true;
            this.PL_AddPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PL_AddPic.Controls.Add(this.label5);
            this.PL_AddPic.Location = new System.Drawing.Point(224, 56);
            this.PL_AddPic.Name = "PL_AddPic";
            this.PL_AddPic.Size = new System.Drawing.Size(161, 44);
            this.PL_AddPic.TabIndex = 6;
            this.PL_AddPic.DragDrop += new System.Windows.Forms.DragEventHandler(this.PL_AddPic_DragDrop);
            this.PL_AddPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.PL_AddPic_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "将图片拖放到此";
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(14, 353);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(139, 23);
            this.BT_Change.TabIndex = 4;
            this.BT_Change.Text = "切换到修改模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // BT_UpdateBrand
            // 
            this.BT_UpdateBrand.Location = new System.Drawing.Point(311, 353);
            this.BT_UpdateBrand.Name = "BT_UpdateBrand";
            this.BT_UpdateBrand.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateBrand.TabIndex = 3;
            this.BT_UpdateBrand.Text = "修改品牌";
            this.BT_UpdateBrand.UseVisualStyleBackColor = true;
            this.BT_UpdateBrand.Click += new System.EventHandler(this.BT_UpdateBrand_Click);
            // 
            // Form_BrandManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 388);
            this.Controls.Add(this.PL_AddPic);
            this.Controls.Add(this.PB_Pic);
            this.Controls.Add(this.TB_BrandInfo);
            this.Controls.Add(this.TB_BrandName);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.BT_UpdateBrand);
            this.Controls.Add(this.BT_AddBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Brand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_BrandManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "品牌管理";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).EndInit();
            this.PL_AddPic.ResumeLayout(false);
            this.PL_AddPic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_AddBrand;
        private System.Windows.Forms.TextBox TB_BrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_Pic;
        private System.Windows.Forms.TextBox TB_BrandInfo;
        private System.Windows.Forms.Panel PL_AddPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.Button BT_UpdateBrand;
    }
}