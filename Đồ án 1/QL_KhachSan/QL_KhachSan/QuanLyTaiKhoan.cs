using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.BS_layer;

namespace QL_KhachSan
{
    public partial class QuanLyTaiKhoan : Form
    {
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;

            }
        }
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            DTO_KhachHang khachhang = new DTO_KhachHang();
            khachhang.SDT = sdt;
            BO_ThongTinKhachHang khach = new BO_ThongTinKhachHang();
            DataSet table = khach.ThongTinKhachHang(khachhang);
            txtSoDT.Text= table.Tables[0].Rows[0][0].ToString();
            txtTenKH.Text = table.Tables[0].Rows[0][1].ToString();
            txtTichLuy.Text = table.Tables[0].Rows[0][2].ToString();
            txtCMND.Text = table.Tables[0].Rows[0][4].ToString();
            
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau doi = new DoiMatKhau();
            doi.SDT = sdt;
            doi.KIEMTRA = "QUANLI";
            doi.ShowDialog();
            this.Close();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienKhachHang khachhang = new GiaoDienKhachHang();
            khachhang.SDT = sdt;
            khachhang.ShowDialog();
            this.Close();
        }
    }
}
