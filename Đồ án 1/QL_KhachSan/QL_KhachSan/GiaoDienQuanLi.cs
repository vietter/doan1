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
    public partial class GiaoDienQuanLi : Form
    {
        private string tennv;
        public string TENNV
        {
            set { tennv = value; }
        }
        public GiaoDienQuanLi()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLi_Load(object sender, EventArgs e)
        {
            lbTen.Text = tennv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }
    }
}
