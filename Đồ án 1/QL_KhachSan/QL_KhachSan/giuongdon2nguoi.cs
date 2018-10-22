using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.BS_layer
{
    public partial class giuongdon2nguoi : UserControl
    {
        private string machinhanh;
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
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
        private string tenphong;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
            }
        }
        private string ngaydatphong;
        public string NGAYDATPHONG
        {
            set
            {
                ngaydatphong = value;
            }
        }
        private string ngaytraphong;
        public string NGAYTRAPHONG
        {
            set
            {
                ngaytraphong = value;
            }
        }
        public giuongdon2nguoi()
        {
            InitializeComponent();
        }

        private void giuongdon2nguoi_Load(object sender, EventArgs e)
        {
            settenphong();
        }
        private string tenvtchinhanh;
        public string TENVTCHINHANH
        {
            set
            {
                tenvtchinhanh = value;
            }
        }
        private string chinhanh;
        public string CHINHANH
        {
            set
            {
                chinhanh = value;
            }
        }
        public void settenphong()
        {
            lb_Ten.Text = tenphong;
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            if (sdt == null)
            {
                this.ParentForm.Hide();
                DatPhongNhanh datphong = new DatPhongNhanh();
                datphong.MACHINHANH = machinhanh;
                datphong.MAPHONG = maphong;
                datphong.TENCHINHANH = tenchinhanh;
                datphong.TENVTCHINHANH = tenvtchinhanh;
                datphong.MADV = "DV_THUEPHONGDON_2NGUOI";
                datphong.TENDV = "Thuê phòng đơn 2 người";
                datphong.GIATIEN = 300000;
                datphong.TENPHONG = tenphong;
                datphong.SDT = sdt;
                datphong.NGAYDATPHONG = ngaydatphong;
                datphong.CHINHANH = chinhanh;
                datphong.NGAYTRAPHONG = ngaytraphong;
                datphong.ShowDialog();
                this.ParentForm.Close();

            }
        }
    }
}
