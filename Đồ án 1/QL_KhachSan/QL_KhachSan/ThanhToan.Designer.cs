namespace QL_KhachSan
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbXacNhan = new System.Windows.Forms.PictureBox();
            this.pbTroVe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người đặt";
            // 
            // txtTenphong
            // 
            this.txtTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTenphong.Location = new System.Drawing.Point(96, 12);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.ReadOnly = true;
            this.txtTenphong.Size = new System.Drawing.Size(213, 24);
            this.txtTenphong.TabIndex = 2;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_Ten.Location = new System.Drawing.Point(529, 15);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(45, 20);
            this.lb_Ten.TabIndex = 3;
            this.lb_Ten.Text = "TÊN";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(13, 100);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(775, 251);
            this.dgvHienThi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(328, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "BẢNG DỊCH VỤ";
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTong.Location = new System.Drawing.Point(575, 370);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(213, 24);
            this.txtTong.TabIndex = 8;
            this.txtTong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(481, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng cộng";
            // 
            // pbXacNhan
            // 
            this.pbXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("pbXacNhan.Image")));
            this.pbXacNhan.Location = new System.Drawing.Point(732, 406);
            this.pbXacNhan.Name = "pbXacNhan";
            this.pbXacNhan.Size = new System.Drawing.Size(56, 43);
            this.pbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXacNhan.TabIndex = 36;
            this.pbXacNhan.TabStop = false;
            this.pbXacNhan.Click += new System.EventHandler(this.pbXacNhan_Click);
            // 
            // pbTroVe
            // 
            this.pbTroVe.Image = ((System.Drawing.Image)(resources.GetObject("pbTroVe.Image")));
            this.pbTroVe.Location = new System.Drawing.Point(13, 406);
            this.pbTroVe.Name = "pbTroVe";
            this.pbTroVe.Size = new System.Drawing.Size(50, 43);
            this.pbTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTroVe.TabIndex = 35;
            this.pbTroVe.TabStop = false;
            this.pbTroVe.Click += new System.EventHandler(this.pbTroVe_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pbXacNhan);
            this.Controls.Add(this.pbTroVe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.lb_Ten);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbXacNhan;
        private System.Windows.Forms.PictureBox pbTroVe;
    }
}