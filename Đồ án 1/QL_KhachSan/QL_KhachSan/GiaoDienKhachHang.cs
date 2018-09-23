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
    public partial class GiaoDienKhachHang : Form
    {
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }

        public GiaoDienKhachHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void gbKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void pDatPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatPhong datphong = new DatPhong();
            datphong.SDT = sdt;
            datphong.ShowDialog();
            this.Close();
        }
    }
}
