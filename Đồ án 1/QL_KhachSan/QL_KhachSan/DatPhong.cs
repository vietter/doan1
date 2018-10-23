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
    public partial class DatPhong : Form
    {
        private string MaHDMoi;
        private string chuoiMaHD;
        private string MaHD;
        private string MaPhong;
        private string sdt;
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
            }
        }
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        public DatPhong()
        {
          
            InitializeComponent();
            pl_phong.AutoScroll = false;
            pl_phong.HorizontalScroll.Enabled = false;
            pl_phong.HorizontalScroll.Visible = false;
            pl_phong.HorizontalScroll.Maximum = 0;
            pl_phong.AutoScroll = true;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
         

        }
        private void load()
        {
            pl_phong.Controls.Clear();
        }

      
     
        private void pTimKiem_Click(object sender, EventArgs e)
        {
            load();

            if (cbbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nơi ở", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {

                if (cbbDiaChi.Text == "Đà Lạt")
                {
                    MaHD = "DL";
                }
                else
                {
                    if (cbbDiaChi.Text == "Hồ Chí Minh")
                    {
                        MaHD = "HCM";
                    }
                    else
                    {
                        if (cbbDiaChi.Text == "Đà Nẵng")
                        {
                            MaHD = "DN";
                        }
                        else
                        {
                            if (cbbDiaChi.Text == "Nha Trang")
                            {
                                MaHD = "NT";
                            }
                            else
                            {
                                MaHD = "PQ";
                            }
                        }
                    }
                }
                if (dtpNgayDat.Text == dtpNgayTra.Text)
                {
                    MessageBox.Show("Ngày đặt và ngày trả trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    TimeSpan ts = new TimeSpan();
                    int NgayDat = int.Parse(dtpNgayDat.Text.Substring(0, 2));
                    int ThangDat = int.Parse(dtpNgayDat.Text.Substring(3, 2));
                    int NamDat = int.Parse(dtpNgayDat.Text.Substring(6, 4));
                    int GioDatPhong = 12;
                    int PhutDatPhong = 00;
                    int NgayTra = int.Parse(dtpNgayTra.Text.Substring(0, 2));
                    int ThangTra = int.Parse(dtpNgayTra.Text.Substring(3, 2));
                    int NamTra = int.Parse(dtpNgayTra.Text.Substring(6, 4));
                    int GioTraPhong = 12;
                    int PhutTraPhong = 00;
                    DateTime NgayDatPhong = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                    DateTime NgayTraPhong = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
                    ts = NgayTraPhong - NgayDatPhong;
                    if (ts.TotalDays < 0)
                    {
                        MessageBox.Show("Ngày Đặt Phòng không thể sau ngày Trả Phòng được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (NgayDatPhong.Day < DateTime.Now.Day)
                        {
                            MessageBox.Show("Bạn không thể đặt trong quá khứ được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        else
                        {
                            DTO_Phong phong = new DTO_Phong();
                            if (cbb_SoNguoi.Text == "1-2 người (2 giường đơn)")
                            {
                                phong.SoNguoi = 2;
                                phong.LoaiPhong = "Giường đơn";
                            }
                            else
                            {
                                if (cbb_SoNguoi.Text == "2 người (giường đôi)")
                                {
                                    phong.SoNguoi = 2;
                                    phong.LoaiPhong = "Giường đôi";

                                }
                                else
                                {
                                    if (cbb_SoNguoi.Text == "3-4 người (4 giường đơn)")
                                    {
                                        phong.SoNguoi = 4;
                                        phong.LoaiPhong = "Giường đơn";

                                    }
                                    else
                                    {
                                        if (cbb_SoNguoi.Text == "3-4 người (2 giường đôi)")
                                        {
                                            phong.SoNguoi = 4;
                                            phong.LoaiPhong = "Giường đôi";

                                        }
                                        else
                                        {
                                            if (cbb_SoNguoi.Text == "5-6 người (3 giường đôi)")
                                            {
                                                phong.SoNguoi = 6;
                                                phong.LoaiPhong = "Giường đôi";
                                            }
                                            else
                                            {
                                                if (cbb_SoNguoi.Text == "")
                                                {
                                                    phong.SDT = "Free"
     ;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            Point vitribandau = new Point(5, 5);
                            phong.MaChiNhanh = MaHD;
                            BO_DatPhong kiemtra = new BO_DatPhong();
                            if (cbb_SoNguoi.Text == "")
                            {
                                DataSet table = new DataSet();
                                BO_DatPhong tatcaphong = new BO_DatPhong();
                                table = tatcaphong.showall(phong);
                                if (table.Tables.Count > 0 && table.Tables[0].Rows.Count > 0)
                                {
                                    for (int i = 0; i < table.Tables[0].Rows.Count; i++)
                                    {
                                        if (table.Tables[0].Rows[i][4].ToString() == "Giường đôi" && table.Tables[0].Rows[i][5].ToString() == "2")
                                        {
                                            giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                            hienthi.Location = vitribandau;
                                            hienthi.Location = vitribandau;                                            
                                            hienthi.TENVTCHINHANH = MaHD;
                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                            hienthi.SDT = sdt;
                                            hienthi.CHINHANH = MaHD;
                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                            pl_phong.Controls.Add(hienthi);
                                            vitribandau.Y += 220;
                                        }
                                        else
                                        {
                                            if (table.Tables[0].Rows[i][4].ToString() == "Giường đơn" && table.Tables[0].Rows[i][5].ToString() == "2")
                                            {
                                                giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                                hienthi.Location = vitribandau;
                                                hienthi.Location = vitribandau;
                                                hienthi.TENVTCHINHANH = MaHD;
                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                hienthi.CHINHANH = MaHD;
                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                hienthi.SDT = sdt;
                                                pl_phong.Controls.Add(hienthi);
                                                vitribandau.Y += 220;
                                            }
                                            else
                                            {
                                                if (table.Tables[0].Rows[i][4].ToString() == "Giường đôi" && table.Tables[0].Rows[i][5].ToString() == "4")
                                                {
                                                    giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                    hienthi.Location = vitribandau;
                                                    hienthi.Location = vitribandau;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.CHINHANH = MaHD;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.SDT = sdt;
                                                    pl_phong.Controls.Add(hienthi);
                                                    vitribandau.Y += 220;
                                                }
                                                else
                                                {
                                                    if (table.Tables[0].Rows[i][4].ToString() == "Giường đơn" && table.Tables[0].Rows[i][5].ToString() == "4")
                                                    {
                                                        giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                        hienthi.Location = vitribandau;
                                                        hienthi.Location = vitribandau;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.CHINHANH = MaHD;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.SDT = sdt;
                                                        pl_phong.Controls.Add(hienthi);
                                                        vitribandau.Y += 220;
                                                    }
                                                    else
                                                    {
                                                        giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                        hienthi.Location = vitribandau;
                                                        hienthi.Location = vitribandau;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.CHINHANH = MaHD;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.SDT = sdt;
                                                        pl_phong.Controls.Add(hienthi);
                                                        vitribandau.Y += 220;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {

                                DataSet result = kiemtra.KiemTraPhongTrong(phong);
                                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                                {

                                    if (cbb_SoNguoi.Text == "1-2 người (2 giường đơn)")
                                    {
                                        for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                                        {
                                            giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                            hienthi.Location = vitribandau;
                                            hienthi.TENVTCHINHANH = MaHD;
                                            hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                            hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                            hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                            hienthi.CHINHANH = MaHD;
                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                            hienthi.SDT = sdt;
                                            pl_phong.Controls.Add(hienthi);
                                            vitribandau.Y += 220;
                                        }
                                    }
                                    else
                                    {
                                        if (cbb_SoNguoi.Text == "2 người (giường đôi)")
                                        {
                                            for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                                            {
                                                giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                                hienthi.Location = vitribandau;
                                                hienthi.Location = vitribandau;
                                                hienthi.TENVTCHINHANH = MaHD;
                                                hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                                hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                                hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                hienthi.CHINHANH = MaHD;
                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                hienthi.SDT = sdt;
                                                pl_phong.Controls.Add(hienthi);
                                                vitribandau.Y += 220;
                                            }

                                        }
                                        else
                                        {
                                            if (cbb_SoNguoi.Text == "3-4 người (4 giường đơn)")
                                            {
                                                for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                                                {
                                                    giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                    hienthi.Location = vitribandau;
                                                    hienthi.Location = vitribandau;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                                    hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                                    hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.CHINHANH = MaHD;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.SDT = sdt;
                                                    pl_phong.Controls.Add(hienthi);
                                                    vitribandau.Y += 220;
                                                }
                                            }
                                            else
                                            {
                                                if (cbb_SoNguoi.Text == "3-4 người (2 giường đôi)")
                                                {
                                                    for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                                                    {
                                                        giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                        hienthi.Location = vitribandau;
                                                        hienthi.Location = vitribandau;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                                        hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                                        hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.CHINHANH = MaHD;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.SDT = sdt;
                                                        pl_phong.Controls.Add(hienthi);
                                                        vitribandau.Y += 220;
                                                    }

                                                }
                                                else
                                                {
                                                    if (cbb_SoNguoi.Text == "5-6 người (3 giường đôi)")
                                                    {
                                                        for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                                                        {
                                                            giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                            hienthi.Location = vitribandau;
                                                            hienthi.TENVTCHINHANH = MaHD;
                                                            hienthi.Location = vitribandau;
                                                            hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                                            hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                                            hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                            hienthi.CHINHANH = MaHD;
                                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                            hienthi.SDT = sdt;
                                                            pl_phong.Controls.Add(hienthi);
                                                            vitribandau.Y += 220;
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }



                                else
                                {
                                    MessageBox.Show("Phòng của chi nhánh này đã hết, hãy liên hệ với nhân viên khi có phòng chúng tôi sẽ liên hệ lại bạn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                }
            }
        }


    
 
       

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi dangki = new DangKi();
            dangki.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pl_phong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
