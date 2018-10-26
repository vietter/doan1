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
    public partial class DapUngYeuCau : Form
    {
        private string tendv;
        public string TENDV
        {
            set
            {
                tendv = value;
            }
        }
        private string soluong;
        public string SOLUONG
        {
            set
            {
                soluong = value;
            }
        }
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
        private int stt;
        public int STT
        {
            set
            {
                stt = value;
            }
        }
        public DapUngYeuCau()
        {
            InitializeComponent();
        }

        private void DapUngYeuCau_Load(object sender, EventArgs e)
        {
            lb_TenPhong.Text = tenphong;
            lb_TenYC.Text = tendv;
            lb_SL.Text = soluong;

        }

     



        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeuCauKhachHang dsyeucau = new YeuCauKhachHang();
            dsyeucau.MANV = manv;
            dsyeucau.MACHINHANH = machinhanh;
            dsyeucau.TENNV = tennv;
            dsyeucau.TENCHINHANH = tenchinhanh;
            dsyeucau.ShowDialog();
            this.Close();
        }

        private void pbXacNhan_Click(object sender, EventArgs e)
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaPhong = maphong;
            hoadon.MaChiNhanh = machinhanh;
            hoadon.STT = stt;
            hoadon.MaHD = mahd;
            BO_QuanLiChiNhanh yeucau = new BO_QuanLiChiNhanh();
            int result = yeucau.ThucHienYeuCau(hoadon);
            if (result != -1)
            {
                this.Hide();
                YeuCauKhachHang dsyeucau = new YeuCauKhachHang();
                dsyeucau.MANV = manv;
                dsyeucau.MACHINHANH = machinhanh;
                dsyeucau.TENNV = tennv;
                dsyeucau.TENCHINHANH = tenchinhanh;
                dsyeucau.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Bạn có muốn xóa yêu cầu này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.MaPhong = maphong;
                hoadon.MaChiNhanh = machinhanh;
                hoadon.STT = stt;
                hoadon.MaHD = mahd;
                BO_QuanLiChiNhanh yeucau = new BO_QuanLiChiNhanh();
                int result = yeucau.XoaYeuCau(hoadon);
                if (result != -1)
                {
                    this.Hide();
                    YeuCauKhachHang dsyeucau = new YeuCauKhachHang();
                    dsyeucau.MANV = manv;
                    dsyeucau.MACHINHANH = machinhanh;
                    dsyeucau.TENNV = tennv;
                    dsyeucau.TENCHINHANH = tenchinhanh;
                    dsyeucau.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
