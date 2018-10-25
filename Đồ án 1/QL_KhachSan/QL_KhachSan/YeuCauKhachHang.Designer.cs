namespace QL_KhachSan
{
    partial class YeuCauKhachHang
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
            this.pl_YeuCau = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TenChiNhanh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pl_YeuCau
            // 
            this.pl_YeuCau.Location = new System.Drawing.Point(10, 94);
            this.pl_YeuCau.Name = "pl_YeuCau";
            this.pl_YeuCau.Size = new System.Drawing.Size(808, 352);
            this.pl_YeuCau.TabIndex = 0;
            this.pl_YeuCau.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_YeuCau_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách yêu cầu dịch vụ của khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(326, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi nhánh:";
            // 
            // lb_TenChiNhanh
            // 
            this.lb_TenChiNhanh.AutoSize = true;
            this.lb_TenChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TenChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_TenChiNhanh.Location = new System.Drawing.Point(399, 44);
            this.lb_TenChiNhanh.Name = "lb_TenChiNhanh";
            this.lb_TenChiNhanh.Size = new System.Drawing.Size(106, 16);
            this.lb_TenChiNhanh.TabIndex = 3;
            this.lb_TenChiNhanh.Text = "Tên Chi nhánh";
            // 
            // YeuCauKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.lb_TenChiNhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl_YeuCau);
            this.Name = "YeuCauKhachHang";
            this.Text = "YeuCauKhachHang";
            this.Load += new System.EventHandler(this.YeuCauKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_YeuCau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TenChiNhanh;
    }
}