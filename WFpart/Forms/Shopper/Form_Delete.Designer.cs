namespace WFpart
{
    partial class Form_Delete
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
            this.BT_Submit = new System.Windows.Forms.Button();
            this.BT_Canncel = new System.Windows.Forms.Button();
            this.GV_OverTime = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OverTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(189, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "您是否确认要删除以上过期订单?";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(214, 307);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 1;
            this.BT_Submit.Text = "是";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // BT_Canncel
            // 
            this.BT_Canncel.Location = new System.Drawing.Point(383, 307);
            this.BT_Canncel.Name = "BT_Canncel";
            this.BT_Canncel.Size = new System.Drawing.Size(75, 23);
            this.BT_Canncel.TabIndex = 1;
            this.BT_Canncel.Text = "否";
            this.BT_Canncel.UseVisualStyleBackColor = true;
            this.BT_Canncel.Click += new System.EventHandler(this.BT_Canncel_Click);
            // 
            // GV_OverTime
            // 
            this.GV_OverTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_OverTime.Location = new System.Drawing.Point(12, 12);
            this.GV_OverTime.Name = "GV_OverTime";
            this.GV_OverTime.RowTemplate.Height = 23;
            this.GV_OverTime.Size = new System.Drawing.Size(653, 223);
            this.GV_OverTime.TabIndex = 2;
            // 
            // Form_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 358);
            this.Controls.Add(this.GV_OverTime);
            this.Controls.Add(this.BT_Canncel);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Delete";
            this.Text = "删除过期订单";
            ((System.ComponentModel.ISupportInitialize)(this.GV_OverTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Button BT_Canncel;
        private System.Windows.Forms.DataGridView GV_OverTime;
    }
}