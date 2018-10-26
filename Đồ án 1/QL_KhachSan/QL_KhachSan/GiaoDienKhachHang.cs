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
            DTO_Phong phong = new DTO_Phong();
            phong.SDT = sdt;
            BO_DSPhongDaDat ds = new BO_DSPhongDaDat();
            DataSet result = ds.DSPhong(phong);
            //gán vị trị khởi tạo user control
            
            if (result.Tables.Count >0 && result.Tables[0].Rows.Count >0)
            {
                Point vitribandau = new Point(5,5);
                
                SoPhongDaDat = result.Tables[0].Rows.Count;
                for(int i =0;i<SoPhongDaDat;i++)
                {

                    //tạo vị trí phòng đầu tiên
                   
                        if(result.Tables[0].Rows[i][5].ToString() == "2" && result.Tables[0].Rows[i][4].ToString() == "Giường đơn")
                        {
                            giuongdon2nguoi hienthi = new giuongdon2nguoi();
                            hienthi.SDT = sdt;
                            hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                            hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                            hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                            hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                            hienthi.OPTIONS = "TuyChon";
                            DTO_HoaDon hoadon = new DTO_HoaDon();
                            hoadon.MaPhong = result.Tables[0].Rows[i][0].ToString();
                            hoadon.MaChiNhanh = result.Tables[0].Rows[i][1].ToString();
                            hoadon.SoDienThoai = sdt;
                            BO_DSPhongDaDat laymahoadon = new BO_DSPhongDaDat();
                            DataSet KQ = laymahoadon.LayMaHD(hoadon);
                            hienthi.MAHD = KQ.Tables[0].Rows[0][0].ToString();
                            hienthi.Location = vitribandau;
                            pl_phong.Controls.Add(hienthi);
                            vitribandau.Y+= 220;
                        }
                        else
                        {
                            if(result.Tables[0].Rows[i][5].ToString() == "2" && result.Tables[0].Rows[i][4].ToString() == "Giường đôi")
                            {
                                giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                hienthi.SDT = sdt;
                                hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                hienthi.OPTIONS = "TuyChon";
                                DTO_HoaDon hoadon = new DTO_HoaDon();
                                hoadon.MaPhong = result.Tables[0].Rows[i][0].ToString();
                                hoadon.MaChiNhanh = result.Tables[0].Rows[i][1].ToString();
                                hoadon.SoDienThoai = sdt;
                                BO_DSPhongDaDat laymahoadon = new BO_DSPhongDaDat();
                                DataSet KQ = laymahoadon.LayMaHD(hoadon);
                            hienthi.MAHD = KQ.Tables[0].Rows[0][0].ToString();
                            hienthi.Location = vitribandau;
                            pl_phong.Controls.Add(hienthi);
                            vitribandau.Y += 220;

                        }
                            else
                            {
                            if (result.Tables[0].Rows[i][5].ToString() == "4" && result.Tables[0].Rows[i][4].ToString() == "Giường đôi")
                            {
                                giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                hienthi.SDT = sdt;
                                hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                hienthi.OPTIONS = "TuyChon";
                                DTO_HoaDon hoadon = new DTO_HoaDon();
                                hoadon.MaPhong = result.Tables[0].Rows[i][0].ToString();
                                hoadon.MaChiNhanh = result.Tables[0].Rows[i][1].ToString();
                                hoadon.SoDienThoai = sdt;
                                BO_DSPhongDaDat laymahoadon = new BO_DSPhongDaDat();
                                DataSet KQ = laymahoadon.LayMaHD(hoadon);
                                hienthi.MAHD = KQ.Tables[0].Rows[0][0].ToString();
                                hienthi.Location = vitribandau;
                                pl_phong.Controls.Add(hienthi);
                                vitribandau.Y += 220;
                            }
                            else
                            {
                                if (result.Tables[0].Rows[i][5].ToString() == "4" && result.Tables[0].Rows[i][4].ToString() == "Giường đơn")
                                {
                                    giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                    hienthi.SDT = sdt;
                                    hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                    hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                    hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                    hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                    hienthi.OPTIONS = "TuyChon";
                                    DTO_HoaDon hoadon = new DTO_HoaDon();
                                    hoadon.MaPhong = result.Tables[0].Rows[i][0].ToString();
                                    hoadon.MaChiNhanh = result.Tables[0].Rows[i][1].ToString();
                                    hoadon.SoDienThoai = sdt;
                                    BO_DSPhongDaDat laymahoadon = new BO_DSPhongDaDat();
                                    DataSet KQ = laymahoadon.LayMaHD(hoadon);
                                    hienthi.MAHD = KQ.Tables[0].Rows[0][0].ToString();
                                    hienthi.Location = vitribandau;
                                    pl_phong.Controls.Add(hienthi);
                                    vitribandau.Y += 220;

                                }
                                else
                                {
                                    giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                    hienthi.SDT = sdt;
                                    hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                    hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                                    hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                                    hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                                    hienthi.OPTIONS = "TuyChon";
                                    DTO_HoaDon hoadon = new DTO_HoaDon();
                                    hoadon.MaPhong = result.Tables[0].Rows[i][0].ToString();
                                    hoadon.MaChiNhanh = result.Tables[0].Rows[i][1].ToString();
                                    hoadon.SoDienThoai = sdt;
                                    BO_DSPhongDaDat laymahoadon = new BO_DSPhongDaDat();
                                    DataSet KQ = laymahoadon.LayMaHD(hoadon);
                                    hienthi.MAHD = KQ.Tables[0].Rows[0][0].ToString();
                                    hienthi.Location = vitribandau;
                                    pl_phong.Controls.Add(hienthi);
                                    vitribandau.Y += 220;
                                }
                            }
                            }
                        }
                        
                       
                   
                    }
             

                

            }
           
        }
        private void gbKhachHang_Enter(object sender, EventArgs e)
        {

        }

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
