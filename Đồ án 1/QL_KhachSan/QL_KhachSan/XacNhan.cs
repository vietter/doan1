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

namespace QL_KhachSan
{
    public partial class XacNhan : Form
    {
        private string tenkh;
        private string mahd;
        private string danhxung;
        private string tenphong;
        private string maphong;
        private string machinhanh;
        private string NgayDat;
        private string NgayTra;
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        public string DANHXUNG
        {
            set
            {
                danhxung = value;
            }
        }
        public string TENKH
        {
            set
            {
                tenkh = value;

            }
        }
        public string MAHD
        {
            set
            {
                mahd = value;
            }
        }
        public string TENPHONG
        {
            set
            {
                tenphong = value;
            }
        }
        public string MAPHONG
        {
            set
            {
                maphong = value;    
            }
        }
        public DateTime THOIGIANTHUCHIEN
        {
            set
            {
                thoigianthuchien = value;
            }
        }
        private DateTime thoigianthuchien;
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
            }
        }
        public string NGAYDAT
        {
            set
            {
                NgayDat = value;
            }
        }
        public string NGAYTRA
        {
            set
            {
                NgayTra = value;
            }
        }
        private int giatien;
        public int GIATIEN
        {
            set
            {
                giatien = value;
            }
        }
        public XacNhan()
        {
            InitializeComponent();
        }

        private void XacNhan_Load(object sender, EventArgs e)
        {
            lb_sodienthoai.Text = sdt;
            lb_ten.Text = tenkh;
            lb_danhxung.Text = danhxung;
            lb_mahd.Text = mahd;
            lb_maphong.Text = maphong;
            lb_tenphong.Text = tenphong;
            lb_ngaydatphong.Text = NgayDat;
            lb_ngaytraphong.Text = NgayTra;
            lb_thoigian.Text = thoigianthuchien.Hour.ToString() + " Giờ " + thoigianthuchien.Minute.ToString() +" Phút " + "Ngày " + thoigianthuchien.Day.ToString() + " Tháng " + thoigianthuchien.Month.ToString() + " Năm " + thoigianthuchien.Year.ToString(); 
            txtTien.Text = giatien.ToString();
        }

      
        
        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTien.Text = String.Format(culture, "{0:N0}", value);
            txtTien.Select(txtTien.Text.Length, 0);
        }

        private void pbXacNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatPhong datphong = new DatPhong();
            datphong.ShowDialog();
            this.Close();
        }

    }
}
