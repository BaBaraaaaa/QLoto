namespace quanlygara.UserControls
{
    partial class UserControlSuaChua
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.button_TKsuachuaaaa = new System.Windows.Forms.Button();
            this.textBox_TKsuachua = new System.Windows.Forms.TextBox();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biensoxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylaphd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaHD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.XemChiTietNhap = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.827586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.17242F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 766);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.button_TKsuachuaaaa);
            this.panel1.Controls.Add(this.textBox_TKsuachua);
            this.panel1.Controls.Add(this.buttonThemSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 61);
            this.panel1.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 22);
            this.label24.TabIndex = 14;
            this.label24.Text = "Tìm kiếm";
            // 
            // button_TKsuachuaaaa
            // 
            this.button_TKsuachuaaaa.BackColor = System.Drawing.Color.Teal;
            this.button_TKsuachuaaaa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TKsuachuaaaa.ForeColor = System.Drawing.Color.White;
            this.button_TKsuachuaaaa.Image = global::quanlygara.Properties.Resources.icons8_search_25;
            this.button_TKsuachuaaaa.Location = new System.Drawing.Point(498, 13);
            this.button_TKsuachuaaaa.Name = "button_TKsuachuaaaa";
            this.button_TKsuachuaaaa.Size = new System.Drawing.Size(45, 31);
            this.button_TKsuachuaaaa.TabIndex = 13;
            this.button_TKsuachuaaaa.UseVisualStyleBackColor = false;
            this.button_TKsuachuaaaa.Click += new System.EventHandler(this.button_TKsuachuaaaa_Click);
            // 
            // textBox_TKsuachua
            // 
            this.textBox_TKsuachua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TKsuachua.Location = new System.Drawing.Point(98, 13);
            this.textBox_TKsuachua.Name = "textBox_TKsuachua";
            this.textBox_TKsuachua.Size = new System.Drawing.Size(396, 30);
            this.textBox_TKsuachua.TabIndex = 12;
            this.textBox_TKsuachua.TextChanged += new System.EventHandler(this.textBox_TKsuachua_TextChanged);
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemSP.ForeColor = System.Drawing.Color.White;
            this.buttonThemSP.Location = new System.Drawing.Point(921, 11);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(172, 34);
            this.buttonThemSP.TabIndex = 11;
            this.buttonThemSP.Text = "Lập hóa đơn +";
            this.buttonThemSP.UseVisualStyleBackColor = false;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 693);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.biensoxe,
            this.tenkhachhang,
            this.sdt,
            this.hotennv,
            this.ngaylaphd,
            this.tongthanhtien,
            this.ghichu,
            this.XoaHD,
            this.XemChiTietNhap});
            this.dataGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowHeadersVisible = false;
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(1106, 693);
            this.dataGridViewHoaDon.TabIndex = 4;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.ReadOnly = true;
            // 
            // biensoxe
            // 
            this.biensoxe.DataPropertyName = "biensoxe";
            this.biensoxe.HeaderText = "Biển số xe";
            this.biensoxe.MinimumWidth = 6;
            this.biensoxe.Name = "biensoxe";
            this.biensoxe.ReadOnly = true;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "tenkhachhang";
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.MinimumWidth = 6;
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại khách hàng";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // hotennv
            // 
            this.hotennv.DataPropertyName = "hotennv";
            this.hotennv.HeaderText = "Nhân viên lập hóa đơn";
            this.hotennv.MinimumWidth = 6;
            this.hotennv.Name = "hotennv";
            this.hotennv.ReadOnly = true;
            // 
            // ngaylaphd
            // 
            this.ngaylaphd.DataPropertyName = "ngaylaphd";
            this.ngaylaphd.HeaderText = "Ngày/giờ lập hóa đơn";
            this.ngaylaphd.MinimumWidth = 6;
            this.ngaylaphd.Name = "ngaylaphd";
            this.ngaylaphd.ReadOnly = true;
            // 
            // tongthanhtien
            // 
            this.tongthanhtien.DataPropertyName = "tongthanhtien";
            this.tongthanhtien.HeaderText = "Tổng thành tiền";
            this.tongthanhtien.MinimumWidth = 6;
            this.tongthanhtien.Name = "tongthanhtien";
            this.tongthanhtien.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // XoaHD
            // 
            this.XoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XoaHD.HeaderText = "Xóa";
            this.XoaHD.MinimumWidth = 6;
            this.XoaHD.Name = "XoaHD";
            this.XoaHD.ReadOnly = true;
            this.XoaHD.Text = "Xóa";
            this.XoaHD.UseColumnTextForButtonValue = true;
            // 
            // XemChiTietNhap
            // 
            this.XemChiTietNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XemChiTietNhap.HeaderText = "Xem chi tiết";
            this.XemChiTietNhap.MinimumWidth = 6;
            this.XemChiTietNhap.Name = "XemChiTietNhap";
            this.XemChiTietNhap.ReadOnly = true;
            this.XemChiTietNhap.Text = "Chi tiết";
            this.XemChiTietNhap.UseColumnTextForButtonValue = true;
            // 
            // UserControlSuaChua
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlSuaChua";
            this.Size = new System.Drawing.Size(1112, 766);
            this.Load += new System.EventHandler(this.UserControlSuaChua_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_TKsuachuaaaa;
        private System.Windows.Forms.TextBox textBox_TKsuachua;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn biensoxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylaphd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongthanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewButtonColumn XoaHD;
        private System.Windows.Forms.DataGridViewButtonColumn XemChiTietNhap;
    }
}
