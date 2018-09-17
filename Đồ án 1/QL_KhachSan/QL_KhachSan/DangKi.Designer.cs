namespace QL_KhachSan
{
    partial class DangKi
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
            this.cbbCauHoi = new System.Windows.Forms.ComboBox();
            this.txtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.MaskedTextBox();
            this.txtTraLoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // cbbCauHoi
            // 
            this.cbbCauHoi.FormattingEnabled = true;
            this.cbbCauHoi.Items.AddRange(new object[] {
            "Tên ở nhà của bạn ?",
            "Tên vật nuôi nhà bạn ?",
            "Tên ba của bạn ?",
            "Tên mẹ của bạn ?",
            "Ngày kỉ niệm của bạn ?"});
            this.cbbCauHoi.Location = new System.Drawing.Point(135, 130);
            this.cbbCauHoi.Name = "cbbCauHoi";
            this.cbbCauHoi.Size = new System.Drawing.Size(288, 21);
            this.cbbCauHoi.TabIndex = 2;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(138, 50);
            this.txtSoDT.Mask = "(+84) 0000000000";
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(97, 20);
            this.txtSoDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Câu hỏi bảo mật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ĐĂNG KÍ";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(135, 86);
            this.txtCMND.Mask = "000000000";
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(97, 20);
            this.txtCMND.TabIndex = 7;
            this.txtCMND.ValidatingType = typeof(int);
            // 
            // txtTraLoi
            // 
            this.txtTraLoi.Location = new System.Drawing.Point(135, 176);
            this.txtTraLoi.Multiline = true;
            this.txtTraLoi.Name = "txtTraLoi";
            this.txtTraLoi.Size = new System.Drawing.Size(288, 56);
            this.txtTraLoi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trả lời:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXacNhan.Location = new System.Drawing.Point(324, 247);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(99, 40);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTroLai.Location = new System.Drawing.Point(191, 247);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(99, 40);
            this.btnTroLai.TabIndex = 11;
            this.btnTroLai.Text = "Trờ lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtTraLoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.cbbCauHoi);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.Text = "Đăng Kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCauHoi;
        private System.Windows.Forms.MaskedTextBox txtSoDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCMND;
        private System.Windows.Forms.TextBox txtTraLoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTroLai;
    }
}