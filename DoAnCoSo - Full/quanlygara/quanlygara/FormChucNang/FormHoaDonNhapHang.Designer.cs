namespace quanlygara.FormChucNang
{
    partial class FormHoaDonNhapHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHoTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHoaDOn = new System.Windows.Forms.DataGridView();
            this.mamathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaMatHang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownDonGia = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonThemHoaDOn = new System.Windows.Forms.Button();
            this.numericUpDownSoluong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMatHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxHoTenNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerNgayNhapHang);
            this.panel1.Controls.Add(this.comboBoxNCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 126);
            this.panel1.TabIndex = 3;
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
            // dateTimePickerNgayNhapHang
            // 
            this.dateTimePickerNgayNhapHang.Enabled = false;
            this.dateTimePickerNgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhapHang.Location = new System.Drawing.Point(352, 49);
            this.dateTimePickerNgayNhapHang.Name = "dateTimePickerNgayNhapHang";
            this.dateTimePickerNgayNhapHang.Size = new System.Drawing.Size(259, 30);
            this.dateTimePickerNgayNhapHang.TabIndex = 14;
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.Location = new System.Drawing.Point(26, 52);
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(259, 30);
            this.comboBoxNCC.TabIndex = 13;
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
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn nhà cung cấp";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.buttonHuy.FlatAppearance.BorderSize = 0;
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.ForeColor = System.Drawing.Color.Black;
            this.buttonHuy.Location = new System.Drawing.Point(887, 610);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(108, 38);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(773, 610);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(108, 38);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi tiết phiếu nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewHoaDOn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numericUpDownDonGia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonThemHoaDOn);
            this.panel2.Controls.Add(this.numericUpDownSoluong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxMatHang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(17, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 362);
            this.panel2.TabIndex = 13;
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
            this.thanhtien,
            this.XoaMatHang});
            this.dataGridViewHoaDOn.Location = new System.Drawing.Point(26, 117);
            this.dataGridViewHoaDOn.Name = "dataGridViewHoaDOn";
            this.dataGridViewHoaDOn.ReadOnly = true;
            this.dataGridViewHoaDOn.RowHeadersVisible = false;
            this.dataGridViewHoaDOn.RowHeadersWidth = 51;
            this.dataGridViewHoaDOn.RowTemplate.Height = 24;
            this.dataGridViewHoaDOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDOn.Size = new System.Drawing.Size(930, 217);
            this.dataGridViewHoaDOn.TabIndex = 24;
            this.dataGridViewHoaDOn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDOn_CellClick);
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
            // XoaMatHang
            // 
            this.XoaMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XoaMatHang.HeaderText = "Xóa";
            this.XoaMatHang.MinimumWidth = 6;
            this.XoaMatHang.Name = "XoaMatHang";
            this.XoaMatHang.ReadOnly = true;
            this.XoaMatHang.Text = "Xóa";
            this.XoaMatHang.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Danh sách nhập hàng";
            // 
            // numericUpDownDonGia
            // 
            this.numericUpDownDonGia.Location = new System.Drawing.Point(680, 45);
            this.numericUpDownDonGia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownDonGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDonGia.Name = "numericUpDownDonGia";
            this.numericUpDownDonGia.Size = new System.Drawing.Size(276, 30);
            this.numericUpDownDonGia.TabIndex = 22;
            this.numericUpDownDonGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Đơn giá nhập/1SP";
            // 
            // buttonThemHoaDOn
            // 
            this.buttonThemHoaDOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonThemHoaDOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemHoaDOn.ForeColor = System.Drawing.Color.White;
            this.buttonThemHoaDOn.Location = new System.Drawing.Point(873, 3);
            this.buttonThemHoaDOn.Name = "buttonThemHoaDOn";
            this.buttonThemHoaDOn.Size = new System.Drawing.Size(81, 33);
            this.buttonThemHoaDOn.TabIndex = 19;
            this.buttonThemHoaDOn.Text = "Thêm +";
            this.buttonThemHoaDOn.UseVisualStyleBackColor = false;
            this.buttonThemHoaDOn.Click += new System.EventHandler(this.buttonThemHoaDOn_Click);
            // 
            // numericUpDownSoluong
            // 
            this.numericUpDownSoluong.Location = new System.Drawing.Point(352, 45);
            this.numericUpDownSoluong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoluong.Name = "numericUpDownSoluong";
            this.numericUpDownSoluong.Size = new System.Drawing.Size(259, 30);
            this.numericUpDownSoluong.TabIndex = 18;
            this.numericUpDownSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nhập số lượng";
            // 
            // comboBoxMatHang
            // 
            this.comboBoxMatHang.FormattingEnabled = true;
            this.comboBoxMatHang.Location = new System.Drawing.Point(26, 45);
            this.comboBoxMatHang.Name = "comboBoxMatHang";
            this.comboBoxMatHang.Size = new System.Drawing.Size(259, 30);
            this.comboBoxMatHang.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chọn mặt hàng nhập";
            // 
            // FormHoaDonNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHoaDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.FormHoaDonNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHoTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapHang;
        private System.Windows.Forms.ComboBox comboBoxNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownSoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonThemHoaDOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewHoaDOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn XoaMatHang;
    }
}