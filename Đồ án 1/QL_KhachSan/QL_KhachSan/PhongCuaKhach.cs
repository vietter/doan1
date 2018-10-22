using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class PhongCuaKhach : UserControl
    {
        public PhongCuaKhach()
        {
            InitializeComponent();
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
        private string mahd;
        public string MAHD
        {
            set
            {
                mahd = value;
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
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private void picture_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            QuanLiPhong phong = new QuanLiPhong();
            phong.MACHINHANH = machinhanh;
            phong.TENPHONG = tenphong;
            phong.MAPHONG = maphong;
            phong.SDT = sdt;
            phong.MAHD = mahd;
            phong.MANV = manv;
            phong.TENCHINHANH = tenchinhanh;
            phong.TENNV = tennv;
            phong.ShowDialog();
            this.ParentForm.Close();
        }
        public void settenphong (string ten)
        {
            label.Text = ten;
        }
    }
}
