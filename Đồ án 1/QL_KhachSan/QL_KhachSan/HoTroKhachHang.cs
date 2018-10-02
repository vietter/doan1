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
    public partial class HoTroKhachHang : Form
    {
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private string tenkh;
        public string TENKH
        {
            set
            {
                tenkh = value;
            }
        }

        private string cmnd;
        public string CMND
        {
            set
            {
                cmnd = value;
            }
        }
        private string tichluy;
        public string TICHLUY
        {
            set
            {
                tichluy = value;
            }
        }

        public HoTroKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Đăng xuất")
            {
                
                rtbDoiMatKhau.Hide();
                rtbLichSu.Hide();
                rtbDangXuat.Show();
            }
            if (comboBox1.Text == "Đổi mật khẩu")
            {
                rtbDangXuat.Hide();
                rtbLichSu.Hide();
                rtbDoiMatKhau.Show();
            }
            if (comboBox1.Text == "Lịch sử giao dịch")
            {
                rtbDoiMatKhau.Hide();
                rtbLichSu.Show();
                rtbDangXuat.Hide();
            }
        }

        private void HoTroKhachHang_Load(object sender, EventArgs e)
        {
            rtbDoiMatKhau.Hide();
            rtbDangXuat.Hide();
            rtbLichSu.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbDoiMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienKhachHang giaoDienKhachHang = new GiaoDienKhachHang();
            giaoDienKhachHang.SDT = sdt;
            giaoDienKhachHang.CMND = cmnd;
            giaoDienKhachHang.TENKH = tenkh;
            giaoDienKhachHang.TICHLUY = tichluy;
            giaoDienKhachHang.ShowDialog();
            this.Close();
        }
    }
    
}
