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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbDoiMatKhau = new System.Windows.Forms.RichTextBox();
            this.rtbDangXuat = new System.Windows.Forms.RichTextBox();
            this.rtbLichSu = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hỗ trợ khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đổi mật khẩu",
            "Đăng xuất",
            "Lịch sử giao dịch"});
            this.comboBox1.Location = new System.Drawing.Point(160, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Chọn danh mục ...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDoiMatKhau
            // 
            this.rtbDoiMatKhau.Location = new System.Drawing.Point(17, 62);
            this.rtbDoiMatKhau.Name = "rtbDoiMatKhau";
            this.rtbDoiMatKhau.ReadOnly = true;
            this.rtbDoiMatKhau.Size = new System.Drawing.Size(416, 96);
            this.rtbDoiMatKhau.TabIndex = 4;
            this.rtbDoiMatKhau.Text = "Để thực hiện bạn nhấn vào: nút Quản lí tài khoản -> Đổi mật khẩu, nhập mật khẩu m" +
    "ới 2 lần và thực hiện Xác nhận.";
            this.rtbDoiMatKhau.TextChanged += new System.EventHandler(this.rtbDoiMatKhau_TextChanged);
            // 
            // rtbDangXuat
            // 
            this.rtbDangXuat.Location = new System.Drawing.Point(17, 62);
            this.rtbDangXuat.Name = "rtbDangXuat";
            this.rtbDangXuat.ReadOnly = true;
            this.rtbDangXuat.Size = new System.Drawing.Size(416, 96);
            this.rtbDangXuat.TabIndex = 4;
            this.rtbDangXuat.Text = "Để thực hiện bạn nhấn vào: nút Quản lí tài khoản -> Đăng Xuất.";
            // 
            // rtbLichSu
            // 
            this.rtbLichSu.Location = new System.Drawing.Point(17, 62);
            this.rtbLichSu.Name = "rtbLichSu";
            this.rtbLichSu.ReadOnly = true;
            this.rtbLichSu.Size = new System.Drawing.Size(416, 96);
            this.rtbLichSu.TabIndex = 5;
            this.rtbLichSu.Text = "Để xem lịch sử giao dịch bạn nhấn vào: nút Quản lí tài khoản sẽ xuất hiện 1 bảng " +
    "những thông tin bạn đã thực hiện với chúng tôi.";
            // 
            // HoTroKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 170);
            this.Controls.Add(this.rtbLichSu);
            this.Controls.Add(this.rtbDangXuat);
            this.Controls.Add(this.rtbDoiMatKhau);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HoTroKhachHang";
            this.Text = "HoTroKhachHang";
            this.Load += new System.EventHandler(this.HoTroKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbDoiMatKhau;
        private System.Windows.Forms.RichTextBox rtbDangXuat;
        private System.Windows.Forms.RichTextBox rtbLichSu;
    }
}