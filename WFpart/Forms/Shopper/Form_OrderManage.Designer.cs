namespace WFpart
{
    partial class Form_OrderManage
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
            this.LB_User = new System.Windows.Forms.ListBox();
            this.LB_Version = new System.Windows.Forms.ListBox();
            this.RB_NewUser = new System.Windows.Forms.RadioButton();
            this.RB_OldUser = new System.Windows.Forms.RadioButton();
            this.PL_OldUser = new System.Windows.Forms.Panel();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.BT_SeachSub = new System.Windows.Forms.Button();
            this.BT_Search = new System.Windows.Forms.Button();
            this.TB_SearchRealName = new System.Windows.Forms.TextBox();
            this.TB_SearchUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_SearchValidation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PL_NewUser = new System.Windows.Forms.Panel();
            this.BT_Sub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.TB_Adress = new System.Windows.Forms.TextBox();
            this.TB_Validation = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_RealName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PL_UserResult = new System.Windows.Forms.Panel();
            this.Label_Adress = new System.Windows.Forms.Label();
            this.Label_Validation = new System.Windows.Forms.Label();
            this.Label_Info = new System.Windows.Forms.TextBox();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BT_SeachVersion = new System.Windows.Forms.Button();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TM_Start = new System.Windows.Forms.DateTimePicker();
            this.TM_Back = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CB_Action = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.RB_Self = new System.Windows.Forms.RadioButton();
            this.RB_Other = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RB_OtherGet = new System.Windows.Forms.RadioButton();
            this.RB_SelfGet = new System.Windows.Forms.RadioButton();
            this.BT_AddOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Label_User = new System.Windows.Forms.Label();
            this.PL_OldUser.SuspendLayout();
            this.PL_NewUser.SuspendLayout();
            this.PL_UserResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_User
            // 
            this.LB_User.FormattingEnabled = true;
            this.LB_User.ItemHeight = 12;
            this.LB_User.Location = new System.Drawing.Point(7, 119);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(199, 160);
            this.LB_User.TabIndex = 0;
            // 
            // LB_Version
            // 
            this.LB_Version.FormattingEnabled = true;
            this.LB_Version.ItemHeight = 12;
            this.LB_Version.Location = new System.Drawing.Point(211, 9);
            this.LB_Version.Name = "LB_Version";
            this.LB_Version.Size = new System.Drawing.Size(225, 280);
            this.LB_Version.TabIndex = 0;
            // 
            // RB_NewUser
            // 
            this.RB_NewUser.AutoSize = true;
            this.RB_NewUser.Location = new System.Drawing.Point(12, 12);
            this.RB_NewUser.Name = "RB_NewUser";
            this.RB_NewUser.Size = new System.Drawing.Size(59, 16);
            this.RB_NewUser.TabIndex = 1;
            this.RB_NewUser.Text = "新用户";
            this.RB_NewUser.UseVisualStyleBackColor = true;
            // 
            // RB_OldUser
            // 
            this.RB_OldUser.AutoSize = true;
            this.RB_OldUser.Checked = true;
            this.RB_OldUser.Location = new System.Drawing.Point(77, 12);
            this.RB_OldUser.Name = "RB_OldUser";
            this.RB_OldUser.Size = new System.Drawing.Size(59, 16);
            this.RB_OldUser.TabIndex = 2;
            this.RB_OldUser.TabStop = true;
            this.RB_OldUser.Text = "老用户";
            this.RB_OldUser.UseVisualStyleBackColor = true;
            this.RB_OldUser.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // PL_OldUser
            // 
            this.PL_OldUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PL_OldUser.Controls.Add(this.BT_Reset);
            this.PL_OldUser.Controls.Add(this.BT_SeachSub);
            this.PL_OldUser.Controls.Add(this.BT_Search);
            this.PL_OldUser.Controls.Add(this.TB_SearchRealName);
            this.PL_OldUser.Controls.Add(this.TB_SearchUserName);
            this.PL_OldUser.Controls.Add(this.label3);
            this.PL_OldUser.Controls.Add(this.label4);
            this.PL_OldUser.Controls.Add(this.TB_SearchValidation);
            this.PL_OldUser.Controls.Add(this.label5);
            this.PL_OldUser.Controls.Add(this.LB_User);
            this.PL_OldUser.Location = new System.Drawing.Point(12, 34);
            this.PL_OldUser.Name = "PL_OldUser";
            this.PL_OldUser.Size = new System.Drawing.Size(220, 316);
            this.PL_OldUser.TabIndex = 3;
            // 
            // BT_Reset
            // 
            this.BT_Reset.Location = new System.Drawing.Point(7, 92);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(75, 23);
            this.BT_Reset.TabIndex = 12;
            this.BT_Reset.Text = "重    置";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_SeachSub
            // 
            this.BT_SeachSub.Location = new System.Drawing.Point(131, 286);
            this.BT_SeachSub.Name = "BT_SeachSub";
            this.BT_SeachSub.Size = new System.Drawing.Size(75, 23);
            this.BT_SeachSub.TabIndex = 11;
            this.BT_SeachSub.Text = "确定选取";
            this.BT_SeachSub.UseVisualStyleBackColor = true;
            this.BT_SeachSub.Click += new System.EventHandler(this.BT_SeachSub_Click);
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(131, 92);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 10;
            this.BT_Search.Text = "模糊搜索";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // TB_SearchRealName
            // 
            this.TB_SearchRealName.Location = new System.Drawing.Point(65, 41);
            this.TB_SearchRealName.Name = "TB_SearchRealName";
            this.TB_SearchRealName.Size = new System.Drawing.Size(141, 21);
            this.TB_SearchRealName.TabIndex = 9;
            // 
            // TB_SearchUserName
            // 
            this.TB_SearchUserName.Location = new System.Drawing.Point(65, 14);
            this.TB_SearchUserName.Name = "TB_SearchUserName";
            this.TB_SearchUserName.Size = new System.Drawing.Size(141, 21);
            this.TB_SearchUserName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "账户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "真实姓名：";
            // 
            // TB_SearchValidation
            // 
            this.TB_SearchValidation.Location = new System.Drawing.Point(65, 65);
            this.TB_SearchValidation.Name = "TB_SearchValidation";
            this.TB_SearchValidation.Size = new System.Drawing.Size(141, 21);
            this.TB_SearchValidation.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "身份证号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "真实姓名：";
            // 
            // PL_NewUser
            // 
            this.PL_NewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PL_NewUser.Controls.Add(this.BT_Sub);
            this.PL_NewUser.Controls.Add(this.label2);
            this.PL_NewUser.Controls.Add(this.TB_Info);
            this.PL_NewUser.Controls.Add(this.TB_Adress);
            this.PL_NewUser.Controls.Add(this.TB_Validation);
            this.PL_NewUser.Controls.Add(this.TB_Phone);
            this.PL_NewUser.Controls.Add(this.TB_RealName);
            this.PL_NewUser.Controls.Add(this.label1);
            this.PL_NewUser.Controls.Add(this.label7);
            this.PL_NewUser.Controls.Add(this.label8);
            this.PL_NewUser.Controls.Add(this.label6);
            this.PL_NewUser.Location = new System.Drawing.Point(12, 33);
            this.PL_NewUser.Name = "PL_NewUser";
            this.PL_NewUser.Size = new System.Drawing.Size(224, 316);
            this.PL_NewUser.TabIndex = 4;
            // 
            // BT_Sub
            // 
            this.BT_Sub.Location = new System.Drawing.Point(125, 286);
            this.BT_Sub.Name = "BT_Sub";
            this.BT_Sub.Size = new System.Drawing.Size(75, 23);
            this.BT_Sub.TabIndex = 10;
            this.BT_Sub.Text = "提    交";
            this.BT_Sub.UseVisualStyleBackColor = true;
            this.BT_Sub.Click += new System.EventHandler(this.BT_Sub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话号码：";
            // 
            // TB_Info
            // 
            this.TB_Info.Location = new System.Drawing.Point(9, 134);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.Size = new System.Drawing.Size(201, 145);
            this.TB_Info.TabIndex = 9;
            // 
            // TB_Adress
            // 
            this.TB_Adress.Location = new System.Drawing.Point(69, 92);
            this.TB_Adress.Name = "TB_Adress";
            this.TB_Adress.Size = new System.Drawing.Size(141, 21);
            this.TB_Adress.TabIndex = 9;
            // 
            // TB_Validation
            // 
            this.TB_Validation.Location = new System.Drawing.Point(69, 65);
            this.TB_Validation.Name = "TB_Validation";
            this.TB_Validation.Size = new System.Drawing.Size(141, 21);
            this.TB_Validation.TabIndex = 9;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(69, 41);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(141, 21);
            this.TB_Phone.TabIndex = 9;
            // 
            // TB_RealName
            // 
            this.TB_RealName.Location = new System.Drawing.Point(69, 14);
            this.TB_RealName.Name = "TB_RealName";
            this.TB_RealName.Size = new System.Drawing.Size(141, 21);
            this.TB_RealName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "身份证号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "备注信息：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "家庭地址：";
            // 
            // PL_UserResult
            // 
            this.PL_UserResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PL_UserResult.Controls.Add(this.Label_Adress);
            this.PL_UserResult.Controls.Add(this.Label_Validation);
            this.PL_UserResult.Controls.Add(this.Label_Info);
            this.PL_UserResult.Controls.Add(this.Label_Phone);
            this.PL_UserResult.Controls.Add(this.Label_User);
            this.PL_UserResult.Controls.Add(this.Label_UserName);
            this.PL_UserResult.Controls.Add(this.label9);
            this.PL_UserResult.Controls.Add(this.label22);
            this.PL_UserResult.Controls.Add(this.label10);
            this.PL_UserResult.Controls.Add(this.label11);
            this.PL_UserResult.Controls.Add(this.label12);
            this.PL_UserResult.Controls.Add(this.label13);
            this.PL_UserResult.Location = new System.Drawing.Point(12, 33);
            this.PL_UserResult.Name = "PL_UserResult";
            this.PL_UserResult.Size = new System.Drawing.Size(224, 316);
            this.PL_UserResult.TabIndex = 4;
            // 
            // Label_Adress
            // 
            this.Label_Adress.AutoSize = true;
            this.Label_Adress.Location = new System.Drawing.Point(79, 114);
            this.Label_Adress.Name = "Label_Adress";
            this.Label_Adress.Size = new System.Drawing.Size(47, 12);
            this.Label_Adress.TabIndex = 5;
            this.Label_Adress.Text = "label14";
            // 
            // Label_Validation
            // 
            this.Label_Validation.AutoSize = true;
            this.Label_Validation.Location = new System.Drawing.Point(79, 87);
            this.Label_Validation.Name = "Label_Validation";
            this.Label_Validation.Size = new System.Drawing.Size(47, 12);
            this.Label_Validation.TabIndex = 5;
            this.Label_Validation.Text = "label14";
            // 
            // Label_Info
            // 
            this.Label_Info.Location = new System.Drawing.Point(9, 157);
            this.Label_Info.Multiline = true;
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.ReadOnly = true;
            this.Label_Info.Size = new System.Drawing.Size(201, 122);
            this.Label_Info.TabIndex = 9;
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Location = new System.Drawing.Point(79, 63);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(47, 12);
            this.Label_Phone.TabIndex = 5;
            this.Label_Phone.Text = "label14";
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(78, 41);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(47, 12);
            this.Label_UserName.TabIndex = 5;
            this.Label_UserName.Text = "label14";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "电话号码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "真实姓名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "身份证号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "备注信息：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "家庭地址：";
            // 
            // BT_SeachVersion
            // 
            this.BT_SeachVersion.Location = new System.Drawing.Point(211, 319);
            this.BT_SeachVersion.Name = "BT_SeachVersion";
            this.BT_SeachVersion.Size = new System.Drawing.Size(99, 23);
            this.BT_SeachVersion.TabIndex = 5;
            this.BT_SeachVersion.Text = "查看车型详情";
            this.BT_SeachVersion.UseVisualStyleBackColor = true;
            this.BT_SeachVersion.Click += new System.EventHandler(this.BT_SeachVersion_Click);
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(69, 7);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(135, 20);
            this.CB_Type.TabIndex = 6;
            this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "车辆分类：";
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(69, 91);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(135, 21);
            this.TB_Count.TabIndex = 9;
            this.TB_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "租借数量：";
            // 
            // TM_Start
            // 
            this.TM_Start.Location = new System.Drawing.Point(69, 118);
            this.TM_Start.Name = "TM_Start";
            this.TM_Start.Size = new System.Drawing.Size(136, 21);
            this.TM_Start.TabIndex = 11;
            // 
            // TM_Back
            // 
            this.TM_Back.Location = new System.Drawing.Point(69, 145);
            this.TM_Back.Name = "TM_Back";
            this.TM_Back.Size = new System.Drawing.Size(136, 21);
            this.TM_Back.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "起始时间：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 10;
            this.label18.Text = "退还时间：";
            // 
            // CB_Action
            // 
            this.CB_Action.FormattingEnabled = true;
            this.CB_Action.Location = new System.Drawing.Point(69, 172);
            this.CB_Action.Name = "CB_Action";
            this.CB_Action.Size = new System.Drawing.Size(135, 20);
            this.CB_Action.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "参加活动：";
            // 
            // RB_Self
            // 
            this.RB_Self.AutoSize = true;
            this.RB_Self.Checked = true;
            this.RB_Self.Location = new System.Drawing.Point(9, 3);
            this.RB_Self.Name = "RB_Self";
            this.RB_Self.Size = new System.Drawing.Size(47, 16);
            this.RB_Self.TabIndex = 13;
            this.RB_Self.TabStop = true;
            this.RB_Self.Text = "自驾";
            this.RB_Self.UseVisualStyleBackColor = true;
            // 
            // RB_Other
            // 
            this.RB_Other.AutoSize = true;
            this.RB_Other.Location = new System.Drawing.Point(62, 3);
            this.RB_Other.Name = "RB_Other";
            this.RB_Other.Size = new System.Drawing.Size(47, 16);
            this.RB_Other.TabIndex = 14;
            this.RB_Other.Text = "代驾";
            this.RB_Other.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BT_AddOrder);
            this.panel1.Controls.Add(this.BT_SeachVersion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CB_Action);
            this.panel1.Controls.Add(this.CB_Type);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.LB_Version);
            this.panel1.Controls.Add(this.TM_Back);
            this.panel1.Controls.Add(this.TB_Message);
            this.panel1.Controls.Add(this.TB_Count);
            this.panel1.Controls.Add(this.TM_Start);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(254, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 347);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RB_OtherGet);
            this.panel3.Controls.Add(this.RB_SelfGet);
            this.panel3.Location = new System.Drawing.Point(66, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 23);
            this.panel3.TabIndex = 16;
            // 
            // RB_OtherGet
            // 
            this.RB_OtherGet.AutoSize = true;
            this.RB_OtherGet.Location = new System.Drawing.Point(62, 3);
            this.RB_OtherGet.Name = "RB_OtherGet";
            this.RB_OtherGet.Size = new System.Drawing.Size(47, 16);
            this.RB_OtherGet.TabIndex = 14;
            this.RB_OtherGet.Text = "接送";
            this.RB_OtherGet.UseVisualStyleBackColor = true;
            // 
            // RB_SelfGet
            // 
            this.RB_SelfGet.AutoSize = true;
            this.RB_SelfGet.Checked = true;
            this.RB_SelfGet.Location = new System.Drawing.Point(9, 3);
            this.RB_SelfGet.Name = "RB_SelfGet";
            this.RB_SelfGet.Size = new System.Drawing.Size(47, 16);
            this.RB_SelfGet.TabIndex = 13;
            this.RB_SelfGet.TabStop = true;
            this.RB_SelfGet.Text = "自提";
            this.RB_SelfGet.UseVisualStyleBackColor = true;
            // 
            // BT_AddOrder
            // 
            this.BT_AddOrder.Location = new System.Drawing.Point(337, 319);
            this.BT_AddOrder.Name = "BT_AddOrder";
            this.BT_AddOrder.Size = new System.Drawing.Size(99, 23);
            this.BT_AddOrder.TabIndex = 5;
            this.BT_AddOrder.Text = "提交订单";
            this.BT_AddOrder.UseVisualStyleBackColor = true;
            this.BT_AddOrder.Click += new System.EventHandler(this.BT_AddOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RB_Other);
            this.panel2.Controls.Add(this.RB_Self);
            this.panel2.Location = new System.Drawing.Point(65, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 23);
            this.panel2.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "提车方案：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 7;
            this.label20.Text = "驾车方案：";
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(7, 219);
            this.TB_Message.Multiline = true;
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(199, 94);
            this.TB_Message.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "备注：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "账户名：";
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Location = new System.Drawing.Point(78, 17);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(47, 12);
            this.Label_User.TabIndex = 5;
            this.Label_User.Text = "label14";
            // 
            // Form_OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PL_UserResult);
            this.Controls.Add(this.PL_NewUser);
            this.Controls.Add(this.PL_OldUser);
            this.Controls.Add(this.RB_OldUser);
            this.Controls.Add(this.RB_NewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_OrderManage";
            this.Text = "订单管理";
            this.PL_OldUser.ResumeLayout(false);
            this.PL_OldUser.PerformLayout();
            this.PL_NewUser.ResumeLayout(false);
            this.PL_NewUser.PerformLayout();
            this.PL_UserResult.ResumeLayout(false);
            this.PL_UserResult.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_User;
        private System.Windows.Forms.ListBox LB_Version;
        private System.Windows.Forms.RadioButton RB_NewUser;
        private System.Windows.Forms.RadioButton RB_OldUser;
        private System.Windows.Forms.Panel PL_OldUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.TextBox TB_SearchRealName;
        private System.Windows.Forms.TextBox TB_SearchUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_SearchValidation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PL_NewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Validation;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_RealName;
        private System.Windows.Forms.TextBox TB_Adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.Button BT_SeachSub;
        private System.Windows.Forms.Button BT_Sub;
        private System.Windows.Forms.Panel PL_UserResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Label_Adress;
        private System.Windows.Forms.Label Label_Validation;
        private System.Windows.Forms.TextBox Label_Info;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Button BT_SeachVersion;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker TM_Start;
        private System.Windows.Forms.DateTimePicker TM_Back;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CB_Action;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton RB_Self;
        private System.Windows.Forms.RadioButton RB_Other;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RB_OtherGet;
        private System.Windows.Forms.RadioButton RB_SelfGet;
        private System.Windows.Forms.Button BT_AddOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.Label label22;
    }
}