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
using System.Globalization;
namespace QL_KhachSan
{
    public partial class GiaoDienKhachHang : Form
    {
        private int tongtien =0;
        private int SoPhongDaDat;
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private string options;
        public string OPTIONS
        {
          set
            {
                options = value;
            }
        }
        public GiaoDienKhachHang()
        {
            InitializeComponent();
            pl_phong.AutoScroll = false;
            pl_phong.HorizontalScroll.Enabled = false;
            pl_phong.HorizontalScroll.Visible = false;
            pl_phong.HorizontalScroll.Maximum = 0;
            pl_phong.AutoScroll = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTaiKhoan quanli = new QuanLyTaiKhoan();
            quanli.SDT = sdt;
            quanli.ShowDialog();
            this.Close();

        }

        private void GiaoDienKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Load(object sender, EventArgs e)
        {
                        DS_Phong_Load();
        }
        private void DS_Phong_Load()
        {
            DTO_HoaDon thanhtien = new DTO_HoaDon();
            thanhtien.SoDienThoai = sdt;
            BO_DSPhongDaDat Tong = new BO_DSPhongDaDat();
            DataSet tong = Tong.TongTien(thanhtien);
            for(int i =0;i<tong.Tables[0].Rows.Count  ;i++)
            {
                tongtien += int.Parse(tong.Tables[0].Rows[i][0].ToString());
            }
            txtTongTien.Text = tongtien.ToString();
            DTO_HoaDon hoadon1 = new DTO_HoaDon();
            hoadon1.SoDienThoai = sdt;
            BO_DSPhongDaDat ds = new BO_DSPhongDaDat();
            DataSet result = ds.DSPhong(hoadon1);

            //gán vị trị khởi tạo user control

            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                Point vitribandau = new Point(5, 5);
                for(int i =0;i<result.Tables[0].Rows.Count;i++)
                {
                    DateTime ngaydat = new DateTime(int.Parse("20" + result.Tables[0].Rows[i][8].ToString().Substring(6, 2)), int.Parse(result.Tables[0].Rows[i][8].ToString().Substring(3, 2)), int.Parse(result.Tables[0].Rows[i][8].ToString().Substring(0, 2)));
                    DateTime ngaytra = new DateTime(int.Parse("20" + result.Tables[0].Rows[i][9].ToString().Substring(6, 2)), int.Parse(result.Tables[0].Rows[i][9].ToString().Substring(3, 2)), int.Parse(result.Tables[0].Rows[i][9].ToString().Substring(0, 2)));
                    TimeSpan ts = new TimeSpan();
                    ts = ngaytra - ngaydat;
                    for(int j = 0;j<ts.TotalDays +1;j++)
                    {
                        DemThoiGian.Add(ngaydat);
                        ngaydat = ngaydat.AddDays(1);
                    }
                    int count = 0;
                    foreach(DateTime songaytrung in DemThoiGian)
                    {
                        if(songaytrung.ToShortDateString()==DateTime.Now.ToShortDateString())
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        DTO_Phong phong = new DTO_Phong();
                        phong.MaChiNhanh = result.Tables[0].Rows[i][5].ToString();
                        phong.MaPhong = result.Tables[0].Rows[i][6].ToString();
                        BO_DSPhongDaDat loaiphong = new BO_DSPhongDaDat();
                        DataSet table = new DataSet();
                        table = loaiphong.HienThiPhong(phong);
                        if (table.Tables.Count > 0 && table.Tables[0].Rows.Count > 0)
                        {
                            if (table.Tables[0].Rows[0][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[0][4].ToString() == "2")
                            {
                                giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                hienthi.SDT = sdt;
                                hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                hienthi.MACHINHANH = table.Tables[0].Rows[0][1].ToString();
                                hienthi.MAPHONG = table.Tables[0].Rows[0][0].ToString();
                                hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                hienthi.OPTIONS = "TuyChon";
                                hienthi.MAHD = result.Tables[0].Rows[i][3].ToString();
                                hienthi.Location = vitribandau;
                                pl_phong.Controls.Add(hienthi);
                                vitribandau.Y += 220;
                            }
                            else
                            {
                                if (table.Tables[0].Rows[0][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[0][4].ToString() == "2")
                                {
                                    giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                    hienthi.SDT = sdt;
                                    hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                    hienthi.MACHINHANH = table.Tables[0].Rows[0][1].ToString();
                                    hienthi.MAPHONG = table.Tables[0].Rows[0][0].ToString();
                                    hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                    hienthi.OPTIONS = "TuyChon";
                                    hienthi.MAHD = result.Tables[0].Rows[i][3].ToString();
                                    hienthi.Location = vitribandau;
                                    pl_phong.Controls.Add(hienthi);
                                    vitribandau.Y += 220;
                                }
                                else
                                {
                                    if (table.Tables[0].Rows[0][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[0][4].ToString() == "4")
                                    {
                                        giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                        hienthi.SDT = sdt;
                                        hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                        hienthi.MACHINHANH = table.Tables[0].Rows[0][1].ToString();
                                        hienthi.MAPHONG = table.Tables[0].Rows[0][0].ToString();
                                        hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                        hienthi.OPTIONS = "TuyChon";
                                        hienthi.MAHD = result.Tables[0].Rows[i][3].ToString();
                                        hienthi.Location = vitribandau;
                                        pl_phong.Controls.Add(hienthi);
                                        vitribandau.Y += 220;
                                    }
                                    else
                                    {
                                        if (table.Tables[0].Rows[0][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[0][4].ToString() == "4")
                                        {
                                            giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                            hienthi.SDT = sdt;
                                            hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                            hienthi.MACHINHANH = table.Tables[0].Rows[0][1].ToString();
                                            hienthi.MAPHONG = table.Tables[0].Rows[0][0].ToString();
                                            hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                            hienthi.OPTIONS = "TuyChon";
                                            hienthi.MAHD = result.Tables[0].Rows[i][3].ToString();
                                            hienthi.Location = vitribandau;
                                            pl_phong.Controls.Add(hienthi);
                                            vitribandau.Y += 220;
                                        }
                                        else
                                        {
                                            if (table.Tables[0].Rows[0][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[0][4].ToString() == "6")
                                            {
                                                giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                hienthi.SDT = sdt;
                                                hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                                hienthi.MACHINHANH = table.Tables[0].Rows[0][1].ToString();
                                                hienthi.MAPHONG = table.Tables[0].Rows[0][0].ToString();
                                                hienthi.TENPHONG = table.Tables[0].Rows[0][2].ToString();
                                                hienthi.OPTIONS = "TuyChon";
                                                hienthi.MAHD = result.Tables[0].Rows[i][3].ToString();
                                                hienthi.Location = vitribandau;
                                                pl_phong.Controls.Add(hienthi);
                                                vitribandau.Y += 220;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        DemThoiGian.Clear();
                    }
                }
            }
           
        }

        List<DateTime> DemThoiGian = new List<DateTime>();

        private void pDatPhong_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            DatPhong datphong = new DatPhong();
            datphong.SDT = sdt;
            datphong.ShowDialog();
            this.Close();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTongTien.Text = String.Format(culture, "{0:N0}", value);
            txtTongTien.Select(txtTongTien.Text.Length, 0);
        }

        private void pHoTro_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoTroKhachHang hoTroKhachHang = new HoTroKhachHang();
            hoTroKhachHang.SDT = sdt;
            hoTroKhachHang.OPTIONS = options;
            hoTroKhachHang.ShowDialog();
            this.Close();

        }

        private void pl_phong_Enter(object sender, EventArgs e)
        {

        }

        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }
    }
}
