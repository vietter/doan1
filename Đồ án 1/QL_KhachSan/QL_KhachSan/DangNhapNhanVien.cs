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
        private string manv;
       
        


        public DangNhapNhanVien()
        {
            InitializeComponent();
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
        private void DangNhapNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void MatKhau_Load(object sender, EventArgs e)
        {
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

            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.MaNhanVien = txtMaNV.Text;
            nhanvien.MatKhau = txtMatKhau.Text;
            BO_DangNhapNhanVien dangnhapnv = new BO_DangNhapNhanVien();
            DataSet result = dangnhapnv.KT_DangNhap(nhanvien, ref tennv, ref manv);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {

                MessageBox.Show("Đăng Nhập Thành công", "Thông Báo", MessageBoxButtons.OK);
                DTO_ChiNhanh chinhanh = new DTO_ChiNhanh();
                chinhanh.MaNguoiQuanLy = manv;
                DataSet table = new DataSet();
                BO_DangNhapNhanVien quanli = new BO_DangNhapNhanVien();
                table = quanli.LayMaChiNhanh(chinhanh);
                this.Hide();
                GiaoDienQuanLi giaodien = new GiaoDienQuanLi();
                giaodien.TENNV = tennv;
                giaodien.MANV = manv;
                giaodien.MACHINHANH = table.Tables[0].Rows[0][0].ToString();
                giaodien.TENCHINHANH = table.Tables[0].Rows[0][1].ToString();
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
}
