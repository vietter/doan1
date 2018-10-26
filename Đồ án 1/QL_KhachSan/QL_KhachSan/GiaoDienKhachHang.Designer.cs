namespace QL_KhachSan
{
    partial class GiaoDienKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienKhachHang));
            this.pQuanLiTK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDatPhong = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pHoTro = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.pl_phong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pQuanLiTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDatPhong)).BeginInit();
            this.gbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHoTro)).BeginInit();
            this.SuspendLayout();
            // 
            // pQuanLiTK
            // 
            this.pQuanLiTK.Image = ((System.Drawing.Image)(resources.GetObject("pQuanLiTK.Image")));
            this.pQuanLiTK.Location = new System.Drawing.Point(20, 12);
            this.pQuanLiTK.Name = "pQuanLiTK";
            this.pQuanLiTK.Size = new System.Drawing.Size(98, 94);
            this.pQuanLiTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pQuanLiTK.TabIndex = 0;
            this.pQuanLiTK.TabStop = false;
            this.pQuanLiTK.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lí tài khoản";
            // 
            // pDatPhong
            // 
            this.pDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("pDatPhong.Image")));
            this.pDatPhong.Location = new System.Drawing.Point(190, 12);
            this.pDatPhong.Name = "pDatPhong";
            this.pDatPhong.Size = new System.Drawing.Size(98, 94);
            this.pDatPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDatPhong.TabIndex = 2;
            this.pDatPhong.TabStop = false;
            this.pDatPhong.Click += new System.EventHandler(this.pDatPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(200, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đặt phòng";
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Controls.Add(this.label4);
            this.gbKhachHang.Controls.Add(this.pHoTro);
            this.gbKhachHang.Controls.Add(this.pDatPhong);
            this.gbKhachHang.Controls.Add(this.label2);
            this.gbKhachHang.Controls.Add(this.label1);
            this.gbKhachHang.Controls.Add(this.pQuanLiTK);
            this.gbKhachHang.Location = new System.Drawing.Point(7, 2);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(808, 129);
            this.gbKhachHang.TabIndex = 5;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Lựa Chọn Cho Khách Hàng";
            this.gbKhachHang.Enter += new System.EventHandler(this.gbKhachHang_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(733, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hỗ trợ";
            // 
            // pHoTro
            // 
            this.pHoTro.Image = ((System.Drawing.Image)(resources.GetObject("pHoTro.Image")));
            this.pHoTro.Location = new System.Drawing.Point(704, 12);
            this.pHoTro.Name = "pHoTro";
            this.pHoTro.Size = new System.Drawing.Size(98, 94);
            this.pHoTro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHoTro.TabIndex = 6;
            this.pHoTro.TabStop = false;
            this.pHoTro.Click += new System.EventHandler(this.pHoTro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(590, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongTien.Location = new System.Drawing.Point(686, 513);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(131, 24);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pl_phong
            // 
            this.pl_phong.Location = new System.Drawing.Point(7, 137);
            this.pl_phong.Name = "pl_phong";
            this.pl_phong.Size = new System.Drawing.Size(808, 372);
            this.pl_phong.TabIndex = 8;
            // 
            // GiaoDienKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(827, 542);
            this.ControlBox = false;
            this.Controls.Add(this.pl_phong);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.gbKhachHang);
            this.Controls.Add(this.label3);
            this.Name = "GiaoDienKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Khách Hàng";
            this.Load += new System.EventHandler(this.GiaoDienKhachHang_Load);
            this.Click += new System.EventHandler(this.GiaoDienKhachHang_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pQuanLiTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDatPhong)).EndInit();
            this.gbKhachHang.ResumeLayout(false);
            this.gbKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHoTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pQuanLiTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pHoTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel pl_phong;
    }
}