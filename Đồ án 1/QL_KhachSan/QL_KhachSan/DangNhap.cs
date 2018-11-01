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
                lbSai.Text = "Bạn chưa nhập  số điện thoại";
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
                this.Hide();
                DatPhong datphong = new DatPhong();
                datphong.ShowDialog();
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                this.Hide();
                DangNhapNhanVien dnnv = new DangNhapNhanVien();   
                dnnv.ShowDialog();
                this.Close();
            
            
        }
        private void txtSoDT_Click(object sender, EventArgs e)
        {
            txtSoDT.ResetText();
            txtSoDT.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
