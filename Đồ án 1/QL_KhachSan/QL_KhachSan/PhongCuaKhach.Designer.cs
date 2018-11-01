namespace QL_KhachSan
{
    partial class PhongCuaKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongCuaKhach));
            this.label = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lb_ngaydat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(15, 122);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 18);
            this.label.TabIndex = 11;
            this.label.Text = "phòng";
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(9, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 95);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // lb_ngaydat
            // 
            this.lb_ngaydat.AutoSize = true;
            this.lb_ngaydat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ngaydat.Location = new System.Drawing.Point(27, 4);
            this.lb_ngaydat.Name = "lb_ngaydat";
            this.lb_ngaydat.Size = new System.Drawing.Size(63, 18);
            this.lb_ngaydat.TabIndex = 12;
            this.lb_ngaydat.Text = "ngày đặt";
            // 
            // PhongCuaKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_ngaydat);
            this.Controls.Add(this.label);
            this.Controls.Add(this.picture);
            this.Name = "PhongCuaKhach";
            this.Size = new System.Drawing.Size(119, 139);
            this.Load += new System.EventHandler(this.PhongCuaKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lb_ngaydat;
    }
}
