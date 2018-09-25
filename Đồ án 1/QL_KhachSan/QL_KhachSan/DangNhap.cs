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
    public partial class DangNhap : Form
    {
        string TenKH;   
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtSoDT.Text == "(+84) ")
            {
                lbSai.Text = "Bạn chưa nhập số điện thoại";
                lbSai.Show();
                txtSoDT.Focus();
            }
            else
            {
                DTO_KhachHang dto = new DTO_KhachHang();
                dto.SDT = txtSoDT.Text;
                BO_DangNhap dangnhap = new BO_DangNhap();
                DataSet result = dangnhap.KT_SDT(dto, ref TenKH);
                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    MatKhau matkhau = new MatKhau();
                    matkhau.TENKH = TenKH;
                    matkhau.SDT = txtSoDT.Text;
                    matkhau.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbSai.Text = "Bạn đã nhập sai số điện thoại\nNếu bạn chưa có tài khoản hãy đăng kí";
                    lbSai.Show();
                    txtSoDT.ResetText();
                    txtSoDT.Focus();

                }
            }
        }
        
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi dangki = new DangKi();
            dangki.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            lbSai.Hide();
            txtSoDT.Focus();
        }

<<<<<<< HEAD
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhapNhanVien dnnv = new DangNhapNhanVien();
            dnnv.ShowDialog();
            this.Close();
=======
        private void txtSoDT_Click(object sender, EventArgs e)
        {
            txtSoDT.ResetText();
            txtSoDT.Focus();
>>>>>>> 84b1750b03e06dd7d2fa907831b5e23d7a6fb072
        }
    }
}
