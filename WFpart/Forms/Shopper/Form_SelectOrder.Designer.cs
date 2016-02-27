namespace WFpart
{
    partial class Form_SelectOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RealName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Validation = new System.Windows.Forms.TextBox();
            this.LB_Order = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Label_OrderCount = new System.Windows.Forms.Label();
            this.Label_IsPay = new System.Windows.Forms.Label();
            this.BT_LastCheck = new System.Windows.Forms.Button();
            this.BT_Searck = new System.Windows.Forms.Button();
            this.Label_TMstart = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Label_TMend = new System.Windows.Forms.Label();
            this.label_333 = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_PayDispot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Label_Deposit = new System.Windows.Forms.Label();
            this.BT_CatchCar = new System.Windows.Forms.Button();
            this.BT_GetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订车姓名：";
            // 
            // TB_RealName
            // 
            this.TB_RealName.Location = new System.Drawing.Point(106, 6);
            this.TB_RealName.Name = "TB_RealName";
            this.TB_RealName.Size = new System.Drawing.Size(128, 21);
            this.TB_RealName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "身份证号码：";
            // 
            // TB_Validation
            // 
            this.TB_Validation.Location = new System.Drawing.Point(106, 33);
            this.TB_Validation.Name = "TB_Validation";
            this.TB_Validation.Size = new System.Drawing.Size(128, 21);
            this.TB_Validation.TabIndex = 2;
            // 
            // LB_Order
            // 
            this.LB_Order.FormattingEnabled = true;
            this.LB_Order.ItemHeight = 12;
            this.LB_Order.Location = new System.Drawing.Point(21, 95);
            this.LB_Order.Name = "LB_Order";
            this.LB_Order.Size = new System.Drawing.Size(213, 208);
            this.LB_Order.TabIndex = 4;
            this.LB_Order.SelectedIndexChanged += new System.EventHandler(this.LB_Order_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "订车型号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "订车数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "是否付款：";
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Location = new System.Drawing.Point(345, 9);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(17, 12);
            this.Label_Version.TabIndex = 3;
            this.Label_Version.Text = "无";
            // 
            // Label_OrderCount
            // 
            this.Label_OrderCount.AutoSize = true;
            this.Label_OrderCount.Location = new System.Drawing.Point(345, 33);
            this.Label_OrderCount.Name = "Label_OrderCount";
            this.Label_OrderCount.Size = new System.Drawing.Size(17, 12);
            this.Label_OrderCount.TabIndex = 3;
            this.Label_OrderCount.Text = "无";
            // 
            // Label_IsPay
            // 
            this.Label_IsPay.AutoSize = true;
            this.Label_IsPay.Location = new System.Drawing.Point(345, 104);
            this.Label_IsPay.Name = "Label_IsPay";
            this.Label_IsPay.Size = new System.Drawing.Size(17, 12);
            this.Label_IsPay.TabIndex = 3;
            this.Label_IsPay.Text = "无";
            // 
            // BT_LastCheck
            // 
            this.BT_LastCheck.Font = new System.Drawing.Font("宋体", 11F);
            this.BT_LastCheck.Location = new System.Drawing.Point(266, 246);
            this.BT_LastCheck.Name = "BT_LastCheck";
            this.BT_LastCheck.Size = new System.Drawing.Size(110, 25);
            this.BT_LastCheck.TabIndex = 5;
            this.BT_LastCheck.Text = "付    款";
            this.BT_LastCheck.UseVisualStyleBackColor = true;
            this.BT_LastCheck.Click += new System.EventHandler(this.BT_LastCheck_Click);
            // 
            // BT_Searck
            // 
            this.BT_Searck.Location = new System.Drawing.Point(159, 60);
            this.BT_Searck.Name = "BT_Searck";
            this.BT_Searck.Size = new System.Drawing.Size(75, 23);
            this.BT_Searck.TabIndex = 3;
            this.BT_Searck.Text = "搜索";
            this.BT_Searck.UseVisualStyleBackColor = true;
            this.BT_Searck.Click += new System.EventHandler(this.BT_Searck_Click);
            // 
            // Label_TMstart
            // 
            this.Label_TMstart.AutoSize = true;
            this.Label_TMstart.Location = new System.Drawing.Point(345, 57);
            this.Label_TMstart.Name = "Label_TMstart";
            this.Label_TMstart.Size = new System.Drawing.Size(17, 12);
            this.Label_TMstart.TabIndex = 3;
            this.Label_TMstart.Text = "无";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(264, 57);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 12);
            this.label33.TabIndex = 3;
            this.label33.Text = "开始时间：";
            // 
            // Label_TMend
            // 
            this.Label_TMend.AutoSize = true;
            this.Label_TMend.Location = new System.Drawing.Point(345, 82);
            this.Label_TMend.Name = "Label_TMend";
            this.Label_TMend.Size = new System.Drawing.Size(17, 12);
            this.Label_TMend.TabIndex = 3;
            this.Label_TMend.Text = "无";
            // 
            // label_333
            // 
            this.label_333.AutoSize = true;
            this.label_333.Location = new System.Drawing.Point(264, 82);
            this.label_333.Name = "label_333";
            this.label_333.Size = new System.Drawing.Size(65, 12);
            this.label_333.TabIndex = 3;
            this.label_333.Text = "结束时间：";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("宋体", 11F);
            this.BT_Cancel.Location = new System.Drawing.Point(266, 277);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(110, 27);
            this.BT_Cancel.TabIndex = 5;
            this.BT_Cancel.Text = "取消订单";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_PayDispot
            // 
            this.BT_PayDispot.Font = new System.Drawing.Font("宋体", 11F);
            this.BT_PayDispot.Location = new System.Drawing.Point(266, 215);
            this.BT_PayDispot.Name = "BT_PayDispot";
            this.BT_PayDispot.Size = new System.Drawing.Size(110, 25);
            this.BT_PayDispot.TabIndex = 5;
            this.BT_PayDispot.Text = "定金支付";
            this.BT_PayDispot.UseVisualStyleBackColor = true;
            this.BT_PayDispot.Click += new System.EventHandler(this.BT_PayDispot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "是否付定金：";
            // 
            // Label_Deposit
            // 
            this.Label_Deposit.AutoSize = true;
            this.Label_Deposit.Location = new System.Drawing.Point(345, 126);
            this.Label_Deposit.Name = "Label_Deposit";
            this.Label_Deposit.Size = new System.Drawing.Size(17, 12);
            this.Label_Deposit.TabIndex = 3;
            this.Label_Deposit.Text = "无";
            // 
            // BT_CatchCar
            // 
            this.BT_CatchCar.Font = new System.Drawing.Font("宋体", 11F);
            this.BT_CatchCar.Location = new System.Drawing.Point(266, 152);
            this.BT_CatchCar.Name = "BT_CatchCar";
            this.BT_CatchCar.Size = new System.Drawing.Size(110, 25);
            this.BT_CatchCar.TabIndex = 5;
            this.BT_CatchCar.Text = "提车";
            this.BT_CatchCar.UseVisualStyleBackColor = true;
            this.BT_CatchCar.Click += new System.EventHandler(this.BT_CatchCar_Click);
            // 
            // BT_GetInfo
            // 
            this.BT_GetInfo.Font = new System.Drawing.Font("宋体", 11F);
            this.BT_GetInfo.Location = new System.Drawing.Point(266, 183);
            this.BT_GetInfo.Name = "BT_GetInfo";
            this.BT_GetInfo.Size = new System.Drawing.Size(110, 25);
            this.BT_GetInfo.TabIndex = 5;
            this.BT_GetInfo.Text = "提车详情";
            this.BT_GetInfo.UseVisualStyleBackColor = true;
            this.BT_GetInfo.Click += new System.EventHandler(this.BT_GetInfo_Click);
            // 
            // Form_SelectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 322);
            this.Controls.Add(this.BT_Searck);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_GetInfo);
            this.Controls.Add(this.BT_CatchCar);
            this.Controls.Add(this.BT_PayDispot);
            this.Controls.Add(this.BT_LastCheck);
            this.Controls.Add(this.label_333);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.Label_TMend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_TMstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label_Deposit);
            this.Controls.Add(this.Label_IsPay);
            this.Controls.Add(this.Label_OrderCount);
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Order);
            this.Controls.Add(this.TB_Validation);
            this.Controls.Add(this.TB_RealName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SelectOrder";
            this.Text = "选择订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_RealName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Validation;
        private System.Windows.Forms.ListBox LB_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_OrderCount;
        private System.Windows.Forms.Label Label_IsPay;
        private System.Windows.Forms.Button BT_LastCheck;
        private System.Windows.Forms.Button BT_Searck;
        private System.Windows.Forms.Label Label_TMstart;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label Label_TMend;
        private System.Windows.Forms.Label label_333;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_PayDispot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_Deposit;
        private System.Windows.Forms.Button BT_CatchCar;
        private System.Windows.Forms.Button BT_GetInfo;
    }
}