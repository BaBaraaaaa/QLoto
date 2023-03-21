namespace quanlygara.FormChucNang
{
    partial class FormXemChiTietNhapHang
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHoaDOn = new System.Windows.Forms.DataGridView();
            this.mamathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.textBoxHoTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNgayNhapHang = new System.Windows.Forms.TextBox();
            this.textBoxNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDOn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Danh sách nhập hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewHoaDOn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(26, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 351);
            this.panel2.TabIndex = 19;
            // 
            // dataGridViewHoaDOn
            // 
            this.dataGridViewHoaDOn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDOn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamathang,
            this.tenmathang,
            this.soluong,
            this.dongianhap,
            this.thanhtien});
            this.dataGridViewHoaDOn.Location = new System.Drawing.Point(26, 33);
            this.dataGridViewHoaDOn.Name = "dataGridViewHoaDOn";
            this.dataGridViewHoaDOn.ReadOnly = true;
            this.dataGridViewHoaDOn.RowHeadersVisible = false;
            this.dataGridViewHoaDOn.RowHeadersWidth = 51;
            this.dataGridViewHoaDOn.RowTemplate.Height = 24;
            this.dataGridViewHoaDOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDOn.Size = new System.Drawing.Size(930, 257);
            this.dataGridViewHoaDOn.TabIndex = 24;
            // 
            // mamathang
            // 
            this.mamathang.DataPropertyName = "Mamathang";
            this.mamathang.HeaderText = "Mã mặt hàng";
            this.mamathang.MinimumWidth = 6;
            this.mamathang.Name = "mamathang";
            this.mamathang.ReadOnly = true;
            // 
            // tenmathang
            // 
            this.tenmathang.DataPropertyName = "Tenmathang";
            this.tenmathang.HeaderText = "Tên mặt hàng";
            this.tenmathang.MinimumWidth = 6;
            this.tenmathang.Name = "tenmathang";
            this.tenmathang.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongianhap
            // 
            this.dongianhap.DataPropertyName = "Dongianhap";
            this.dongianhap.HeaderText = "Đơn giá nhập";
            this.dongianhap.MinimumWidth = 6;
            this.dongianhap.Name = "dongianhap";
            this.dongianhap.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "Thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chi tiết phiếu nhập";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.buttonHuy.FlatAppearance.BorderSize = 0;
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.ForeColor = System.Drawing.Color.Black;
            this.buttonHuy.Location = new System.Drawing.Point(899, 613);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(108, 38);
            this.buttonHuy.TabIndex = 17;
            this.buttonHuy.Text = "Đóng";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // textBoxHoTenNV
            // 
            this.textBoxHoTenNV.Location = new System.Drawing.Point(680, 49);
            this.textBoxHoTenNV.Name = "textBoxHoTenNV";
            this.textBoxHoTenNV.ReadOnly = true;
            this.textBoxHoTenNV.Size = new System.Drawing.Size(276, 30);
            this.textBoxHoTenNV.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhân viên lập hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxNgayNhapHang);
            this.panel1.Controls.Add(this.textBoxNCC);
            this.panel1.Controls.Add(this.textBoxHoTenNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 126);
            this.panel1.TabIndex = 15;
            // 
            // textBoxNgayNhapHang
            // 
            this.textBoxNgayNhapHang.Location = new System.Drawing.Point(352, 49);
            this.textBoxNgayNhapHang.Name = "textBoxNgayNhapHang";
            this.textBoxNgayNhapHang.ReadOnly = true;
            this.textBoxNgayNhapHang.Size = new System.Drawing.Size(276, 30);
            this.textBoxNgayNhapHang.TabIndex = 18;
            // 
            // textBoxNCC
            // 
            this.textBoxNCC.Location = new System.Drawing.Point(26, 49);
            this.textBoxNCC.Name = "textBoxNCC";
            this.textBoxNCC.ReadOnly = true;
            this.textBoxNCC.Size = new System.Drawing.Size(276, 30);
            this.textBoxNCC.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // FormXemChiTietNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXemChiTietNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết nhập hàng";
            this.Load += new System.EventHandler(this.FormXemChiTietNhapHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDOn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox textBoxHoTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.TextBox textBoxNgayNhapHang;
    }
}