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
    public partial class MatKhau : Form
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
        public MatKhau()
        {
            InitializeComponent();
        }

        private void MatKhau_Load(object sender, EventArgs e)
        {
            lbSai.Visible = false;
            lbTen.Text = tenkh.ToString();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtMatKhau.Text == "")
            {
                lbSai.Visible = true;
            }
            else
            {
                lbSai.Visible = false;
            }
            if (lbSai.Visible == false)
            {


                DTO_KhachHang khachhang = new DTO_KhachHang();
                khachhang.SDT = sdt;
                khachhang.MatKhau = txtMatKhau.Text;
                BO_DangNhap dangnhap = new BO_DangNhap();
                DataSet result = dangnhap.KT_MatKhau(khachhang);
                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đăng Nhập Thành công", "Thông Báo", MessageBoxButtons.OK);
                    this.Hide();
                    GiaoDienKhachHang giaodien = new GiaoDienKhachHang();
                    giaodien.SDT = sdt;
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
        }


   

        private void lbLinkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau quen = new QuenMatKhau();
            quen.SDT = sdt;
            quen.ShowDialog();
            this.Close();
        }
    }
}
