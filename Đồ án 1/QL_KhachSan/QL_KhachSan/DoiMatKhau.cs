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
    public partial class DoiMatKhau : Form
    {
        private string kiemtra;
        public string KIEMTRA
        {
            set
            {
                kiemtra = value;
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
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
            }
        }
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            load();
        }

      
        private void load()
        {
            lbMatKhau.Visible = false;
            lbReMatKhau.Visible = false;
        }
      

        private void pbTroVe_Click(object sender, EventArgs e)
        {

            if (kiemtra == "QUENMATKHAU")
            {
                this.Hide();
                QuenMatKhau quen = new QuenMatKhau();
                quen.SDT = sdt;
                quen.ShowDialog();
                this.Close();
            }
            else
            {

                this.Hide();
                QuanLyTaiKhoan khachhang = new QuanLyTaiKhoan();
                khachhang.SDT = sdt;
                khachhang.ShowDialog();
                this.Close();
            }
        }

        private void pbXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                lbMatKhau.Visible = true;
            }
            else
            {
                lbMatKhau.Visible = false;
            }
            if (txtReMatKhau.Text == "")
            {
                lbReMatKhau.Visible = true;
            }
            else
            {
                lbReMatKhau.Visible = false;
            }
            if (lbMatKhau.Visible == false && lbReMatKhau.Visible == false)
            {
                if (txtMatKhau.Text != txtReMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu bạn nhập lại không trùng với mật khẩu bạn đã nhập, vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK);
                    txtMatKhau.ResetText();
                    txtReMatKhau.ResetText();
                    load();
                    txtMatKhau.Focus();

                }
                else
                {
                    DTO_KhachHang khachhang = new DTO_KhachHang();
                    khachhang.SDT = sdt;
                    khachhang.MatKhau = txtMatKhau.Text;
                    BO_QuenMatKhau quen = new BO_QuenMatKhau();
                    if (quen.DoiMatKhau(khachhang) != -1)
                    {
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK);
                        this.Hide();
                        DangNhap dangnhap = new DangNhap();
                        dangnhap.OPTIONS = options;
                        dangnhap.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi chưa thành công vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK);
                        txtMatKhau.ResetText();
                        txtReMatKhau.ResetText();
                        txtMatKhau.Focus();
                    }
                }

            }
        }
    }
    }

