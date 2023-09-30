namespace BTVN_1
{
    partial class Form2
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
            this.textBoxtenkhach = new System.Windows.Forms.TextBox();
            this.textBoxghedadat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonthem = new System.Windows.Forms.Button();
            this.textBoxthanhtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxtenkhach
            // 
            this.textBoxtenkhach.Location = new System.Drawing.Point(148, 24);
            this.textBoxtenkhach.Name = "textBoxtenkhach";
            this.textBoxtenkhach.Size = new System.Drawing.Size(404, 22);
            this.textBoxtenkhach.TabIndex = 1;
            // 
            // textBoxghedadat
            // 
            this.textBoxghedadat.Enabled = false;
            this.textBoxghedadat.Location = new System.Drawing.Point(148, 57);
            this.textBoxghedadat.Name = "textBoxghedadat";
            this.textBoxghedadat.Size = new System.Drawing.Size(497, 22);
            this.textBoxghedadat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghế Đã Đặt";
            // 
            // buttonthem
            // 
            this.buttonthem.FlatAppearance.BorderSize = 2;
            this.buttonthem.Location = new System.Drawing.Point(148, 131);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(104, 39);
            this.buttonthem.TabIndex = 7;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // textBoxthanhtien
            // 
            this.textBoxthanhtien.Enabled = false;
            this.textBoxthanhtien.Location = new System.Drawing.Point(148, 90);
            this.textBoxthanhtien.Name = "textBoxthanhtien";
            this.textBoxthanhtien.Size = new System.Drawing.Size(155, 22);
            this.textBoxthanhtien.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thành Tiền";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxthanhtien);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxghedadat);
            this.Controls.Add(this.textBoxtenkhach);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxtenkhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonthem;
        public System.Windows.Forms.TextBox textBoxghedadat;
        public System.Windows.Forms.TextBox textBoxthanhtien;
        private System.Windows.Forms.Label label2;
    }
}