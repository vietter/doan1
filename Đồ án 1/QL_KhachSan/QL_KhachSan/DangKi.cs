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
    public partial class DangKi : Form
    {
        bool KT = false ;
        public DangKi()
        {
            InitializeComponent();
        }

        private void txtCMND_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            txtTenKH.Focus();
            lbSDT.Visible = false;
            lbCMND.Visible = false;
            lbCauHoi.Visible = false;
            lbTraLoi.Visible = false;
            lbMatKhau.Visible = false;
            lbTen.Visible = false;
        }

        private void cbbCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           

            if (KT == false)
            {
                if(txtTenKH.Text =="")
                {
                    lbTen.Visible = true;
                }
                else
                {
                    lbTen.Visible = false;
                }
                if (txtSoDT.Text == "(+84) ")
                {
                    lbSDT.Visible = true; 
                }
                else
                {
                    lbSDT.Visible = false;
                }
                if(txtMatKhau.Text == "")
                {
                    lbMatKhau.Visible = true;
                }
                else
                {
                    lbMatKhau.Visible = false;
                }
                if (txtCMND.Text == "")
                {
                    lbCMND.Visible = true;
                }
                else
                {
                    lbCMND.Visible = false;
                }
                if (cbbCauHoi.Text == "")
                {
                    lbCauHoi.Visible = true;
                }
                else
                {
                    lbCauHoi.Visible = false;
                }
                if (txtTraLoi.Text == "")
                {
                    lbTraLoi.Visible = true;
                }
                else
                {
                    lbTraLoi.Visible = false;
                }
                if(lbTen.Visible == false && lbSDT.Visible == false && lbMatKhau.Visible == false && lbCauHoi.Visible == false && lbTraLoi.Visible == false && lbCMND.Visible == false)
                {
                   
                  
                        DTO_KhachHang khachhang = new DTO_KhachHang();
                        khachhang.SDT = txtSoDT.Text;
                        khachhang.MatKhau = txtMatKhau.Text;
                        khachhang.TenKH = txtTenKH.Text;
                        khachhang.CMND = txtCMND.Text;
                        khachhang.CauHoiBiMat = cbbCauHoi.Text;
                        khachhang.TraLoi = txtTraLoi.Text;

                        BO_DangKi dangki = new BO_DangKi();
                        if (dangki.DangKi(khachhang) != -1)
                        {
                            MessageBox.Show("Bạn đã đăng kí thành công!", "Thông Báo", MessageBoxButtons.OK);
                            this.Hide();
                            DangNhap dangnhap = new DangNhap();
                            dangnhap.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Chưa đăng kí thành công vui lòng thử lại", "Thông báo", MessageBoxButtons.OK);

                        }
                    
                }
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT_Click(object sender, EventArgs e)
        {
            txtSoDT.ResetText();
            txtSoDT.Focus();
        }

        private void txtCMND_Click(object sender, EventArgs e)
        {
            txtCMND.ResetText();
            txtCMND.Focus();
        }
    }
}
