namespace WFpart
{
    partial class Form_CarTypeManage
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
            this.LB_Type = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_UpdateType = new System.Windows.Forms.Button();
            this.TB_TypeName = new System.Windows.Forms.TextBox();
            this.TB_TypeInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_AddType = new System.Windows.Forms.Button();
            this.BT_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Type
            // 
            this.LB_Type.FormattingEnabled = true;
            this.LB_Type.ItemHeight = 12;
            this.LB_Type.Location = new System.Drawing.Point(12, 28);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(129, 148);
            this.LB_Type.TabIndex = 1;
            this.LB_Type.SelectedIndexChanged += new System.EventHandler(this.LB_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "现有类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型名称：";
            // 
            // BT_UpdateType
            // 
            this.BT_UpdateType.Location = new System.Drawing.Point(307, 192);
            this.BT_UpdateType.Name = "BT_UpdateType";
            this.BT_UpdateType.Size = new System.Drawing.Size(75, 23);
            this.BT_UpdateType.TabIndex = 2;
            this.BT_UpdateType.Text = "确认修改";
            this.BT_UpdateType.UseVisualStyleBackColor = true;
            this.BT_UpdateType.Click += new System.EventHandler(this.BT_UpdateType_Click);
            // 
            // TB_TypeName
            // 
            this.TB_TypeName.Location = new System.Drawing.Point(214, 28);
            this.TB_TypeName.Name = "TB_TypeName";
            this.TB_TypeName.Size = new System.Drawing.Size(100, 21);
            this.TB_TypeName.TabIndex = 2;
            // 
            // TB_TypeInfo
            // 
            this.TB_TypeInfo.Location = new System.Drawing.Point(214, 55);
            this.TB_TypeInfo.Multiline = true;
            this.TB_TypeInfo.Name = "TB_TypeInfo";
            this.TB_TypeInfo.Size = new System.Drawing.Size(168, 121);
            this.TB_TypeInfo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "类型说明：";
            // 
            // BT_AddType
            // 
            this.BT_AddType.Location = new System.Drawing.Point(307, 192);
            this.BT_AddType.Name = "BT_AddType";
            this.BT_AddType.Size = new System.Drawing.Size(75, 23);
            this.BT_AddType.TabIndex = 5;
            this.BT_AddType.Text = "确认添加";
            this.BT_AddType.UseVisualStyleBackColor = true;
            this.BT_AddType.Click += new System.EventHandler(this.BT_AddType_Click);
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(12, 192);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(129, 23);
            this.BT_Change.TabIndex = 4;
            this.BT_Change.Text = "切换到修改模式";
            this.BT_Change.UseVisualStyleBackColor = true;
            this.BT_Change.Click += new System.EventHandler(this.BT_Change_Click);
            // 
            // Form_CarTypeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 227);
            this.Controls.Add(this.TB_TypeInfo);
            this.Controls.Add(this.TB_TypeName);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.BT_AddType);
            this.Controls.Add(this.BT_UpdateType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_CarTypeManage";
            this.Text = "汽车类型管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_UpdateType;
        private System.Windows.Forms.TextBox TB_TypeName;
        private System.Windows.Forms.TextBox TB_TypeInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_AddType;
        private System.Windows.Forms.Button BT_Change;
    }
}