namespace QL_KhachSan
{
    partial class QuenMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCauHoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTraLoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.MaskedTextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.lbTraLoi = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãy lựa chọn câu hỏi bí mật của bạn :";
            // 
            // cbbCauHoi
            // 
            this.cbbCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCauHoi.FormattingEnabled = true;
            this.cbbCauHoi.Items.AddRange(new object[] {
            "Tên ở nhà của bạn ?",
            "Tên vật nuôi nhà bạn ?",
            "Tên ba của bạn ?",
            "Tên mẹ của bạn ?",
            "Ngày kỉ niệm của bạn ?"});
            this.cbbCauHoi.Location = new System.Drawing.Point(259, 69);
            this.cbbCauHoi.Name = "cbbCauHoi";
            this.cbbCauHoi.Size = new System.Drawing.Size(288, 21);
            this.cbbCauHoi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trả lời:";
            // 
            // txtTraLoi
            // 
            this.txtTraLoi.Location = new System.Drawing.Point(259, 119);
            this.txtTraLoi.Multiline = true;
            this.txtTraLoi.Name = "txtTraLoi";
            this.txtTraLoi.Size = new System.Drawing.Size(288, 56);
            this.txtTraLoi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(195, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(259, 196);
            this.txtCMND.Mask = "000000000";
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PromptChar = ' ';
            this.txtCMND.Size = new System.Drawing.Size(61, 20);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.ValidatingType = typeof(int);
            this.txtCMND.Click += new System.EventHandler(this.txtCMND_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXacNhan.Location = new System.Drawing.Point(448, 237);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(99, 40);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTroLai.Location = new System.Drawing.Point(12, 237);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(107, 40);
            this.btnTroLai.TabIndex = 9;
            this.btnTroLai.Text = "Trờ lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.Red;
            this.lbCauHoi.Location = new System.Drawing.Point(256, 51);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(132, 15);
            this.lbCauHoi.TabIndex = 11;
            this.lbCauHoi.Text = "Bạn chưa chọn câu hỏi";
            // 
            // lbTraLoi
            // 
            this.lbTraLoi.AutoSize = true;
            this.lbTraLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTraLoi.ForeColor = System.Drawing.Color.Red;
            this.lbTraLoi.Location = new System.Drawing.Point(256, 101);
            this.lbTraLoi.Name = "lbTraLoi";
            this.lbTraLoi.Size = new System.Drawing.Size(142, 15);
            this.lbTraLoi.TabIndex = 12;
            this.lbTraLoi.Text = "Bạn chưa điền câu trả lời";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCMND.ForeColor = System.Drawing.Color.Red;
            this.lbCMND.Location = new System.Drawing.Point(256, 178);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(126, 15);
            this.lbCMND.TabIndex = 13;
            this.lbCMND.Text = "Bạn chưa điền CMND";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 289);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbTraLoi);
            this.Controls.Add(this.lbCauHoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTraLoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuenMatKhau";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTraLoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCMND;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.Label lbTraLoi;
        private System.Windows.Forms.Label lbCMND;
    }
}