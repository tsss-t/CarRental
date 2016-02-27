namespace WFpart
{
    partial class Form_CatchCar
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
            this.GB_Car = new System.Windows.Forms.GroupBox();
            this.GB_Validation = new System.Windows.Forms.GroupBox();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GB_Car
            // 
            this.GB_Car.Location = new System.Drawing.Point(12, 12);
            this.GB_Car.Name = "GB_Car";
            this.GB_Car.Size = new System.Drawing.Size(280, 168);
            this.GB_Car.TabIndex = 0;
            this.GB_Car.TabStop = false;
            this.GB_Car.Text = "车辆牌照";
            // 
            // GB_Validation
            // 
            this.GB_Validation.Location = new System.Drawing.Point(298, 12);
            this.GB_Validation.Name = "GB_Validation";
            this.GB_Validation.Size = new System.Drawing.Size(283, 168);
            this.GB_Validation.TabIndex = 0;
            this.GB_Validation.TabStop = false;
            this.GB_Validation.Text = "驾驶员驾照";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(506, 204);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(75, 23);
            this.BT_Submit.TabIndex = 1;
            this.BT_Submit.Text = "提交";
            this.BT_Submit.UseVisualStyleBackColor = true;

            // 
            // Form_CatchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 239);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.GB_Validation);
            this.Controls.Add(this.GB_Car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_CatchCar";
            this.Text = "提车";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Car;
        private System.Windows.Forms.GroupBox GB_Validation;
        private System.Windows.Forms.Button BT_Submit;
    }
}