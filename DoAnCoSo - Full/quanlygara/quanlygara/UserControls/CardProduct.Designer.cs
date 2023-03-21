namespace quanlygara.UserControls
{
    partial class CardProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonXemSP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxProductIMG = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 378);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonXemSP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 57);
            this.panel4.TabIndex = 2;
            // 
            // buttonXemSP
            // 
            this.buttonXemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonXemSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemSP.ForeColor = System.Drawing.Color.White;
            this.buttonXemSP.Location = new System.Drawing.Point(0, 0);
            this.buttonXemSP.Name = "buttonXemSP";
            this.buttonXemSP.Size = new System.Drawing.Size(293, 57);
            this.buttonXemSP.TabIndex = 10;
            this.buttonXemSP.Text = "Xem chi tiết";
            this.buttonXemSP.UseVisualStyleBackColor = false;
            this.buttonXemSP.Click += new System.EventHandler(this.buttonXemSP_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelGia);
            this.panel3.Controls.Add(this.labelSoLuong);
            this.panel3.Controls.Add(this.labelTenSP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 97);
            this.panel3.TabIndex = 1;
            // 
            // labelGia
            // 
            this.labelGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGia.Location = new System.Drawing.Point(0, 71);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(291, 22);
            this.labelGia.TabIndex = 2;
            this.labelGia.Text = "Giá:";
            this.labelGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSoLuong.Location = new System.Drawing.Point(0, 49);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(291, 22);
            this.labelSoLuong.TabIndex = 1;
            this.labelSoLuong.Text = "Số lượng:";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenSP
            // 
            this.labelTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTenSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSP.Location = new System.Drawing.Point(0, 0);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(291, 49);
            this.labelTenSP.TabIndex = 0;
            this.labelTenSP.Text = "Sản phẩm 0111";
            this.labelTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxProductIMG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 224);
            this.panel2.TabIndex = 0;
            // 
            // pictureBoxProductIMG
            // 
            this.pictureBoxProductIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProductIMG.Image = global::quanlygara.Properties.Resources._917150;
            this.pictureBoxProductIMG.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProductIMG.Name = "pictureBoxProductIMG";
            this.pictureBoxProductIMG.Size = new System.Drawing.Size(293, 224);
            this.pictureBoxProductIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductIMG.TabIndex = 0;
            this.pictureBoxProductIMG.TabStop = false;
            // 
            // CardProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(293, 378);
            this.Load += new System.EventHandler(this.CardProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxProductIMG;
        private System.Windows.Forms.Button buttonXemSP;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelSoLuong;
    }
}
