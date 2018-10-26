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
    public partial class HoTroKhachHang : Form
    {
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

        public HoTroKhachHang()
        {
            InitializeComponent();
        }

        private void HoTroKhachHang_Load(object sender, EventArgs e)
        {
            rtbDangXuat.Visible = false;
            rtbDatPhong.Visible = false;
            rtbHuyPhong.Visible = false;
            rtbMatKhau.Visible = false;
            rtbThongTin.Visible = false;


        }
       
        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienKhachHang giaoDienKhachHang = new GiaoDienKhachHang();
            giaoDienKhachHang.SDT = sdt;
            giaoDienKhachHang.OPTIONS = options;
            giaoDienKhachHang.ShowDialog();
            this.Close();
        }


        private void pbXacNhan_Click(object sender, EventArgs e)
        {
          

        }

        private void rtbHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbDatPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.Text.Equals("Hủy Phòng"))
            {

                rtbDangXuat.Visible = false;
                rtbDatPhong.Visible = false;
                rtbHuyPhong.Visible = true;
                rtbMatKhau.Visible = false;
                rtbThongTin.Visible = false;
            }
            else if (cmbLuaChon.Text == "Đổi Mật Khẩu")
            {

                rtbDangXuat.Visible = false;
                rtbDatPhong.Visible = false;
                rtbHuyPhong.Visible = false;
                rtbMatKhau.Visible = true;
                rtbThongTin.Visible = false;
            }
            else  if (cmbLuaChon.Text.Equals("Đăng Xuất"))
                {

                    rtbDangXuat.Visible = true;
                    rtbDatPhong.Visible = false;
                    rtbHuyPhong.Visible = false;
                    rtbMatKhau.Visible = false;
                    rtbThongTin.Visible = false;
            }
            else if (cmbLuaChon.Text.Equals("Đặt Phòng"))
            {

                rtbDangXuat.Visible = false;
                rtbDatPhong.Visible = true;
                rtbHuyPhong.Visible = false;
                rtbMatKhau.Visible = false;
                rtbThongTin.Visible = false;
            }
            else if (cmbLuaChon.Text.Equals("Thông Tin Phòng Đã Đặt"))
            {

                rtbDangXuat.Visible = false;
                rtbDatPhong.Visible = false;
                rtbHuyPhong.Visible = false;
                rtbMatKhau.Visible = false;
                rtbThongTin.Visible = true;
            }
        }
    }
}
