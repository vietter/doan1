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
    public partial class GiaoDienKhachHang : Form
    {
        private int SoPhongDaDat;
        private string sdt;
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private string tenkh;
        public string TENKH
        {
            set
            {
                tenkh = value;
            }
        }

        private string cmnd;
        public string CMND
        {
            set
            {
                cmnd = value;
            }
        }
        private string tichluy;
        public string TICHLUY
        {
            set
            {
                tichluy = value;
            }
        }

        public GiaoDienKhachHang()
        {
            InitializeComponent();
        }

     
        private void GiaoDienKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Load(object sender, EventArgs e)
        {
                     

        }
        private void DS_Phong_Load()
        {
            DTO_Phong phong = new DTO_Phong();
            phong.SDT = sdt;
            BO_DSPhongDaDat ds = new BO_DSPhongDaDat();
            DataSet result = ds.DSPhong(phong);
            //gán vị trị khởi tạo user control
            
            if (result.Tables.Count >0 && result.Tables[0].Rows.Count >0)
            {
                Point vitribandau = new Point(20, 20);
                SoPhongDaDat = result.Tables[0].Rows.Count;
                for(int i =0;i<SoPhongDaDat;i++)
                {
                    //tạo vị trí phòng đầu tiên
                
                        pPhong hienthi = new pPhong  ();
                        hienthi.TenPhong(result.Tables[0].Rows[i][0].ToString(), result.Tables[0].Rows[i][0].ToString());
                        hienthi.Location = vitribandau;
                        gbDSPhong.Controls.Add(hienthi);
                        vitribandau.X = vitribandau.X + 180;

                }

            }
            else
            {

            }
        }
        private void gbKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void pDatPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatPhong datphong = new DatPhong();
            datphong.SDT = sdt;
            datphong.ShowDialog();
            this.Close();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void pHoTro_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoTroKhachHang hoTro =new HoTroKhachHang();
            hoTro.CMND = cmnd;
            hoTro.TENKH = tenkh;
            hoTro.TICHLUY = tichluy;
            hoTro.SDT = sdt;
            hoTro.ShowDialog();
            this.Close();
        }

        private void pQuanLiTK_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.CMND = cmnd;
            quanLyTaiKhoan.TENKH = tenkh;
            quanLyTaiKhoan.SDT = sdt;
            quanLyTaiKhoan.TICHLUY = tichluy;
            quanLyTaiKhoan.ShowDialog();
            this.Hide();
        }
    }
}
