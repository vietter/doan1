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

    public partial class DoiPhong : Form
    {
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

        public DoiPhong()
        {
            InitializeComponent();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            TuyChonPhong tuychon = new TuyChonPhong();
            tuychon.MAHD = mahd;
            tuychon.MACHINHANH = machinhanh;
            tuychon.TENPHONG = tenphong;
            tuychon.MAPHONG = maphong;
            this.Close();
        }

        private void load()
        {
            txtSoPhong.Text = tenphong;
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaChiNhanh = machinhanh;
            BO_DoiPhong kiemtraphongtrong = new BO_DoiPhong();
            DataSet table = kiemtraphongtrong.DSPhongHienTrong(hoadon);
            if(table.Tables.Count > 0 && table.Tables[0].Rows.Count>0)
            {
                Point vitridau = new Point(20, 20);
                int SoPhongTrong = table.Tables[0].Rows.Count;
                for(int i = 0;i<SoPhongTrong;i++)
                {
                    if(i==5)
                    {
                        FreeRoom phong = new FreeRoom();
                        phong.MACHINHANH = machinhanh;
                        phong.SDT = sdt;
                        phong.MAPHONGCU = maphong;
                        phong.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                        phong.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                        phong.SetTenPhong(table.Tables[0].Rows[i][2].ToString());
                        phong.MAHD = mahd;
                        vitridau.X = 20;
                        vitridau.Y = 150;
                        phong.Location = vitridau;
                        gbDSPhongTrong.Controls.Add(phong);
                        vitridau.X += 165;
                        
                    }
                    else
                    {
                        FreeRoom phong = new FreeRoom();
                        phong.MACHINHANH = machinhanh;
                        phong.SDT = sdt;
                        phong.MAPHONGCU = maphong;
                        phong.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                        phong.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                        phong.SetTenPhong(table.Tables[0].Rows[i][2].ToString());
                        phong.MAHD = mahd;
                        phong.Location = vitridau;
                        gbDSPhongTrong.Controls.Add(phong);
                        vitridau.X += 165;
                    }
                }

            }
        }
        private void DoiPhong_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
