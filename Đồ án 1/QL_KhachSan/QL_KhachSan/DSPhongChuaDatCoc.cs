using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.BS_layer;
namespace QL_KhachSan
{
    public partial class DSPhongChuaDatCoc : Form
    {
        public DSPhongChuaDatCoc()
        {
            InitializeComponent();
            pl_phong.AutoScroll = false;
            pl_phong.HorizontalScroll.Enabled = false;
            pl_phong.HorizontalScroll.Visible = false;
            pl_phong.HorizontalScroll.Maximum = 0;
            pl_phong.AutoScroll = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DSPhongChuaDatCoc_Load(object sender, EventArgs e)
        {
            load();
            timer1.Interval = 1000;
            timer1.Start();
        }
        public void load()
        {
            Point vitribandau = new Point(20, 20);
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaChiNhanh = machinhanh;
            BO_QuanLiChiNhanh hienthi = new BO_QuanLiChiNhanh();
            DataSet table = new DataSet();
            table = hienthi.HienThiPhongChuaDatCoc(hoadon);
            if(table.Tables.Count >0 && table.Tables[0].Rows.Count >0)
            {
                for(int i =0;i<table.Tables[0].Rows.Count;i++)
                {
                    if(i == 5)
                    {
                        PhongChuaDatCoc phong = new PhongChuaDatCoc();
                        phong.MAHD = table.Tables[0].Rows[i][3].ToString();
                        phong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                        DataSet laytenphong = new DataSet();
                        DTO_Phong phong1 = new DTO_Phong();
                        phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                        phong1.MaChiNhanh = machinhanh;
                        laytenphong = hienthi.LayTenPhong(phong1);
                        phong.TENPHONG = laytenphong.Tables[0].Rows[0][2].ToString();
                        DateTime ngaythuchien = new DateTime(int.Parse("20"+table.Tables[0].Rows[i][13].ToString().Substring(6,2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(3, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(0, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(9, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(12, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(15, 2)));  
                        phong.THOIGIANTHUCHIEN = ngaythuchien;
                        pl_phong.Controls.Add(phong);
                        vitribandau.X = 20;
                        vitribandau.Y = 150;
                        phong.Location = vitribandau;
                        vitribandau.Y += 165;
                    }
                    else
                    {
                        if (i == 10)
                        {
                            PhongChuaDatCoc phong = new PhongChuaDatCoc();
                            phong.MAHD = table.Tables[0].Rows[i][3].ToString();
                            phong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                            DataSet laytenphong = new DataSet();
                            DTO_Phong phong1 = new DTO_Phong();
                            phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                            phong1.MaChiNhanh = machinhanh;
                            laytenphong = hienthi.LayTenPhong(phong1);
                            phong.TENPHONG = laytenphong.Tables[0].Rows[0][2].ToString();
                            DateTime ngaythuchien = new DateTime(int.Parse("20" + table.Tables[0].Rows[i][13].ToString().Substring(6, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(3, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(0, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(9, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(12, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(15, 2)));
                            phong.THOIGIANTHUCHIEN = ngaythuchien;
                            pl_phong.Controls.Add(phong);
                            vitribandau.X = 20;
                            vitribandau.Y = 230;
                            phong.Location = vitribandau;
                            vitribandau.Y += 165;
                        }
                        else
                        {
                            if(i ==15)
                            {
                                PhongChuaDatCoc phong = new PhongChuaDatCoc();
                                phong.MAHD = table.Tables[0].Rows[i][3].ToString();
                                phong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                                DataSet laytenphong = new DataSet();
                                DTO_Phong phong1 = new DTO_Phong();
                                phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                                phong1.MaChiNhanh = machinhanh;
                                laytenphong = hienthi.LayTenPhong(phong1);
                                phong.TENPHONG = laytenphong.Tables[0].Rows[0][2].ToString();
                                DateTime ngaythuchien = new DateTime(int.Parse("20" + table.Tables[0].Rows[i][13].ToString().Substring(6, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(3, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(0, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(9, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(12, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(15, 2)));
                                phong.THOIGIANTHUCHIEN = ngaythuchien;
                                pl_phong.Controls.Add(phong);
                                vitribandau.X = 20;
                                vitribandau.Y = 360;
                                phong.Location = vitribandau;
                                vitribandau.Y += 165;
                            }
                            else
                            {
                                PhongChuaDatCoc phong = new PhongChuaDatCoc();
                                phong.MAHD = table.Tables[0].Rows[i][3].ToString();
                                phong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                                DataSet laytenphong = new DataSet();
                                DTO_Phong phong1 = new DTO_Phong();
                                phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                                phong1.MaChiNhanh = machinhanh;
                                laytenphong = hienthi.LayTenPhong(phong1);
                                phong.TENPHONG = laytenphong.Tables[0].Rows[0][2].ToString();
                                DateTime ngaythuchien = new DateTime(int.Parse("20" + table.Tables[0].Rows[i][13].ToString().Substring(6, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(3, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(0, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(9, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(12, 2)), int.Parse(table.Tables[0].Rows[i][13].ToString().Substring(15, 2)));
                                phong.THOIGIANTHUCHIEN = ngaythuchien;
                                pl_phong.Controls.Add(phong);
                                phong.Location = vitribandau;
                                vitribandau.Y += 165;
                            }
                        }
                    }
                }
            }
        }
        private string manv;
        private string tennv;
        private string machinhanh;
        private string tenchinhanh;
        public string MANV
        {
            set
            {
                manv = value;
            }
        }
        public string TENNV
        {
            set
            {
                tennv = value;  
            }
        }
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
            }
        }
        public string TENCHINHANH
        {
            set
            {
                tenchinhanh = value;
            }
        }
        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienQuanLi giaoDienQuanLi = new GiaoDienQuanLi();
            giaoDienQuanLi.MANV = manv;
            giaoDienQuanLi.TENNV = tennv;
            giaoDienQuanLi.MACHINHANH = machinhanh;
            giaoDienQuanLi.TENCHINHANH = tenchinhanh;
            giaoDienQuanLi.ShowDialog();
            this.Close();
        }
    }
}
