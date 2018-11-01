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
    public partial class giuongdoi2nguoi : UserControl
    {
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
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
        public giuongdoi2nguoi()
        {
            InitializeComponent();
        }
        private string chinhanh;
        public string CHINHANH
        {
            set
            {
                chinhanh = value;
            }
        }
        private string tenvtchinhanh;
        public string TENVTCHINHANH
        {
            set
            {
                tenvtchinhanh = value;
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
        private void giuongdoi2nguoi_Load(object sender, EventArgs e)
        {
            settenphong();
            if(options == "TuyChon")
            {
                btn_DatPhong.Text = "Tùy chọn";
            }
        }
        public void settenphong()
        {
            lb_Ten.Text = tenphong;
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
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            if (options == "TuyChon")
            {

                this.ParentForm.Hide();
                TuyChonPhong tuychon = new TuyChonPhong();
                tuychon.MAHD = mahd;
                tuychon.MAPHONG = maphong;
                tuychon.MACHINHANH = machinhanh;
                tuychon.TENPHONG = tenphong;
                tuychon.SDT = sdt;
                tuychon.LOAIPHONG = "Giường Đôi";
                tuychon.SONGUOI = 2;
                tuychon.ShowDialog();
                this.ParentForm.Close();
            }

            else
            {
                this.ParentForm.Hide();
                DatPhongNhanh datphong = new DatPhongNhanh();
                datphong.MACHINHANH = machinhanh;
                datphong.MAPHONG = maphong;
                datphong.TENVTCHINHANH = tenvtchinhanh;
                datphong.TENCHINHANH = tenchinhanh;
                datphong.TENPHONG = tenphong;
                datphong.MADV = "DV_THUEPHONGDOI_2NGUOI";
                datphong.TENDV = "Thuê phòng đôi 2 người";
                datphong.GIATIEN = 250000;
                datphong.SDT = sdt;
                datphong.CHINHANH = chinhanh;
                datphong.NGAYDATPHONG = ngaydatphong;
                datphong.NGAYTRAPHONG = ngaytraphong;
                datphong.ShowDialog();
                this.ParentForm.Close();

            }
            
           
        }
    }
}
  