namespace QL_KhachSan
{
    partial class SoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoLuong));
            this.label7 = new System.Windows.Forms.Label();
            this.dmUDNumber = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pbXacNhan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số Lượng: ";
            // 
            // dmUDNumber
            // 
            this.dmUDNumber.Items.Add("0");
            this.dmUDNumber.Items.Add("1");
            this.dmUDNumber.Items.Add("2");
            this.dmUDNumber.Items.Add("3");
            this.dmUDNumber.Items.Add("4");
            this.dmUDNumber.Items.Add("5");
            this.dmUDNumber.Items.Add("6");
            this.dmUDNumber.Items.Add("7");
            this.dmUDNumber.Items.Add("8");
            this.dmUDNumber.Items.Add("9");
            this.dmUDNumber.Items.Add("10");
            this.dmUDNumber.Items.Add("11");
            this.dmUDNumber.Items.Add("12");
            this.dmUDNumber.Location = new System.Drawing.Point(114, 44);
            this.dmUDNumber.Name = "dmUDNumber";
            this.dmUDNumber.Size = new System.Drawing.Size(133, 20);
            this.dmUDNumber.TabIndex = 26;
            this.dmUDNumber.Text = "domainUpDown1";
            this.dmUDNumber.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // pbXacNhan
            // 
            this.pbXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("pbXacNhan.Image")));
            this.pbXacNhan.Location = new System.Drawing.Point(114, 84);
            this.pbXacNhan.Name = "pbXacNhan";
            this.pbXacNhan.Size = new System.Drawing.Size(71, 58);
            this.pbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXacNhan.TabIndex = 35;
            this.pbXacNhan.TabStop = false;
            this.pbXacNhan.Click += new System.EventHandler(this.pbXacNhan_Click);
            // 
            // SoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(302, 167);
            this.ControlBox = false;
            this.Controls.Add(this.pbXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dmUDNumber);
            this.Controls.Add(this.label7);
            this.Name = "SoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoLuong";
            this.Load += new System.EventHandler(this.SoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown dmUDNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbXacNhan;
    }
}