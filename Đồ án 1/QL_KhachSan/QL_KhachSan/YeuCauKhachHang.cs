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
    public partial class YeuCauKhachHang : Form
    {
        private string tennv;
        public string TENNV
        {
            set
            {
                tennv = value;
            }
        }
        private string manv;
        public string MANV
        {
            set
            {
                manv = value;
            }
        }

        private string tenchinhanh;
        public string TENCHINHANH
        {
            set
            {
                tenchinhanh = value;
            }
        }


        private string mahd;
        public string MAHD
        {
            set
            {
                mahd = value;
            }
        }

        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private string maphong;
        public string MAPHONG
        {
            set
            {
                maphong = value;
            }
        }
        private string machinhanh;
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
            }
        }
        private string tenphong;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
            }
        }
        public YeuCauKhachHang()
        {
            InitializeComponent();
            pl_YeuCau.AutoScroll = false;
            pl_YeuCau.HorizontalScroll.Enabled = false;
            pl_YeuCau.HorizontalScroll.Visible = false;
            pl_YeuCau.HorizontalScroll.Maximum = 0;
            pl_YeuCau.AutoScroll = true;
        }
        private List<YeuCau> danhsach = new List<YeuCau>();

        private void YeuCauKhachHang_Load(object sender, EventArgs e)
        {
            load();
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void load()
        {
            lb_TenChiNhanh.Text = tenchinhanh;
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaChiNhanh = machinhanh;
            BO_QuanLiChiNhanh yeucau = new BO_QuanLiChiNhanh();
            DataSet result = yeucau.HienThiYeuCau(hoadon);
            Point vitridau = new Point(20, 20);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                int demyeucau = result.Tables[0].Rows.Count;
                for (int i = 0; i < demyeucau; i++)
                {
                    if (i == 5)
                    {
                        
                        
                        YeuCau request = new YeuCau();
                        request.MAPHONG = result.Tables[0].Rows[i][6].ToString() ;
                        DTO_Phong phong = new DTO_Phong();
                        phong.MaChiNhanh = machinhanh;
                        phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                        BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
                        DataSet table = quanli.LayTenPhong(phong);
                        request.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                        request.TENCHINHANH = tenchinhanh;
                        request.MACHINHANH = machinhanh;
                        request.TENDV = result.Tables[0].Rows[i][0].ToString();
                        request.SOLUONG = result.Tables[0].Rows[i][1].ToString();
                        request.TENNV = tennv;
                        request.THOIGIAN = DateTime.Parse(result.Tables[0].Rows[i][8].ToString());
                        request.MAHD = result.Tables[0].Rows[i][3].ToString();
                        request.MANV = manv;
                        request.STT = int.Parse(result.Tables[0].Rows[i][4].ToString());
                        pl_YeuCau.Controls.Add(request);
                        vitridau.X = 20;
                        vitridau.Y = 150;
                        request.Location = vitridau;
                        vitridau.X += 165;
                        danhsach.Add(request);
                    }
                    else
                    {
                        if (i == 10)
                        {
                            YeuCau request = new YeuCau();
                            request.MAPHONG = result.Tables[0].Rows[i][6].ToString();
                            DTO_Phong phong = new DTO_Phong();
                            phong.MaChiNhanh = machinhanh;
                            phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                            BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
                            DataSet table = quanli.LayTenPhong(phong);
                            request.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                            request.TENCHINHANH = tenchinhanh;
                            request.MAHD = result.Tables[0].Rows[i][3].ToString();
                            request.MACHINHANH = machinhanh;
                            request.THOIGIAN = DateTime.Parse(result.Tables[0].Rows[i][8].ToString());
                            request.TENDV = result.Tables[0].Rows[i][0].ToString();
                            request.STT = int.Parse(result.Tables[0].Rows[i][4].ToString());
                            request.SOLUONG = result.Tables[0].Rows[i][1].ToString();
                            request.TENNV = tennv;
                            request.MANV = manv;
                            pl_YeuCau.Controls.Add(request);
                            vitridau.X = 20;
                            vitridau.Y = 280;
                            request.Location = vitridau;
                            vitridau.X += 165;
                            danhsach.Add(request);
                        }
                        else
                        {
                            
                                if (i == 15)
                                {
                                    YeuCau request = new YeuCau();
                                    request.MAPHONG = result.Tables[0].Rows[i][6].ToString();
                                    DTO_Phong phong = new DTO_Phong();
                                    phong.MaChiNhanh = machinhanh;
                                    phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                                    BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
                                    DataSet table = quanli.LayTenPhong(phong);
                                    request.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                    request.MAHD = result.Tables[0].Rows[i][3].ToString();
                                    request.TENCHINHANH = tenchinhanh;
                                    request.THOIGIAN = DateTime.Parse(result.Tables[0].Rows[i][8].ToString());
                                    request.MACHINHANH = machinhanh;
                                    request.TENDV = result.Tables[0].Rows[i][0].ToString();
                                    request.STT = int.Parse(result.Tables[0].Rows[i][4].ToString());
                                    request.SOLUONG = result.Tables[0].Rows[i][1].ToString();
                                    request.TENNV = tennv;
                                    request.MANV = manv;
                                    pl_YeuCau.Controls.Add(request);
                                    vitridau.X = 20;
                                    vitridau.Y = 410;
                                    request.Location = vitridau;
                                    vitridau.X += 165;
                                    danhsach.Add(request);
                            }
                                else
                            {
                                if(i == 20)
                                {
                                    YeuCau request = new YeuCau();
                                    request.MAPHONG = result.Tables[0].Rows[i][6].ToString();
                                    DTO_Phong phong = new DTO_Phong();
                                    phong.MaChiNhanh = machinhanh;
                                    phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                                    BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
                                    DataSet table = quanli.LayTenPhong(phong);
                                    request.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                    request.TENCHINHANH = tenchinhanh;
                                    request.THOIGIAN = DateTime.Parse(result.Tables[0].Rows[i][8].ToString());
                                    request.TENDV = result.Tables[0].Rows[i][0].ToString();
                                    request.MAHD = result.Tables[0].Rows[i][3].ToString();
                                    request.SOLUONG = result.Tables[0].Rows[i][1].ToString();
                                    request.STT = int.Parse(result.Tables[0].Rows[i][4].ToString());
                                    request.MACHINHANH = machinhanh;
                                    request.TENNV = tennv;
                                    request.MANV = manv;
                                    pl_YeuCau.Controls.Add(request);
                                    vitridau.X = 20;
                                    vitridau.Y = 540;
                                    request.Location = vitridau;
                                    vitridau.X += 165;
                                    danhsach.Add(request);
                                }

                                else
                            {
                                    YeuCau request = new YeuCau();
                                    request.MAPHONG = result.Tables[0].Rows[i][6].ToString();
                                    DTO_Phong phong = new DTO_Phong();
                                    phong.MaChiNhanh = machinhanh;
                                    phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                                    BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
                                    DataSet table = quanli.LayTenPhong(phong);
                                    request.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                    request.TENCHINHANH = tenchinhanh;
                                    request.THOIGIAN = DateTime.Parse(result.Tables[0].Rows[i][8].ToString());
                                    request.TENDV = result.Tables[0].Rows[i][0].ToString();
                                    request.MAHD = result.Tables[0].Rows[i][3].ToString();
                                    request.STT = int.Parse(result.Tables[0].Rows[i][4].ToString());
                                    request.SOLUONG = result.Tables[0].Rows[i][1].ToString();
                                    request.MACHINHANH = machinhanh;
                                    request.TENNV = tennv;
                                    request.MANV = manv;
                                    pl_YeuCau.Controls.Add(request);
                                    request.Location = vitridau;
                                    vitridau.X += 165;
                                    danhsach.Add(request);
                                }
                            }
                            
                        }
                    }
                }

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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*foreach(YeuCau i in danhsach)
             {
                 i.Refresh();
             }*/
            this.Refresh();
        }

       
    }
}
