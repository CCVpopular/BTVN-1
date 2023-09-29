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
            this.dataGridViewkhachhang = new System.Windows.Forms.DataGridView();
            this.textBoxtenkhach = new System.Windows.Forms.TextBox();
            this.textBoxghedadat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonthem = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewkhachhang
            // 
            this.dataGridViewkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridViewkhachhang.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewkhachhang.Name = "dataGridViewkhachhang";
            this.dataGridViewkhachhang.RowHeadersWidth = 51;
            this.dataGridViewkhachhang.RowTemplate.Height = 24;
            this.dataGridViewkhachhang.Size = new System.Drawing.Size(957, 523);
            this.dataGridViewkhachhang.TabIndex = 0;
            // 
            // textBoxtenkhach
            // 
            this.textBoxtenkhach.Location = new System.Drawing.Point(125, 24);
            this.textBoxtenkhach.Name = "textBoxtenkhach";
            this.textBoxtenkhach.Size = new System.Drawing.Size(404, 22);
            this.textBoxtenkhach.TabIndex = 1;
            // 
            // textBoxghedadat
            // 
            this.textBoxghedadat.Location = new System.Drawing.Point(125, 75);
            this.textBoxghedadat.Name = "textBoxghedadat";
            this.textBoxghedadat.Size = new System.Drawing.Size(844, 22);
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
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghế Đã Đặt";
            // 
            // buttonthem
            // 
            this.buttonthem.FlatAppearance.BorderSize = 2;
            this.buttonthem.Location = new System.Drawing.Point(125, 131);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(104, 39);
            this.buttonthem.TabIndex = 7;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ghế Đã Đặt";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Thành Tiền";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 725);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxghedadat);
            this.Controls.Add(this.textBoxtenkhach);
            this.Controls.Add(this.dataGridViewkhachhang);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewkhachhang;
        private System.Windows.Forms.TextBox textBoxtenkhach;
        private System.Windows.Forms.TextBox textBoxghedadat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}