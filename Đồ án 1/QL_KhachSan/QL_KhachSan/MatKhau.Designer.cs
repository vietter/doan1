namespace QL_KhachSan
{
    partial class MatKhau
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
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLinkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbSai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTen.Location = new System.Drawing.Point(86, 19);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(40, 20);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(90, 53);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(157, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(97, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nếu bạn quên mật khẩu hãy click vào";
            // 
            // lbLinkQuenMatKhau
            // 
            this.lbLinkQuenMatKhau.AutoSize = true;
            this.lbLinkQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLinkQuenMatKhau.Location = new System.Drawing.Point(345, 129);
            this.lbLinkQuenMatKhau.Name = "lbLinkQuenMatKhau";
            this.lbLinkQuenMatKhau.Size = new System.Drawing.Size(31, 18);
            this.lbLinkQuenMatKhau.TabIndex = 4;
            this.lbLinkQuenMatKhau.TabStop = true;
            this.lbLinkQuenMatKhau.Text = "đây";
            this.lbLinkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkQuenMatKhau_LinkClicked);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTroLai.Location = new System.Drawing.Point(12, 80);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(89, 30);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Trờ lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangNhap.Location = new System.Drawing.Point(284, 80);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(89, 30);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbSai
            // 
            this.lbSai.AutoSize = true;
            this.lbSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSai.ForeColor = System.Drawing.Color.Red;
            this.lbSai.Location = new System.Drawing.Point(253, 55);
            this.lbSai.Name = "lbSai";
            this.lbSai.Size = new System.Drawing.Size(127, 13);
            this.lbSai.TabIndex = 9;
            this.lbSai.Text = "Bạn chưa nhập mật khẩu";
            // 
            // MatKhau
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(382, 178);
            this.ControlBox = false;
            this.Controls.Add(this.lbSai);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.lbLinkQuenMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label1);
            this.Name = "MatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mật Khẩu";
            this.Load += new System.EventHandler(this.MatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbLinkQuenMatKhau;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lbSai;
    }
}