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
using QL_KhachSan.BS_layer;


namespace QL_KhachSan
{
    public partial class GiaoDienQuanLi : Form
    {
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
        private string machinhanh;
        public string MACHINHANH
        {
            set
            {
                machinhanh = value;
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


        public GiaoDienQuanLi()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLi_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            lbTen.Text = tennv;
            lbTenChiNhanh.Text = tenchinhanh;
            DTO_Phong phong = new DTO_Phong();
            phong.MaChiNhanh = machinhanh;
            BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
            DataSet table = new DataSet();
            table = quanli.HienThiDSPhongDaDatCuaKhachHang(phong);
            if (table.Tables.Count >0 && table.Tables[0].Rows.Count >0)
            {
                Point vitridau = new Point(20, 20);
                for (int i = 0; i < table.Tables[0].Rows.Count; i++)
                {
                    if (i == 5)
                    {
                        PhongCuaKhach dsphong = new PhongCuaKhach();
                        dsphong.MACHINHANH = machinhanh;
                        dsphong.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                        dsphong.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                        dsphong.SDT = table.Tables[0].Rows[0][3].ToString();
                        dsphong.settenphong(table.Tables[0].Rows[i][2].ToString());
                        dsphong.TENCHINHANH = tenchinhanh;
                        dsphong.TENNV = tennv;
                        dsphong.MANV = manv;
                        DTO_HoaDon hoadon = new DTO_HoaDon();
                        hoadon.SoDienThoai = table.Tables[0].Rows[0][3].ToString();
                        hoadon.MaPhong = table.Tables[0].Rows[i][0].ToString();
                        hoadon.MaChiNhanh = machinhanh;
                        BO_DSPhongDaDat laymahd = new BO_DSPhongDaDat();
                        DataSet result = laymahd.LayMaHD(hoadon);
                        dsphong.MAHD = result.Tables[0].Rows[0][0].ToString();
                        vitridau.X = 20;
                        vitridau.Y = 150;
                        dsphong.Location = vitridau;
                        gbDSPhong.Controls.Add(dsphong);
                        vitridau.X += 165;
                    }
                    else
                    {
                        PhongCuaKhach dsphong = new PhongCuaKhach();
                        dsphong.MACHINHANH = machinhanh;
                        dsphong.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                        dsphong.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                        dsphong.SDT = table.Tables[0].Rows[0][3].ToString();
                        dsphong.settenphong(table.Tables[0].Rows[i][2].ToString());
                        dsphong.TENCHINHANH = tenchinhanh;
                        dsphong.TENNV = tennv;
                        dsphong.MANV = manv;
                        DTO_HoaDon hoadon = new DTO_HoaDon();
                        hoadon.SoDienThoai = table.Tables[0].Rows[0][3].ToString();
                        hoadon.MaPhong = table.Tables[0].Rows[i][0].ToString();
                        hoadon.MaChiNhanh = machinhanh;
                        BO_DSPhongDaDat laymahd = new BO_DSPhongDaDat();
                        DataSet result = laymahd.LayMaHD(hoadon);
                        dsphong.MAHD = result.Tables[0].Rows[0][0].ToString();
                        dsphong.Location = vitridau;
                        gbDSPhong.Controls.Add(dsphong);
                        vitridau.X += 165;
                    }
                }
            }
           


        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
