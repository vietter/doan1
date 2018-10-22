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
        private int options;
        public int OPTIONS
        {
            set
            {
                options = value;
            }
        }
        public MatKhau()
        {
            InitializeComponent();
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
        private string tendv;
        public string TENDV
        {
            set
            {
                tendv = value;
            }
        }
        private void MatKhau_Load(object sender, EventArgs e)
        {
            lbSai.Visible = false;
            lbTen.Text = tenkh.ToString();
        }
        private string tenvtchinhanh;
        public string TENVTCHINHANH
        {
            set
            {
                tenvtchinhanh = value;
            }
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            DangNhap dangnhap = new DangNhap();
            dangnhap.TENVTCHINHANH = tenvtchinhanh;
            dangnhap.TENDV = tendv;
            dangnhap.MADV = madv;
            dangnhap.GIATIEN = giatien;
            dangnhap.MACHINHANH = machinhanh;
            dangnhap.TENCHINHANH = tenchinhanh;
            dangnhap.MAPHONG = maphong;
            dangnhap.TENPHONG = tenphong;
            dangnhap.NGAYDATPHONG = ngaydatphong;
            dangnhap.NGAYTRAPHONG = ngaytraphong;
            dangnhap.OPTIONS = options;
            dangnhap.TENVTCHINHANH = tenvtchinhanh;
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
                    if (options == 1)
                    {
                        this.Hide();
                        DatPhongNhanh datphong = new DatPhongNhanh();
                        datphong.SDT = sdt;
                        datphong.TENDV = tendv;
                        datphong.MADV = madv;
                        datphong.GIATIEN = giatien;
                        datphong.TENCHINHANH = tenchinhanh;
                        datphong.MACHINHANH = machinhanh;
                        datphong.MAPHONG = maphong;
                        datphong.TENPHONG = tenphong;
                        datphong.NGAYDATPHONG = ngaydatphong;
                        datphong.NGAYTRAPHONG = ngaytraphong;
                        datphong.OPTIONS = options;
                        datphong.TENVTCHINHANH = tenvtchinhanh;
                        datphong.ShowDialog();
                        this.Close();
                       
                    }
                    else
                    {
                        this.Hide();
                        GiaoDienKhachHang giaodien = new GiaoDienKhachHang();
                        giaodien.SDT = sdt;
                        giaodien.OPTIONS = options;
                        giaodien.ShowDialog();
                        
                        this.Close();
                    }
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
            quen.TENKH = tenkh;
            quen.ShowDialog();
            this.Close();
        }
    }
}
