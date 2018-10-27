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
   
    public partial class YeuCau : UserControl
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
        private int stt;
        public int STT
        {
            set
            {
                stt = value;
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
        private DateTime thoigian;
        public DateTime THOIGIAN
        {
            set
            {
                thoigian = value;
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
        public YeuCau()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            DapUngYeuCau yeucau = new DapUngYeuCau();
            yeucau.TENCHINHANH = tenchinhanh;
            yeucau.MACHINHANH = machinhanh;
            yeucau.MAPHONG = maphong;
            yeucau.TENPHONG = tenphong;
            yeucau.TENNV = tennv;
            yeucau.MAHD = mahd;
            yeucau.MANV = manv;
            yeucau.STT = stt;
            yeucau.SOLUONG = soluong;
            yeucau.TENDV = tendv;
            yeucau.ShowDialog();
            this.ParentForm.Close();
        }

        private void YeuCau_Load(object sender, EventArgs e)
        {
            
            
        }

        private void YeuCau_Paint(object sender, PaintEventArgs e)
        {
            label.Text = maphong + "-" + tenphong;
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - thoigian;

            lb_ThoiGian.Text = ts.Hours.ToString() + " Giờ " + ts.Minutes.ToString() + " Phút " + ts.Seconds.ToString() + " Giây "  ;
           
        }
    }
}
