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
    public partial class pPhong : UserControl
    {
        private string tenphong;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
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
        private string maphong;
        public string MAPHONG
        {
            set
            {
                maphong = value;
            }
        }

        public pPhong()
        {
            InitializeComponent();
        }

        private void pPhong_Load(object sender, EventArgs e)
        {

        }
        public void TenPhong(string TenPhong)
        {
            label.Text = TenPhong;
        }
        

        private void picture_Click(object sender, EventArgs e)
        {
            TuyChonPhong chon = new TuyChonPhong();
            chon.MACHINHANH = machinhanh;
            chon.MAPHONG = maphong;
            chon.MAPHONG = tenphong;
            chon.ShowDialog();
            
        }
    }
}
