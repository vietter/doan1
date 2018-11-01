namespace QL_KhachSan
{
    partial class PhongChuaDatCoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongChuaDatCoc));
            this.picture = new System.Windows.Forms.PictureBox();
            this.lb_TenPhong = new System.Windows.Forms.Label();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(23, 7);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 95);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 11;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // lb_TenPhong
            // 
            this.lb_TenPhong.AutoSize = true;
            this.lb_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TenPhong.Location = new System.Drawing.Point(38, 102);
            this.lb_TenPhong.Name = "lb_TenPhong";
            this.lb_TenPhong.Size = new System.Drawing.Size(51, 18);
            this.lb_TenPhong.TabIndex = 12;
            this.lb_TenPhong.Text = "Phòng";
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ThoiGian.Location = new System.Drawing.Point(12, 0);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(72, 18);
            this.lb_ThoiGian.TabIndex = 13;
            this.lb_ThoiGian.Text = "Thời Gian";
            // 
            // PhongChuaDatCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.lb_TenPhong);
            this.Controls.Add(this.picture);
            this.Name = "PhongChuaDatCoc";
            this.Size = new System.Drawing.Size(147, 119);
            this.Load += new System.EventHandler(this.PhongChuaDatCoc_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PhongChuaDatCoc_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lb_TenPhong;
        private System.Windows.Forms.Label lb_ThoiGian;
    }
}
