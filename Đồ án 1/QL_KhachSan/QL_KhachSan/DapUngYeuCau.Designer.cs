namespace QL_KhachSan
{
    partial class DapUngYeuCau
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
            this.bntTroVe = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThucHien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TenYC = new System.Windows.Forms.Label();
            this.lb_SL = new System.Windows.Forms.Label();
            this.lb_TenPhong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntTroVe
            // 
            this.bntTroVe.Location = new System.Drawing.Point(12, 146);
            this.bntTroVe.Name = "bntTroVe";
            this.bntTroVe.Size = new System.Drawing.Size(75, 23);
            this.bntTroVe.TabIndex = 1;
            this.bntTroVe.Text = "Trở về";
            this.bntTroVe.UseVisualStyleBackColor = true;
            this.bntTroVe.Click += new System.EventHandler(this.bntTroVe_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(120, 146);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 2;
            this.bntXoa.Text = "Xóa ";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThucHien
            // 
            this.bntThucHien.Location = new System.Drawing.Point(220, 146);
            this.bntThucHien.Name = "bntThucHien";
            this.bntThucHien.Size = new System.Drawing.Size(75, 23);
            this.bntThucHien.TabIndex = 3;
            this.bntThucHien.Text = "Thực hiện";
            this.bntThucHien.UseVisualStyleBackColor = true;
            this.bntThucHien.Click += new System.EventHandler(this.bntThucHien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yêu Cầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // lb_TenYC
            // 
            this.lb_TenYC.AutoSize = true;
            this.lb_TenYC.Location = new System.Drawing.Point(86, 56);
            this.lb_TenYC.Name = "lb_TenYC";
            this.lb_TenYC.Size = new System.Drawing.Size(36, 13);
            this.lb_TenYC.TabIndex = 7;
            this.lb_TenYC.Text = "tên yc";
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.Location = new System.Drawing.Point(85, 97);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(47, 13);
            this.lb_SL.TabIndex = 8;
            this.lb_SL.Text = "số lượng";
            // 
            // lb_TenPhong
            // 
            this.lb_TenPhong.AutoSize = true;
            this.lb_TenPhong.Location = new System.Drawing.Point(86, 20);
            this.lb_TenPhong.Name = "lb_TenPhong";
            this.lb_TenPhong.Size = new System.Drawing.Size(22, 13);
            this.lb_TenPhong.TabIndex = 9;
            this.lb_TenPhong.Text = "tên";
            // 
            // DapUngYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 181);
            this.Controls.Add(this.lb_TenPhong);
            this.Controls.Add(this.lb_SL);
            this.Controls.Add(this.lb_TenYC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntThucHien);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntTroVe);
            this.Name = "DapUngYeuCau";
            this.Text = "DapUngYeuCau";
            this.Load += new System.EventHandler(this.DapUngYeuCau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntTroVe;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThucHien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TenYC;
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.Label lb_TenPhong;
    }
}