namespace WFpart
{
    partial class Form_VersionManage
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
            this.BT_AddVersion = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Version = new System.Windows.Forms.ListBox();
            this.CB_Province = new System.Windows.Forms.ComboBox();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.CB_Shop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.车辆型号 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.TB_Person = new System.Windows.Forms.TextBox();
            this.TB_PriceNormalRental = new System.Windows.Forms.TextBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.CB_Brand = new System.Windows.Forms.ComboBox();
            this.TB_PriceMemberRental = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_PriceNormalCatch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_PriceMemberCatch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_PriceOver = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TB_BaseKM = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.PL_AddPic = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.PB_Pic = new System.Windows.Forms.PictureBox();
            this.BT_UpdateVersion = new System.Windows.Forms.Button();
            this.BT_Change = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.TB_PriceDeposit = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TB_PriceOverRiding = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TB_PriceRiding = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.PL_AddPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_AddVersion
            // 
            this.BT_AddVersion.Location = new System.Drawing.Point(633, 421);
            this.BT_AddVersion.Name = "BT_AddVersion";
            this.BT_AddVersion.Size = new System.Drawing.Size(75, 23);
            this.BT_AddVersion.TabIndex = 0;
            this.BT_AddVersion.Text = "确认添加";
            this.BT_AddVersion.UseVisualStyleBackColor = true;
            this.BT_AddVersion.Click += new System.EventHandler(this.BT_AddVersion_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(288, 69);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "省份：";
            // 
            // LB_Version
            // 
            this.LB_Version.FormattingEnabled = true;
            this.LB_Version.ItemHeight = 12;
            this.LB_Version.Location = new System.Drawing.Point(14, 69);
            this.LB_Version.Name = "LB_Version";
            this.LB_Version.Size = new System.Drawing.Size(168, 376);
            this.LB_Version.TabIndex = 4;
            this.LB_Version.SelectedIndexChanged += new System.EventHandler(this.LB_Version_SelectedIndexChanged);
            // 
            // CB_Province
            // 
            this.CB_Province.FormattingEnabled = true;
            this.CB_Province.Location = new System.Drawing.Point(59, 12);
            this.CB_Province.Name = "CB_Province";
            this.CB_Province.Size = new System.Drawing.Size(121, 20);
            this.CB_Province.TabIndex = 1;
            this.CB_Province.SelectedIndexChanged += new System.EventHandler(this.CB_Province_SelectedIndexChanged);
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(267, 12);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(121, 20);
            this.CB_City.TabIndex = 2;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            // 
            // CB_Shop
            // 
            this.CB_Shop.FormattingEnabled = true;
            this.CB_Shop.Location = new System.Drawing.Point(529, 12);
            this.CB_Shop.Name = "CB_Shop";
            this.CB_Shop.Size = new System.Drawing.Size(121, 20);
            this.CB_Shop.TabIndex = 3;
            this.CB_Shop.SelectedIndexChanged += new System.EventHandler(this.CB_Shop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "城市：";
            // 
            // 车辆型号
            // 
            this.车辆型号.AutoSize = true;
            this.车辆型号.Location = new System.Drawing.Point(217, 153);
            this.车辆型号.Name = "车辆型号";
            this.车辆型号.Size = new System.Drawing.Size(65, 12);
            this.车辆型号.TabIndex = 2;
            this.车辆型号.Text = "车辆类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "店铺：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "车辆型号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "车辆数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "车辆载员：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "车辆品牌：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "会员租金：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "一般租金：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "会员接送费用：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "人";
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(288, 96);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(100, 21);
            this.TB_Count.TabIndex = 6;
            this.TB_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Person
            // 
            this.TB_Person.Location = new System.Drawing.Point(288, 123);
            this.TB_Person.Name = "TB_Person";
            this.TB_Person.Size = new System.Drawing.Size(100, 21);
            this.TB_Person.TabIndex = 7;
            this.TB_Person.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_PriceNormalRental
            // 
            this.TB_PriceNormalRental.Location = new System.Drawing.Point(550, 66);
            this.TB_PriceNormalRental.Name = "TB_PriceNormalRental";
            this.TB_PriceNormalRental.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceNormalRental.TabIndex = 12;
            this.TB_PriceNormalRental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(288, 150);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(100, 20);
            this.CB_Type.TabIndex = 8;
            // 
            // CB_Brand
            // 
            this.CB_Brand.FormattingEnabled = true;
            this.CB_Brand.Location = new System.Drawing.Point(288, 176);
            this.CB_Brand.Name = "CB_Brand";
            this.CB_Brand.Size = new System.Drawing.Size(100, 20);
            this.CB_Brand.TabIndex = 9;
            // 
            // TB_PriceMemberRental
            // 
            this.TB_PriceMemberRental.Location = new System.Drawing.Point(550, 93);
            this.TB_PriceMemberRental.Name = "TB_PriceMemberRental";
            this.TB_PriceMemberRental.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceMemberRental.TabIndex = 13;
            this.TB_PriceMemberRental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "/天";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(656, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "/天";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "辆";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(455, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "一般接送费用：";
            // 
            // TB_PriceNormalCatch
            // 
            this.TB_PriceNormalCatch.Location = new System.Drawing.Point(550, 120);
            this.TB_PriceNormalCatch.Name = "TB_PriceNormalCatch";
            this.TB_PriceNormalCatch.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceNormalCatch.TabIndex = 14;
            this.TB_PriceNormalCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(656, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "/趟";
            // 
            // TB_PriceMemberCatch
            // 
            this.TB_PriceMemberCatch.Location = new System.Drawing.Point(550, 147);
            this.TB_PriceMemberCatch.Name = "TB_PriceMemberCatch";
            this.TB_PriceMemberCatch.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceMemberCatch.TabIndex = 15;
            this.TB_PriceMemberCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(656, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "/趟";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(455, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "自驾超程费用：";
            // 
            // TB_PriceOver
            // 
            this.TB_PriceOver.Location = new System.Drawing.Point(550, 201);
            this.TB_PriceOver.Name = "TB_PriceOver";
            this.TB_PriceOver.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceOver.TabIndex = 17;
            this.TB_PriceOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(656, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "/公里";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(455, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "基本行驶里程：";
            // 
            // TB_BaseKM
            // 
            this.TB_BaseKM.Location = new System.Drawing.Point(550, 174);
            this.TB_BaseKM.Name = "TB_BaseKM";
            this.TB_BaseKM.Size = new System.Drawing.Size(100, 21);
            this.TB_BaseKM.TabIndex = 16;
            this.TB_BaseKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(656, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "公里";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "店铺拥有车辆类型：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(479, 263);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "车型说明：";
            // 
            // TB_Info
            // 
            this.TB_Info.Location = new System.Drawing.Point(481, 278);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.Size = new System.Drawing.Size(227, 137);
            this.TB_Info.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(216, 291);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "车型照片：";
            // 
            // PL_AddPic
            // 
            this.PL_AddPic.AllowDrop = true;
            this.PL_AddPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PL_AddPic.Controls.Add(this.label25);
            this.PL_AddPic.Location = new System.Drawing.Point(287, 263);
            this.PL_AddPic.Name = "PL_AddPic";
            this.PL_AddPic.Size = new System.Drawing.Size(162, 44);
            this.PL_AddPic.TabIndex = 7;
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
            this.label25.TabIndex = 6;
            this.label25.Text = "将图片拖放到此";
            // 
            // PB_Pic
            // 
            this.PB_Pic.Location = new System.Drawing.Point(219, 313);
            this.PB_Pic.Name = "PB_Pic";
            this.PB_Pic.Size = new System.Drawing.Size(230, 102);
            this.PB_Pic.TabIndex = 8;
            this.PB_Pic.TabStop = false;
            // 
            // BT_UpdateVersion
            // 
            this.BT_UpdateVersion.Location = new System.Drawing.Point(633, 421);
            this.BT_UpdateVersion.Name = "BT_UpdateVersion";
            this.BT_UpdateVersion.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateVersion.TabIndex = 20;
            this.BT_UpdateVersion.Text = "确认修改";
            this.BT_UpdateVersion.UseVisualStyleBackColor = true;
            this.BT_UpdateVersion.Click += new System.EventHandler(this.BT_UpdateVersion_Click);
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(219, 421);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(192, 23);
            this.BT_Change.TabIndex = 21;
            this.BT_Change.Text = "切换到修改模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(241, 205);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "押金：";
            // 
            // TB_PriceDeposit
            // 
            this.TB_PriceDeposit.Location = new System.Drawing.Point(288, 202);
            this.TB_PriceDeposit.Name = "TB_PriceDeposit";
            this.TB_PriceDeposit.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceDeposit.TabIndex = 10;
            this.TB_PriceDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(455, 231);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "代驾超程费用：";
            // 
            // TB_PriceOverRiding
            // 
            this.TB_PriceOverRiding.Location = new System.Drawing.Point(550, 228);
            this.TB_PriceOverRiding.Name = "TB_PriceOverRiding";
            this.TB_PriceOverRiding.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceOverRiding.TabIndex = 18;
            this.TB_PriceOverRiding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(656, 231);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "/公里";
            // 
            // TB_PriceRiding
            // 
            this.TB_PriceRiding.Location = new System.Drawing.Point(287, 228);
            this.TB_PriceRiding.Name = "TB_PriceRiding";
            this.TB_PriceRiding.Size = new System.Drawing.Size(100, 21);
            this.TB_PriceRiding.TabIndex = 11;
            this.TB_PriceRiding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(228, 231);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "代驾费：";
            // 
            // Form_VersionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 451);
            this.Controls.Add(this.PB_Pic);
            this.Controls.Add(this.PL_AddPic);
            this.Controls.Add(this.CB_Brand);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.CB_Shop);
            this.Controls.Add(this.CB_City);
            this.Controls.Add(this.CB_Province);
            this.Controls.Add(this.LB_Version);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "Form_VersionManage";
            this.Text = "车辆型号管理";
            this.PL_AddPic.ResumeLayout(false);
            this.PL_AddPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_AddVersion;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Version;
        private System.Windows.Forms.ComboBox CB_Province;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.ComboBox CB_Shop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 车辆型号;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.TextBox TB_Person;
        private System.Windows.Forms.TextBox TB_PriceNormalRental;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.ComboBox CB_Brand;
        private System.Windows.Forms.TextBox TB_PriceMemberRental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_PriceNormalCatch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_PriceMemberCatch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_PriceOver;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TB_BaseKM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel PL_AddPic;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox PB_Pic;
        private System.Windows.Forms.Button BT_UpdateVersion;
        private System.Windows.Forms.Button BT_Change;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TB_PriceDeposit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TB_PriceOverRiding;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox TB_PriceRiding;
        private System.Windows.Forms.Label label29;
    }
}