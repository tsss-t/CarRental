namespace WFpart
{
    partial class Form_ShopVerison
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
            this.PB_Pic = new System.Windows.Forms.PictureBox();
            this.PL_AddPic = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.CB_Brand = new System.Windows.Forms.ComboBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.LB_Version = new System.Windows.Forms.ListBox();
            this.车辆型号 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_BaseKM = new System.Windows.Forms.TextBox();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.TB_PriceRiding = new System.Windows.Forms.TextBox();
            this.TB_PriceDeposit = new System.Windows.Forms.TextBox();
            this.TB_PriceOverRiding = new System.Windows.Forms.TextBox();
            this.TB_PriceOver = new System.Windows.Forms.TextBox();
            this.TB_PriceMemberCatch = new System.Windows.Forms.TextBox();
            this.TB_PriceNormalCatch = new System.Windows.Forms.TextBox();
            this.TB_PriceMemberRental = new System.Windows.Forms.TextBox();
            this.TB_PriceNormalRental = new System.Windows.Forms.TextBox();
            this.TB_Person = new System.Windows.Forms.TextBox();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BT_Change = new System.Windows.Forms.Button();
            this.BT_UpdateVersion = new System.Windows.Forms.Button();
            this.BT_AddVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).BeginInit();
            this.PL_AddPic.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Pic
            // 
            this.PB_Pic.Location = new System.Drawing.Point(216, 267);
            this.PB_Pic.Name = "PB_Pic";
            this.PB_Pic.Size = new System.Drawing.Size(230, 102);
            this.PB_Pic.TabIndex = 55;
            this.PB_Pic.TabStop = false;
            // 
            // PL_AddPic
            // 
            this.PL_AddPic.AllowDrop = true;
            this.PL_AddPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PL_AddPic.Controls.Add(this.label25);
            this.PL_AddPic.Location = new System.Drawing.Point(284, 217);
            this.PL_AddPic.Name = "PL_AddPic";
            this.PL_AddPic.Size = new System.Drawing.Size(162, 44);
            this.PL_AddPic.TabIndex = 99;
            this.PL_AddPic.DragDrop += new System.Windows.Forms.DragEventHandler(this.PL_AddPic_DragDrop);
            this.PL_AddPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.PL_AddPic_DragEnter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(3, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 21);
            this.label25.TabIndex = 99;
            this.label25.Text = "将图片拖放到此";
            // 
            // CB_Brand
            // 
            this.CB_Brand.FormattingEnabled = true;
            this.CB_Brand.Location = new System.Drawing.Point(285, 130);
            this.CB_Brand.Name = "CB_Brand";
            this.CB_Brand.Size = new System.Drawing.Size(100, 20);
            this.CB_Brand.TabIndex = 5;
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(285, 104);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(100, 20);
            this.CB_Type.TabIndex = 4;
            // 
            // LB_Version
            // 
            this.LB_Version.FormattingEnabled = true;
            this.LB_Version.ItemHeight = 12;
            this.LB_Version.Location = new System.Drawing.Point(11, 23);
            this.LB_Version.Name = "LB_Version";
            this.LB_Version.Size = new System.Drawing.Size(168, 376);
            this.LB_Version.TabIndex = 51;
            this.LB_Version.SelectedIndexChanged += new System.EventHandler(this.LB_Version_SelectedIndexChanged);
            // 
            // 车辆型号
            // 
            this.车辆型号.AutoSize = true;
            this.车辆型号.Location = new System.Drawing.Point(214, 107);
            this.车辆型号.Name = "车辆型号";
            this.车辆型号.Size = new System.Drawing.Size(65, 12);
            this.车辆型号.TabIndex = 39;
            this.车辆型号.Text = "车辆类型：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(653, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "/天";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "/天";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "辆";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "人";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(452, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "一般接送费用：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(653, 131);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 33;
            this.label21.Text = "公里";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(653, 185);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 36;
            this.label28.Text = "/公里";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(653, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 35;
            this.label19.Text = "/公里";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(653, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 48;
            this.label17.Text = "/趟";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(653, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 47;
            this.label16.Text = "/趟";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(452, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 50;
            this.label20.Text = "基本行驶里程：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(213, 245);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 49;
            this.label24.Text = "车型照片：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(476, 217);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 46;
            this.label23.Text = "车型说明：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(225, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 43;
            this.label29.Text = "代驾费：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(238, 159);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 42;
            this.label26.Text = "押金：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(452, 185);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 12);
            this.label27.TabIndex = 45;
            this.label27.Text = "代驾超程费用：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(452, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 12);
            this.label18.TabIndex = 44;
            this.label18.Text = "自驾超程费用：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "会员接送费用：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "一般租金：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "会员租金：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "车辆品牌：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "车辆载员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "车辆数量：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 12);
            this.label22.TabIndex = 30;
            this.label22.Text = "店铺拥有车辆类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "车辆型号：";
            // 
            // TB_BaseKM
            // 
            this.TB_BaseKM.Location = new System.Drawing.Point(547, 128);
            this.TB_BaseKM.Name = "TB_BaseKM";
            this.TB_BaseKM.Size = new System.Drawing.Size(100, 21);
            this.TB_BaseKM.TabIndex = 12;
            this.TB_BaseKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Info
            // 
            this.TB_Info.Location = new System.Drawing.Point(478, 232);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.Size = new System.Drawing.Size(227, 137);
            this.TB_Info.TabIndex = 15;
            // 
            // TB_PriceRiding
            // 
            this.TB_PriceRiding.Location = new System.Drawing.Point(284, 182);
            this.TB_PriceRiding.Name = "TB_PriceRiding";
            this.TB_PriceRiding.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceRiding.TabIndex = 7;
            this.TB_PriceRiding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceDeposit
            // 
            this.TB_PriceDeposit.Location = new System.Drawing.Point(285, 156);
            this.TB_PriceDeposit.Name = "TB_PriceDeposit";
            this.TB_PriceDeposit.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceDeposit.TabIndex = 6;
            this.TB_PriceDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceOverRiding
            // 
            this.TB_PriceOverRiding.Location = new System.Drawing.Point(547, 182);
            this.TB_PriceOverRiding.Name = "TB_PriceOverRiding";
            this.TB_PriceOverRiding.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceOverRiding.TabIndex = 14;
            this.TB_PriceOverRiding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceOver
            // 
            this.TB_PriceOver.Location = new System.Drawing.Point(547, 155);
            this.TB_PriceOver.Name = "TB_PriceOver";
            this.TB_PriceOver.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceOver.TabIndex = 13;
            this.TB_PriceOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceMemberCatch
            // 
            this.TB_PriceMemberCatch.Location = new System.Drawing.Point(547, 101);
            this.TB_PriceMemberCatch.Name = "TB_PriceMemberCatch";
            this.TB_PriceMemberCatch.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceMemberCatch.TabIndex = 11;
            this.TB_PriceMemberCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceNormalCatch
            // 
            this.TB_PriceNormalCatch.Location = new System.Drawing.Point(547, 74);
            this.TB_PriceNormalCatch.Name = "TB_PriceNormalCatch";
            this.TB_PriceNormalCatch.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceNormalCatch.TabIndex = 10;
            this.TB_PriceNormalCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceMemberRental
            // 
            this.TB_PriceMemberRental.Location = new System.Drawing.Point(547, 47);
            this.TB_PriceMemberRental.Name = "TB_PriceMemberRental";
            this.TB_PriceMemberRental.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceMemberRental.TabIndex = 9;
            this.TB_PriceMemberRental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceNormalRental
            // 
            this.TB_PriceNormalRental.Location = new System.Drawing.Point(547, 20);
            this.TB_PriceNormalRental.Name = "TB_PriceNormalRental";
            this.TB_PriceNormalRental.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceNormalRental.TabIndex = 8;
            this.TB_PriceNormalRental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Person
            // 
            this.TB_Person.Location = new System.Drawing.Point(285, 77);
            this.TB_Person.Name = "TB_Person";
            this.TB_Person.Size = new System.Drawing.Size(100, 21);
            this.TB_Person.TabIndex = 3;
            this.TB_Person.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(285, 50);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(100, 21);
            this.TB_Count.TabIndex = 2;
            this.TB_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(285, 23);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 1;
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(216, 375);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(192, 23);
            this.BT_Change.TabIndex = 16;
            this.BT_Change.Text = "切换到修改模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // BT_UpdateVersion
            // 
            this.BT_UpdateVersion.Location = new System.Drawing.Point(630, 374);
            this.BT_UpdateVersion.Name = "BT_UpdateVersion";
            this.BT_UpdateVersion.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateVersion.TabIndex = 15;
            this.BT_UpdateVersion.Text = "确认修改";
            this.BT_UpdateVersion.UseVisualStyleBackColor = true;
            this.BT_UpdateVersion.Click += new System.EventHandler(this.BT_UpdateVersion_Click);
            // 
            // BT_AddVersion
            // 
            this.BT_AddVersion.Location = new System.Drawing.Point(630, 375);
            this.BT_AddVersion.Name = "BT_AddVersion";
            this.BT_AddVersion.Size = new System.Drawing.Size(75, 23);
            this.BT_AddVersion.TabIndex = 11;
            this.BT_AddVersion.Text = "确认添加";
            this.BT_AddVersion.UseVisualStyleBackColor = true;
            this.BT_AddVersion.Click += new System.EventHandler(this.BT_AddVersion_Click);
            // 
            // Form_ShopVerison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 409);
            this.Controls.Add(this.PB_Pic);
            this.Controls.Add(this.PL_AddPic);
            this.Controls.Add(this.CB_Brand);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.LB_Version);
            this.Controls.Add(this.车辆型号);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_BaseKM);
            this.Controls.Add(this.TB_Info);
            this.Controls.Add(this.TB_PriceRiding);
            this.Controls.Add(this.TB_PriceDeposit);
            this.Controls.Add(this.TB_PriceOverRiding);
            this.Controls.Add(this.TB_PriceOver);
            this.Controls.Add(this.TB_PriceMemberCatch);
            this.Controls.Add(this.TB_PriceNormalCatch);
            this.Controls.Add(this.TB_PriceMemberRental);
            this.Controls.Add(this.TB_PriceNormalRental);
            this.Controls.Add(this.TB_Person);
            this.Controls.Add(this.TB_Count);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.BT_UpdateVersion);
            this.Controls.Add(this.BT_AddVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ShopVerison";
            this.Text = "本店车型管理";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).EndInit();
            this.PL_AddPic.ResumeLayout(false);
            this.PL_AddPic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Pic;
        private System.Windows.Forms.Panel PL_AddPic;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox CB_Brand;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.ListBox LB_Version;
        private System.Windows.Forms.Label 车辆型号;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_BaseKM;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.TextBox TB_PriceRiding;
        private System.Windows.Forms.TextBox TB_PriceDeposit;
        private System.Windows.Forms.TextBox TB_PriceOverRiding;
        private System.Windows.Forms.TextBox TB_PriceOver;
        private System.Windows.Forms.TextBox TB_PriceMemberCatch;
        private System.Windows.Forms.TextBox TB_PriceNormalCatch;
        private System.Windows.Forms.TextBox TB_PriceMemberRental;
        private System.Windows.Forms.TextBox TB_PriceNormalRental;
        private System.Windows.Forms.TextBox TB_Person;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.Button BT_UpdateVersion;
        private System.Windows.Forms.Button BT_AddVersion;
    }
}