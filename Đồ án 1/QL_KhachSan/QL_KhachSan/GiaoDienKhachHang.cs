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

        public GiaoDienKhachHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDienKhachHang_Load(object sender, EventArgs e)
        {
         DS_Phong_Load();
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
                    //nếu vượt quá 5 phòng trên 1 hàng sẽ xuống dòng
                    if (i == 5)
                    {
                        pPhong hienthi = new pPhong();
                        hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                        hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                        hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                        hienthi.TenPhong(result.Tables[0].Rows[i][2].ToString());
                        gbDSPhong.Controls.Add(hienthi);
                        vitribandau.X = 20;
                        vitribandau.Y = 150;
                        hienthi.Location = vitribandau;
                        vitribandau.X = vitribandau.X + 165;
                    }
                    else
                    {
                        pPhong hienthi = new pPhong();
                        hienthi.MACHINHANH = result.Tables[0].Rows[i][1].ToString();
                        hienthi.MAPHONG = result.Tables[0].Rows[i][0].ToString();
                        hienthi.TENPHONG = result.Tables[0].Rows[i][2].ToString();
                        hienthi.TenPhong(result.Tables[0].Rows[i][2].ToString());
                        gbDSPhong.Controls.Add(hienthi);
                        hienthi.Location = vitribandau;
                        vitribandau.X = vitribandau.X + 165;
                    }

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
    }
}
