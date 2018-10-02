using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class TuyChonPhong : Form
    {
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
        private string maphong;
        public string MAPHONG
        {
            set
            {
                maphong = value;
            }
        }

        public TuyChonPhong()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void TuyChonPhong_Load(object sender, EventArgs e)
        {
            txtTenPhong.Text = maphong;
            pl_DichVuThue.Visible = false;
            pl_ThucAn.Visible = false;
            pl_ThucUong.Visible = false;
            pl_TienIch.Visible = false;
            
            
        }
        private void load()
        {
            
        }
    }
}
