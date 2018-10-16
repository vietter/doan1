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
    public partial class GiaoDienQuanLi : Form
    {
        private string tennv;
        public string TENNV
        {
            set { tennv = value; }
        }
        private string manv;
        public string MANV
        {
            set { manv = value; }
        }
        private string tencn;


        public GiaoDienQuanLi()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLi_Load(object sender, EventArgs e)
        {
            lbTen.Text = tennv;
            lbTenChiNhanh.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnTruyCap_Click(object sender, EventArgs e)
        {

            DTO_ChiNhanh phong = new DTO_ChiNhanh();
            phong.MaNguoiQuanLy = manv;
            if (cbbDiaChi.Text == "Đà Lạt- Khách sạn The New Star 1- địa chỉ: 69 Hồ Tùng Mậu, Phường 1, Thành Phố Đà Lạt, tỉnh Lâm Đồng")
            {
                phong.MaChiNhanh = "DL_TNS1";
            }
            else
            {
                if (cbbDiaChi.Text == "Hồ Chí Minh - Khách sạn The New Star 2- địa chỉ :1 Đồng Khởi, Bến Nghé, Quận 1, Thành Phố Hồ Chí Minh")
                {
                    phong.MaChiNhanh = "DN_TNS3";
                }
                else
                {
                    if (cbbDiaChi.Text == "Đà Nẵng - Khách sạn The New Star 3- địa chỉ: 99 Võ Nguyên Giáp, Bắc Mỹ An, Ngũ Hành Sơn, Thành Phố Đà Nẵng")
                    {
                        phong.MaChiNhanh = "HCM_TNS2";
                    }
                    else
                    {
                        if (cbbDiaChi.Text == "Nha Trang- Khách sạn The New Star 4- địa chỉ: 50 Trần Phú, Lộc Thọ, Thành phố Nha Trang, Khánh Hòa")
                        {
                            phong.MaChiNhanh = "NT_TNS4";
                        }
                        else
                        {
                            phong.MaChiNhanh = "PQ_TNS5";
                        }
                    }
                }
            }
            BO_GiaoDienQuanLi giaoDienQuanLi = new BO_GiaoDienQuanLi();

            DataSet result = giaoDienQuanLi.KT_QuyenQL(phong, ref tencn);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Chào quản lí chi nhánh ");

                lbTenChiNhanh.Text = tencn;
                lbTenChiNhanh.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền quản lí chi nhánh này");
                lbTenChiNhanh.Visible = false;


            }
            cbbDiaChi.ResetText();

        }

        private void lbTenChiNhanh_Click(object sender, EventArgs e)
        {

        }
    }
    
}
