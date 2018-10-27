using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using QL_KhachSan.BS_layer;
namespace QL_KhachSan
{
    public partial class ThanhToan : Form
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
      
        int total = 0;
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
      
        public ThanhToan()
        {
            InitializeComponent();
        }
      
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            load();
        }
        private string tenkh;
        private void load()
        {
           
            BO_DangNhap dangnhap = new BO_DangNhap();
            DTO_KhachHang khachhang = new DTO_KhachHang();
            khachhang.SDT = sdt;
            DataSet result = new DataSet();
            result = dangnhap.KT_SDT(khachhang, ref tenkh);
            lb_Ten.Text = tenkh;
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaHD = mahd;
            BO_ChiTietPhong hienthi = new BO_ChiTietPhong();
            DataSet table = hienthi.HienThi(hoadon);
            if (table.Tables.Count > 0 && table != null)
            {
                dgvHienThi.DataSource = table.Tables[0];
            }
            total = 0;
            if (dgvHienThi.Rows.Count != 0)
            {
                for (int i = 0; i < dgvHienThi.Rows.Count - 1; i++)
                {
                    total += int.Parse(dgvHienThi.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
            }
            txtTong.Text = total.ToString();
            txtTenphong.Text = tenphong;


        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTong.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTong.Text = String.Format(culture, "{0:N0}", value);
            txtTong.Select(txtTong.Text.Length, 0);
        }

      

        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiPhong quanli = new QuanLiPhong();
            quanli.MANV = manv;
            quanli.MAPHONG = maphong;
            quanli.TENNV = tennv;
            quanli.TENPHONG = tenphong;
            quanli.MAHD = mahd;
            quanli.SDT = sdt;
            quanli.TENCHINHANH = tenchinhanh;
            quanli.MACHINHANH = machinhanh;
            quanli.ShowDialog();
            this.Close();
        }

        private void pbXacNhan_Click(object sender, EventArgs e)
        {
            BO_HuyPhong giaiphongphong = new BO_HuyPhong();
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.SoDienThoai = "Free";
            hoadon.ThanhTien = total;
            hoadon.MaPhong = maphong;
            hoadon.MaChiNhanh = machinhanh;
            hoadon.MaHD = mahd;
            int result = giaiphongphong.HuyPhong(hoadon);
            if (result != -1)
            {
                this.Hide();
                MessageBox.Show("Thanh toán thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DTO_HoaDon hoadon1 = new DTO_HoaDon();
                hoadon1.SoDienThoai = sdt;
                hoadon1.ThanhTien = total;
                BO_QuanLiChiNhanh quanli1 = new BO_QuanLiChiNhanh();
                
                int KQ = quanli1.TichLuyDiem(hoadon1);
                if (KQ != -1)
                {

                    int table = quanli1.SetHoaDon(hoadon);
                    if (table != -1)
                    {
                        GiaoDienQuanLi quanli = new GiaoDienQuanLi();
                        quanli.MANV = manv;
                        quanli.MACHINHANH = machinhanh;
                        quanli.TENCHINHANH = tenchinhanh;
                        quanli.TENNV = tennv;
                        quanli.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi set Hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi tích lũy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại, vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
