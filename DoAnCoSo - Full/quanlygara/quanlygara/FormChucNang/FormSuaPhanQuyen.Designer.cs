namespace quanlygara.FormChucNang
{
    partial class FormSuaPhanQuyen
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
            this.radioButtonChan = new System.Windows.Forms.RadioButton();
            this.radioButtonChoPhep = new System.Windows.Forms.RadioButton();
            this.comboBoxQuyenDangNhap = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cập nhật/phân quyền tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButtonChan);
            this.panel1.Controls.Add(this.radioButtonChoPhep);
            this.panel1.Controls.Add(this.comboBoxQuyenDangNhap);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.textBoxMatKhau);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxMaNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 268);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonChan
            // 
            this.radioButtonChan.AutoSize = true;
            this.radioButtonChan.Location = new System.Drawing.Point(716, 131);
            this.radioButtonChan.Name = "radioButtonChan";
            this.radioButtonChan.Size = new System.Drawing.Size(71, 26);
            this.radioButtonChan.TabIndex = 31;
            this.radioButtonChan.TabStop = true;
            this.radioButtonChan.Text = "Chặn";
            this.radioButtonChan.UseVisualStyleBackColor = true;
            this.radioButtonChan.CheckedChanged += new System.EventHandler(this.radioButtonChan_CheckedChanged);
            // 
            // radioButtonChoPhep
            // 
            this.radioButtonChoPhep.AutoSize = true;
            this.radioButtonChoPhep.Location = new System.Drawing.Point(449, 130);
            this.radioButtonChoPhep.Name = "radioButtonChoPhep";
            this.radioButtonChoPhep.Size = new System.Drawing.Size(190, 26);
            this.radioButtonChoPhep.TabIndex = 30;
            this.radioButtonChoPhep.TabStop = true;
            this.radioButtonChoPhep.Text = "Cho phép đăng nhập";
            this.radioButtonChoPhep.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuyenDangNhap
            // 
            this.comboBoxQuyenDangNhap.FormattingEnabled = true;
            this.comboBoxQuyenDangNhap.Items.AddRange(new object[] {
            "Chưa phân quyền",
            "Quyền admin",
            "Quyền thủ kho",
            "Quyền nhân viên"});
            this.comboBoxQuyenDangNhap.Location = new System.Drawing.Point(26, 130);
            this.comboBoxQuyenDangNhap.Name = "comboBoxQuyenDangNhap";
            this.comboBoxQuyenDangNhap.Size = new System.Drawing.Size(340, 30);
            this.comboBoxQuyenDangNhap.TabIndex = 29;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(716, 52);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(73, 30);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(449, 52);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.ReadOnly = true;
            this.textBoxMatKhau.Size = new System.Drawing.Size(261, 30);
            this.textBoxMatKhau.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trạng thái đăng nhập";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.buttonHuy.FlatAppearance.BorderSize = 0;
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.ForeColor = System.Drawing.Color.Black;
            this.buttonHuy.Location = new System.Drawing.Point(681, 201);
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
            this.buttonLuu.Location = new System.Drawing.Point(552, 201);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(108, 38);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quyền đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(26, 52);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.ReadOnly = true;
            this.textBoxMaNV.Size = new System.Drawing.Size(340, 30);
            this.textBoxMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // FormSuaPhanQuyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(909, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuaPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tài khoản người dùng";
            this.Load += new System.EventHandler(this.FormSuaPhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonChan;
        private System.Windows.Forms.RadioButton radioButtonChoPhep;
        private System.Windows.Forms.ComboBox comboBoxQuyenDangNhap;
    }
}