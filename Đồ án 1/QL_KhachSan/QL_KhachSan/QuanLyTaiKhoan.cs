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
    public partial class QuanLyTaiKhoan : Form
    {

        private string tenkh;
        public string TENKH
        {
            set
            {
                tenkh = value;
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
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenKH.Text = tenkh;
            txtTichLuy.Text = tichluy;
            txtSoDT.Text = sdt;
            txtCMND.Text = cmnd;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.CMND = cmnd;
            doiMatKhau.TENKH = tenkh;
            doiMatKhau.TICHLUY = tichluy;
            doiMatKhau.SDT = sdt;
            doiMatKhau.ShowDialog();
            this.Close();

        }

      
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
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
