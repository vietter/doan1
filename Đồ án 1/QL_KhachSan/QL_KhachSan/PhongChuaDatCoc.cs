using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.BS_layer;
namespace QL_KhachSan
{
    public partial class PhongChuaDatCoc : UserControl
    {
        public PhongChuaDatCoc()
        {
            InitializeComponent();
        }
        private string tenphong;
        private string maphong;
        private string machinhanh;
        private DateTime thoigianthuchien;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
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
        public string MAPHONG
        {
            set
            {
                maphong = value;
            }
        }
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
            }
        }
        public DateTime THOIGIANTHUCHIEN
        {
            set
            {
                thoigianthuchien = value;
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

        private void picture_Click(object sender, EventArgs e)
        {
           DialogResult answer = MessageBox.Show("Phòng này đã được đặt cọc chưa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(answer == DialogResult.Yes)
            {
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.MaHD = mahd;
                BO_QuanLiChiNhanh datcoc = new BO_QuanLiChiNhanh();
                int kt = datcoc.DatCoc(hoadon);
                 if(kt != -1)
                {
                    MessageBox.Show("Đặt cọc thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Refresh();
                }
                 else
                {
                    MessageBox.Show("Lỗi khi đặt cọc phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PhongChuaDatCoc_Load(object sender, EventArgs e)
        {

        }

        private void PhongChuaDatCoc_Paint(object sender, PaintEventArgs e)
        {
            lb_TenPhong.Text = maphong + " - " + tenphong;
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - thoigianthuchien;
         if(ts.Days >= 1)
            {
                lb_ThoiGian.Text = "0Giờ0Phút0Giây";
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.MaHD = mahd;
                BO_HuyPhong huy = new BO_HuyPhong();
                huy.HuyHoaDon(hoadon);
            }
         else
            {
                lb_ThoiGian.Text = ts.Hours.ToString() + "Giờ" + ts.Minutes.ToString() + "Phút" + ts.Seconds.ToString() + "Giây";
            }
           
        }
    }
}
