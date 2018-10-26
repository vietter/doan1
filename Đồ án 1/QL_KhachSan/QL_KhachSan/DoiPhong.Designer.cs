namespace QL_KhachSan
{
    partial class DoiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiPhong));
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDSPhongTrong = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTroVe = new System.Windows.Forms.PictureBox();
            this.gbDSPhongTrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(135, 66);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.ReadOnly = true;
            this.txtSoPhong.Size = new System.Drawing.Size(219, 20);
            this.txtSoPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng Hiện Tại";
            // 
            // gbDSPhongTrong
            // 
            this.gbDSPhongTrong.Controls.Add(this.label5);
            this.gbDSPhongTrong.Controls.Add(this.label3);
            this.gbDSPhongTrong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSPhongTrong.Location = new System.Drawing.Point(1, 141);
            this.gbDSPhongTrong.Name = "gbDSPhongTrong";
            this.gbDSPhongTrong.Size = new System.Drawing.Size(804, 305);
            this.gbDSPhongTrong.TabIndex = 5;
            this.gbDSPhongTrong.TabStop = false;
            this.gbDSPhongTrong.Text = "Danh Sách Phòng Còn Trống";
            this.gbDSPhongTrong.Enter += new System.EventHandler(this.gbDSPhongTrong_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(733, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "money";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(647, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ĐỔI PHÒNG";
            // 
            // pbTroVe
            // 
            this.pbTroVe.Image = ((System.Drawing.Image)(resources.GetObject("pbTroVe.Image")));
            this.pbTroVe.Location = new System.Drawing.Point(15, 470);
            this.pbTroVe.Name = "pbTroVe";
            this.pbTroVe.Size = new System.Drawing.Size(54, 38);
            this.pbTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTroVe.TabIndex = 32;
            this.pbTroVe.TabStop = false;
            this.pbTroVe.Click += new System.EventHandler(this.pbTroVe_Click);
            // 
            // DoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(812, 511);
            this.ControlBox = false;
            this.Controls.Add(this.pbTroVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbDSPhongTrong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoPhong);
            this.Name = "DoiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Phòng";
            this.Load += new System.EventHandler(this.DoiPhong_Load);
            this.gbDSPhongTrong.ResumeLayout(false);
            this.gbDSPhongTrong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDSPhongTrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTroVe;
    }
}