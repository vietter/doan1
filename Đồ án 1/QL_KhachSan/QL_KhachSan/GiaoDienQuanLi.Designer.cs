﻿namespace QL_KhachSan
{
    partial class GiaoDienQuanLi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbTenChiNhanh = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yêuCầuCủaKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoHằngNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pl_phong = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào Quản Lí";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTen.ForeColor = System.Drawing.Color.Blue;
            this.lbTen.Location = new System.Drawing.Point(146, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(78, 22);
            this.lbTen.TabIndex = 5;
            this.lbTen.Text = "Tên QL";
            // 
            // lbTenChiNhanh
            // 
            this.lbTenChiNhanh.AutoSize = true;
            this.lbTenChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTenChiNhanh.ForeColor = System.Drawing.Color.Red;
            this.lbTenChiNhanh.Location = new System.Drawing.Point(263, 24);
            this.lbTenChiNhanh.Name = "lbTenChiNhanh";
            this.lbTenChiNhanh.Size = new System.Drawing.Size(151, 31);
            this.lbTenChiNhanh.TabIndex = 14;
            this.lbTenChiNhanh.Text = "Chi Nhánh";
            this.lbTenChiNhanh.Click += new System.EventHandler(this.lbTenChiNhanh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLíToolStripMenuItem1
            // 
            this.quảnLíToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yêuCầuCủaKháchHàngToolStripMenuItem,
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem,
            this.báoCáoHằngNgàyToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLíToolStripMenuItem1.Name = "quảnLíToolStripMenuItem1";
            this.quảnLíToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.quảnLíToolStripMenuItem1.Text = "Quản lí";
            this.quảnLíToolStripMenuItem1.Click += new System.EventHandler(this.quảnLíToolStripMenuItem1_Click);
            // 
            // yêuCầuCủaKháchHàngToolStripMenuItem
            // 
            this.yêuCầuCủaKháchHàngToolStripMenuItem.Name = "yêuCầuCủaKháchHàngToolStripMenuItem";
            this.yêuCầuCủaKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.yêuCầuCủaKháchHàngToolStripMenuItem.Text = "Yêu cầu của khách hàng";
            this.yêuCầuCủaKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuCủaKháchHàngToolStripMenuItem_Click);
            // 
            // danhSáchPhòngChưaĐặtCọcToolStripMenuItem
            // 
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem.Name = "danhSáchPhòngChưaĐặtCọcToolStripMenuItem";
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem.Text = "DS Phòng chưa đặt cọc";
            this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhòngChưaĐặtCọcToolStripMenuItem_Click);
            // 
            // báoCáoHằngNgàyToolStripMenuItem
            // 
            this.báoCáoHằngNgàyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngDoanhThuToolStripMenuItem});
            this.báoCáoHằngNgàyToolStripMenuItem.Name = "báoCáoHằngNgàyToolStripMenuItem";
            this.báoCáoHằngNgàyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.báoCáoHằngNgàyToolStripMenuItem.Text = "Báo cáo ";
            // 
            // tổngDoanhThuToolStripMenuItem
            // 
            this.tổngDoanhThuToolStripMenuItem.Name = "tổngDoanhThuToolStripMenuItem";
            this.tổngDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tổngDoanhThuToolStripMenuItem.Text = "Tổng Doanh Thu ";
            this.tổngDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.tổngDoanhThuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pl_phong
            // 
            this.pl_phong.Location = new System.Drawing.Point(6, 99);
            this.pl_phong.Name = "pl_phong";
            this.pl_phong.Size = new System.Drawing.Size(808, 352);
            this.pl_phong.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GiaoDienQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(820, 463);
            this.ControlBox = false;
            this.Controls.Add(this.pl_phong);
            this.Controls.Add(this.lbTenChiNhanh);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoDienQuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí";
            this.Load += new System.EventHandler(this.GiaoDienQuanLi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbTenChiNhanh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuCủaKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoHằngNgàyToolStripMenuItem;
        private System.Windows.Forms.Panel pl_phong;
        private System.Windows.Forms.ToolStripMenuItem tổngDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngChưaĐặtCọcToolStripMenuItem;
    }
}