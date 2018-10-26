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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLinkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lbSai = new System.Windows.Forms.Label();
            this.pbXacNhan = new System.Windows.Forms.PictureBox();
            this.pbTroVe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào";
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
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
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
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nếu bạn quên mật khẩu hãy click vào";
            // 
            // lbLinkQuenMatKhau
            // 
            this.lbLinkQuenMatKhau.AutoSize = true;
            this.lbLinkQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLinkQuenMatKhau.Location = new System.Drawing.Point(280, 154);
            this.lbLinkQuenMatKhau.Name = "lbLinkQuenMatKhau";
            this.lbLinkQuenMatKhau.Size = new System.Drawing.Size(31, 18);
            this.lbLinkQuenMatKhau.TabIndex = 4;
            this.lbLinkQuenMatKhau.TabStop = true;
            this.lbLinkQuenMatKhau.Text = "đây";
            this.lbLinkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkQuenMatKhau_LinkClicked);
            // 
            // lbSai
            // 
            this.lbSai.AutoSize = true;
            this.lbSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSai.ForeColor = System.Drawing.Color.Red;
            this.lbSai.Location = new System.Drawing.Point(87, 76);
            this.lbSai.Name = "lbSai";
            this.lbSai.Size = new System.Drawing.Size(144, 15);
            this.lbSai.TabIndex = 9;
            this.lbSai.Text = "Bạn chưa nhập mật khẩu";
            // 
            // pbXacNhan
            // 
            this.pbXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("pbXacNhan.Image")));
            this.pbXacNhan.Location = new System.Drawing.Point(261, 85);
            this.pbXacNhan.Name = "pbXacNhan";
            this.pbXacNhan.Size = new System.Drawing.Size(50, 48);
            this.pbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXacNhan.TabIndex = 32;
            this.pbXacNhan.TabStop = false;
            this.pbXacNhan.Click += new System.EventHandler(this.pbXacNhan_Click);
            // 
            // pbTroVe
            // 
            this.pbTroVe.Image = ((System.Drawing.Image)(resources.GetObject("pbTroVe.Image")));
            this.pbTroVe.Location = new System.Drawing.Point(21, 85);
            this.pbTroVe.Name = "pbTroVe";
            this.pbTroVe.Size = new System.Drawing.Size(51, 44);
            this.pbTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTroVe.TabIndex = 31;
            this.pbTroVe.TabStop = false;
            this.pbTroVe.Click += new System.EventHandler(this.pbTroVe_Click);
            // 
            // MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(336, 188);
            this.ControlBox = false;
            this.Controls.Add(this.pbXacNhan);
            this.Controls.Add(this.pbTroVe);
            this.Controls.Add(this.lbSai);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).EndInit();
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
        private System.Windows.Forms.Label lbSai;
        private System.Windows.Forms.PictureBox pbXacNhan;
        private System.Windows.Forms.PictureBox pbTroVe;
    }
}