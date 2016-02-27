namespace WFpart
{
    partial class Form_LastCheck
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
            this.TB_OverKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_OverKM
            // 
            this.TB_OverKM.Location = new System.Drawing.Point(83, 12);
            this.TB_OverKM.Name = "TB_OverKM";
            this.TB_OverKM.Size = new System.Drawing.Size(100, 21);
            this.TB_OverKM.TabIndex = 0;
            this.TB_OverKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "超过里程：";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(185, 39);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 1;
            this.BT_Submit.Text = "提交";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "公里";
            // 
            // Form_LastCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 74);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_OverKM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_LastCheck";
            this.Text = "行驶情况";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_OverKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Label label2;
    }
}