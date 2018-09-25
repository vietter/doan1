using QL_KhachSan.BS_layer;
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
    public partial class DangNhapNhanVien : Form
    {

        private string tennv;


        public DangNhapNhanVien()
        {
            InitializeComponent();
        }

        private void DangNhapNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void MatKhau_Load(object sender, EventArgs e)
        {
        }

       

       


        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.MaNhanVien = txtMaNV.Text;
            nhanvien.MatKhau = txtMatKhau.Text;
            BO_DangNhapNhanVien dangnhap = new BO_DangNhapNhanVien();
            DataSet result = dangnhap.KT_DangNhap(nhanvien, ref tennv);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {

                MessageBox.Show("Đăng Nhập Thành công", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
                GiaoDienQuanLi giaodien = new GiaoDienQuanLi();
                giaodien.TENNV = tennv;
                giaodien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất bại", "Thông Báo", MessageBoxButtons.OK);
                txtMatKhau.ResetText();
                txtMatKhau.Focus();
            }

        }

        private void btnTroLai_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }
    }
}
