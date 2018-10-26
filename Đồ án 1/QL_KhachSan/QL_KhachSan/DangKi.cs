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
        private string tendv;
        public string TENDV
        {
            set
            {
                tendv = value;
            }
        }
        private string chuoiMaHD;
        private string chinhanh;
        public string CHINHANH
        {
            set
            {
                chinhanh = value;
            }
        }
        private string ngaydatphong;
        public string NGAYDATPHONG
        {
            set
            {
                ngaydatphong = value;
            }
        }
        private string ngaytraphong;
        public string NGAYTRAPHONG
        {
            set
            {
                ngaytraphong = value;
            }
        }
        private string tennv;
        public string TENNV
        {
            set
            {
                tennv = value;
            }
        }
        private string manv;
        public string MANV
        {
            set
            {
                manv = value;
            }
        }

        private string tenchinhanh;
        public string TENCHINHANH
        {
            set
            {
                tenchinhanh = value;
            }
        }

        private string mahd;
        public string MAHD
        {
            set
            {
                mahd = value;
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
        private string maphong;
        public string MAPHONG
        {
            set
            {
                maphong = value;
            }
        }
        private string machinhanh;
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
            }
        }
        private string tenphong;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
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
        private string tenvtchinhanh;
        public string TENVTCHINHANH
        {
            set
            {
                tenvtchinhanh = value;
            }
        }
        private string madv;
        public string MADV
        {
            set
            {
                madv = value;
            }
        }
        private int giatien;
        public int GIATIEN
        {
            set
            {
                giatien = value;
            }
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

        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();

        }

        private void pbXacNhan_Click(object sender, EventArgs e)
        {

            if (txtTenKH.Text == "")
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
            if (txtMatKhau.Text == "")
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
            if (lbTen.Visible == false && lbSDT.Visible == false && lbMatKhau.Visible == false && lbCauHoi.Visible == false && lbTraLoi.Visible == false && lbCMND.Visible == false)
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
}
