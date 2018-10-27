namespace QL_KhachSan
{
    partial class HoTroKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoTroKhachHang));
            this.cbbLuaChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTroVe = new System.Windows.Forms.PictureBox();
            this.rtbMatKhau = new System.Windows.Forms.RichTextBox();
            this.rtbDatPhong = new System.Windows.Forms.RichTextBox();
            this.rtbHuyPhong = new System.Windows.Forms.RichTextBox();
            this.rtbDangXuat = new System.Windows.Forms.RichTextBox();
            this.rtbThongTin = new System.Windows.Forms.RichTextBox();
            this.rtbDoiPhong = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbLuaChon
            // 
            this.cbbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLuaChon.FormattingEnabled = true;
            this.cbbLuaChon.Items.AddRange(new object[] {
            "Đổi Mật Khẩu",
            "Đặt Phòng",
            "Hủy Phòng",
            "Đổi Phòng",
            "Đăng Xuất",
            "Thông Tin Phòng Đã Đặt"});
            this.cbbLuaChon.Location = new System.Drawing.Point(10, 34);
            this.cbbLuaChon.Name = "cbbLuaChon";
            this.cbbLuaChon.Size = new System.Drawing.Size(202, 21);
            this.cbbLuaChon.TabIndex = 0;
            this.cbbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hỗ Trợ Khách Hàng";
            // 
            // pbTroVe
            // 
            this.pbTroVe.Image = ((System.Drawing.Image)(resources.GetObject("pbTroVe.Image")));
            this.pbTroVe.Location = new System.Drawing.Point(465, 15);
            this.pbTroVe.Name = "pbTroVe";
            this.pbTroVe.Size = new System.Drawing.Size(48, 40);
            this.pbTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTroVe.TabIndex = 29;
            this.pbTroVe.TabStop = false;
            this.pbTroVe.Click += new System.EventHandler(this.pbTroVe_Click);
            // 
            // rtbMatKhau
            // 
            this.rtbMatKhau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMatKhau.Location = new System.Drawing.Point(10, 61);
            this.rtbMatKhau.Name = "rtbMatKhau";
            this.rtbMatKhau.Size = new System.Drawing.Size(501, 98);
            this.rtbMatKhau.TabIndex = 30;
            this.rtbMatKhau.Text = "Tại giao diện khách hàng, click vào CÀI ĐẶT TÀI KHOẢN, chọn nút ĐỔI MẬT KHẨU, và " +
    "điền vào MẬT KHẨU MỚI ";
            this.rtbMatKhau.TextChanged += new System.EventHandler(this.rtbMatKhau_TextChanged);
            // 
            // rtbDatPhong
            // 
            this.rtbDatPhong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDatPhong.Location = new System.Drawing.Point(10, 61);
            this.rtbDatPhong.Name = "rtbDatPhong";
            this.rtbDatPhong.Size = new System.Drawing.Size(501, 98);
            this.rtbDatPhong.TabIndex = 31;
            this.rtbDatPhong.Text = "Tại giao diện khách hàng, click vào ĐẶT PHÒNG, lựa chọn NƠI ĐẶT, NGÀY ĐẶT PHÒNG, " +
    "NGÀY TRẢ PHÒNG và TÌM KIẾM, rồi chọn nút ĐẶT PHÒNG và XÁC NHẬN ";
            this.rtbDatPhong.TextChanged += new System.EventHandler(this.rtbDatPhong_TextChanged);
            // 
            // rtbHuyPhong
            // 
            this.rtbHuyPhong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHuyPhong.Location = new System.Drawing.Point(10, 61);
            this.rtbHuyPhong.Name = "rtbHuyPhong";
            this.rtbHuyPhong.Size = new System.Drawing.Size(501, 98);
            this.rtbHuyPhong.TabIndex = 32;
            this.rtbHuyPhong.Text = "Tại giao diện khách hàng, click vào TÙY CHỌN PHÒNG của phòng muốn hủy, chọn HỦY P" +
    "HÒNG ( lưu ý không thể hủy khi đã đặt quá 24 giờ)";
            // 
            // rtbDangXuat
            // 
            this.rtbDangXuat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDangXuat.Location = new System.Drawing.Point(10, 61);
            this.rtbDangXuat.Name = "rtbDangXuat";
            this.rtbDangXuat.Size = new System.Drawing.Size(501, 98);
            this.rtbDangXuat.TabIndex = 33;
            this.rtbDangXuat.Text = "Tại giao diện khách hàng, click vào QUẢN LÍ TÀI KHOẢN và chọn nút ĐĂNG XUẤT";
            // 
            // rtbThongTin
            // 
            this.rtbThongTin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbThongTin.Location = new System.Drawing.Point(10, 61);
            this.rtbThongTin.Name = "rtbThongTin";
            this.rtbThongTin.Size = new System.Drawing.Size(501, 98);
            this.rtbThongTin.TabIndex = 34;
            this.rtbThongTin.Text = "Tại giao diện khách hàng, click vào TÙY CHỌN PHÒNG vào phòng muốn xem thông tin c" +
    "ác dịch vụ đã đặt hoặc đặt thêm dịch vụ";
            // 
            // rtbDoiPhong
            // 
            this.rtbDoiPhong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDoiPhong.Location = new System.Drawing.Point(10, 61);
            this.rtbDoiPhong.Name = "rtbDoiPhong";
            this.rtbDoiPhong.Size = new System.Drawing.Size(501, 98);
            this.rtbDoiPhong.TabIndex = 35;
            this.rtbDoiPhong.Text = "Tại giao diện khách hàng, click vào TÙY CHỌN PHÒNG của phòng muốn đổi, sau đó chọ" +
    "n ĐỔI PHÒNG và lựa chọn phòng muốn đổi, chọn YES\n";
            // 
            // HoTroKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(523, 165);
            this.ControlBox = false;
            this.Controls.Add(this.rtbDoiPhong);
            this.Controls.Add(this.rtbThongTin);
            this.Controls.Add(this.rtbDangXuat);
            this.Controls.Add(this.rtbHuyPhong);
            this.Controls.Add(this.rtbDatPhong);
            this.Controls.Add(this.rtbMatKhau);
            this.Controls.Add(this.pbTroVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLuaChon);
            this.Name = "HoTroKhachHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoTroKhachHang";
            this.Load += new System.EventHandler(this.HoTroKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLuaChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTroVe;
        private System.Windows.Forms.RichTextBox rtbMatKhau;
        private System.Windows.Forms.RichTextBox rtbDatPhong;
        private System.Windows.Forms.RichTextBox rtbHuyPhong;
        private System.Windows.Forms.RichTextBox rtbDangXuat;
        private System.Windows.Forms.RichTextBox rtbThongTin;
        private System.Windows.Forms.RichTextBox rtbDoiPhong;
    }
}