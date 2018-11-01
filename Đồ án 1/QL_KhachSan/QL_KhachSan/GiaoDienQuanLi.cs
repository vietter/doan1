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
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
            }
        }

        public GiaoDienQuanLi()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLi_Load(object sender, EventArgs e)
        {
            load();
            timer1.Interval = 1000;
            timer1.Start();
           
        }

        private void load()
        {
            lbTen.Text = tennv;
            lbTenChiNhanh.Text = tenchinhanh;
            DTO_HoaDon phong = new DTO_HoaDon();
            phong.MaChiNhanh = machinhanh;
            BO_QuanLiChiNhanh quanli = new BO_QuanLiChiNhanh();
            DataSet table = new DataSet();
            table = quanli.HienThiDSPhongDaDatCuaKhachHang(phong);
            if (table.Tables.Count > 0 && table.Tables[0].Rows.Count > 0)
            {
                Point vitridau = new Point(20, 20);
                for (int i = 0; i < table.Tables[0].Rows.Count; i++)
                {
                    if (i == 5)
                    {
                        PhongCuaKhach dsphong = new PhongCuaKhach();
                        dsphong.MACHINHANH = machinhanh;
                        dsphong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                        BO_QuanLiChiNhanh quanli1 = new BO_QuanLiChiNhanh();
                        DTO_Phong phong1 = new DTO_Phong();
                        phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                        phong1.MaChiNhanh = machinhanh;
                        DataSet KQ = quanli1.LayTenPhong(phong1);
                        dsphong.TENPHONG = KQ.Tables[0].Rows[0][2].ToString();
                        dsphong.SDT = table.Tables[0].Rows[i][7].ToString();
                        dsphong.TENCHINHANH = tenchinhanh;
                        dsphong.TENNV = tennv;
                        dsphong.MANV = manv;
                        dsphong.MAHD = table.Tables[0].Rows[i][3].ToString();
                        vitridau.X = 20;
                        vitridau.Y = 150;
                        dsphong.Location = vitridau;
                        pl_phong.Controls.Add(dsphong);
                        vitridau.X += 165;
                    }
                    else
                    {
                        PhongCuaKhach dsphong = new PhongCuaKhach();
                        dsphong.MACHINHANH = machinhanh;
                        dsphong.MAPHONG = table.Tables[0].Rows[i][6].ToString();
                        BO_QuanLiChiNhanh quanli1 = new BO_QuanLiChiNhanh();
                        DTO_Phong phong1 = new DTO_Phong();
                        phong1.MaPhong = table.Tables[0].Rows[i][6].ToString();
                        phong1.MaChiNhanh = machinhanh;
                        DataSet KQ =  quanli1.LayTenPhong(phong1);
                        dsphong.TENPHONG = KQ.Tables[0].Rows[0][2].ToString();
                        dsphong.SDT = table.Tables[0].Rows[i][7].ToString();
                        dsphong.TENCHINHANH = tenchinhanh;
                        dsphong.TENNV = tennv;
                        dsphong.MANV = manv;
                        dsphong.MAHD = table.Tables[0].Rows[i][3].ToString();
                        dsphong.Location = vitridau;
                        pl_phong.Controls.Add(dsphong);
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yêuCầuCủaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeuCauKhachHang yeucau = new YeuCauKhachHang();
            yeucau.MANV = manv;
            yeucau.TENNV = tennv;
            yeucau.MACHINHANH = machinhanh;
            yeucau.TENCHINHANH = tenchinhanh;
            yeucau.ShowDialog();
            this.Close();
        }

        private void điềuChỉnhFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbTenChiNhanh_Click(object sender, EventArgs e)
        {

        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void tổngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manv == "210398")
            {
                this.Hide();
                BaoCaoDaLat baoCaoDaLat = new BaoCaoDaLat();
                baoCaoDaLat.MANV = manv;
                baoCaoDaLat.TENCHINHANH = tenchinhanh;
                baoCaoDaLat.TENNV = tenchinhanh;
                baoCaoDaLat.MACHINHANH = machinhanh;

                baoCaoDaLat.ShowDialog();
                this.Close();

            }
            else if (manv == "200698")
            {
                this.Hide();
                BaoCaoDaNang baoCaoDaNang = new BaoCaoDaNang();
                baoCaoDaNang.MANV = manv;
                baoCaoDaNang.TENCHINHANH = tenchinhanh;
                baoCaoDaNang.TENNV = tenchinhanh;
                baoCaoDaNang.MACHINHANH = machinhanh;

                baoCaoDaNang.ShowDialog();
                this.Close();

            }
            else if (manv == "160697")
            {
                this.Hide();
                BaoCaoHoChiMinh baoCaoHoChiMinh = new BaoCaoHoChiMinh();
                baoCaoHoChiMinh.MANV = manv;
                baoCaoHoChiMinh.TENCHINHANH = tenchinhanh;
                baoCaoHoChiMinh.TENNV = tenchinhanh;
                baoCaoHoChiMinh.MACHINHANH = machinhanh;

                baoCaoHoChiMinh.ShowDialog();
                this.Close();

            }
            else if (manv == "191203")
            {
                this.Hide();
                BaoCaoNhaTrang baoCaoNhaTrang = new BaoCaoNhaTrang();
                baoCaoNhaTrang.MANV = manv;
                baoCaoNhaTrang.TENCHINHANH = tenchinhanh;
                baoCaoNhaTrang.TENNV = tenchinhanh;
                baoCaoNhaTrang.MACHINHANH = machinhanh;

                baoCaoNhaTrang.ShowDialog();
                this.Close();

            }
            else if (manv == "190399")
            {
                this.Hide();
                BaoCaoPhuQuoc baoCaoPhuQuoc = new BaoCaoPhuQuoc();
                baoCaoPhuQuoc.MANV = manv;
                baoCaoPhuQuoc.TENCHINHANH = tenchinhanh;
                baoCaoPhuQuoc.TENNV = tenchinhanh;
                baoCaoPhuQuoc.MACHINHANH = machinhanh;

                baoCaoPhuQuoc.ShowDialog();
                this.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            
        }

        private void danhSáchPhòngChưaĐặtCọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSPhongChuaDatCoc hienthi = new DSPhongChuaDatCoc();
            hienthi.MACHINHANH = machinhanh;
            hienthi.MANV = manv;
            hienthi.TENCHINHANH = tenchinhanh;
            hienthi.TENNV = tennv;
            hienthi.ShowDialog();
            this.Close();
        }

        private void quảnLíToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
