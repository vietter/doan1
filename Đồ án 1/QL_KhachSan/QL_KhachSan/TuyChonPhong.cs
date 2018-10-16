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
using System.Globalization;
namespace QL_KhachSan
{
    public partial class TuyChonPhong : Form
    {
        private int soluong = 1;
        public int SOLUONG
        {
            set
            {
                soluong = value;
            }
        }
        int total = 0;
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

        public TuyChonPhong()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void TuyChonPhong_Load(object sender, EventArgs e)
        {
            pl_DichVuThue.Visible = false;
            pl_ThucAn.Visible = false;
            pl_ThucUong.Visible = false;
            pl_TienIch.Visible = false;
            txtTenPhong.Text = maphong;
            HienThi();
        }
        private void HienThi()
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaHD = mahd;
            BO_ChiTietPhong hienthi = new BO_ChiTietPhong();
            DataSet table = hienthi.HienThi(hoadon);
            if (table.Tables.Count > 0 && table != null)
            {
                dgvHienThi.DataSource = table.Tables[0];
            }
            total = 0;
            if (dgvHienThi.Rows.Count != 0)
            {
                for (int i = 0; i < dgvHienThi.Rows.Count - 1; i++)
                {
                    total += int.Parse(dgvHienThi.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
            }
            txtTong.Text = total.ToString();

        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienKhachHang khachhang = new GiaoDienKhachHang();
            khachhang.SDT = sdt;
            khachhang.ShowDialog();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Thuê Ô Tô";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TI_THUEOTO";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 500000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            soluong = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            soluong = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            soluong = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            soluong = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            soluong = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            soluong = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            soluong = 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            soluong = 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            soluong = 9;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            soluong = 10;
        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pl_ThucUong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Sữa";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_SUA";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 40000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Nước khoáng";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_NUOC";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 10000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pl_DichVuThue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Coca-Cola";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_COCA";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 15000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Pepsi";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_PEPSI";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 15000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Nước Cam";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_NUOCCAM";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 35000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Monster";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TU_MONSTER";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 50000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Sữa Chữa Xe ";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TI_SUACHUA";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = 0;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Thuê Xe Máy";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TI_THUEXEMAY";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 200000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Dọn Phòng";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TI_DONPHONG";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 50000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pl_TienIch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Ghế Massage";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "DVP_GHEMASSAGE";
            SoLuong number = new SoLuong();
            number.DonVi("Giờ");
            number.ShowDialog();
            number.soluong(ref soluong);
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 100000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Bao Cao Su";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "DVP_BCS";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 45000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Ipad";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "DVP_IPAD";
            SoLuong number = new SoLuong();
            number.DonVi("Ngày");
            number.ShowDialog();
            number.soluong(ref soluong);
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 50000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Massage";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "DVP_MASSAGE";
            SoLuong number = new SoLuong();
            number.DonVi("Suất");
            number.ShowDialog();
            number.soluong(ref soluong);
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 150000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "LapTop";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "DVP_LAPTOP";
            SoLuong number = new SoLuong();
            number.DonVi("Ngày");
            number.ShowDialog();
            number.soluong(ref soluong);
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 70000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();

        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            pl_ThucUong.Visible = true;
            pl_ThucAn.Visible = false;
            pl_TienIch.Visible = false;
            pl_DichVuThue.Visible = false;
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {

            pl_ThucUong.Visible = false;
            pl_ThucAn.Visible = true;
            pl_TienIch.Visible = false;
            pl_DichVuThue.Visible = false;
        }

        private void btnTienIch_Click(object sender, EventArgs e)
        {

            pl_ThucUong.Visible = false;
            pl_ThucAn.Visible = false;
            pl_TienIch.Visible = true;
            pl_DichVuThue.Visible = false;
        }

        private void btnDichVuPhu_Click(object sender, EventArgs e)
        {

            pl_ThucUong.Visible = false;
            pl_ThucAn.Visible = false;
            pl_TienIch.Visible = false;
            pl_DichVuThue.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Phở Bò";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TA_PHOBO";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 45000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Gà Quay";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TA_GAQUAY";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 350000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Hamburger";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TA_HAMBURGER";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 35000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Pizza Hải Sản";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TA_PIZZAHS";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 268000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dichvu = new DTO_HoaDon();
            dichvu.TenDichVu = "Bánh Mì";
            dichvu.MaHD = mahd;
            dichvu.MaChiNhanh = machinhanh;
            dichvu.MaPhong = maphong;
            dichvu.SoDienThoai = sdt;
            int DongCuoi = dgvHienThi.Rows.Count - 2;
            int STT = int.Parse(dgvHienThi.Rows[DongCuoi].Cells["STT"].Value.ToString()) + 1;
            dichvu.STT = STT;
            dichvu.MaDV = "TA_BANHMI";
            dichvu.SoLuong = soluong;
            dichvu.ThanhTien = soluong * 20000;
            dichvu.NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayDatPhong"].Value.ToString());
            dichvu.NgayTraPhong = Convert.ToDateTime(dgvHienThi.Rows[DongCuoi].Cells["NgayTraPhong"].Value.ToString());
            BO_ChiTietPhong them = new BO_ChiTietPhong();
            them.ThemDV(dichvu);
            HienThi();
        }

        private void pl_ThucAn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.CurrentRow.Cells["STT"].Value.ToString() == "1")
            {
                MessageBox.Show("Bạn không thể xóa dịch vụ THUÊ PHÒNG được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int STT = int.Parse(dgvHienThi.CurrentRow.Cells["STT"].Value.ToString());
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.MaHD = mahd;
                hoadon.STT = STT;
                BO_ChiTietPhong xoadv = new BO_ChiTietPhong();
                xoadv.XoaDV(hoadon);
                HienThi();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTong.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTong.Text = String.Format(culture, "{0:N0}", value);
            txtTong.Select(txtTong.Text.Length, 0);
        }

        private void pDoiPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiPhong doi = new DoiPhong();
            doi.SDT = sdt;
            doi.MAHD = mahd;
            doi.MACHINHANH = machinhanh;
            doi.MAPHONG = maphong;
            doi.TENPHONG = tenphong;
            doi.ShowDialog();
            this.Close();
        }

        private void pHuyPhong_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Bạn có muốn hủy phòng chứ ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                if (dgvHienThi.Rows.Count == 2)
                {
                    DateTime NgayDatPhong = Convert.ToDateTime(dgvHienThi.Rows[0].Cells["NgayDatPhong"].Value.ToString());
                    DateTime now = DateTime.Now;
                    TimeSpan ts = new TimeSpan();
                    ts = now - NgayDatPhong;
                    if(ts.TotalDays >1)
                    {
                        MessageBox.Show("Phòng đã sử dụng hơn 1 ngày không thể hủy được !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        DTO_HoaDon hoadon = new DTO_HoaDon();
                        hoadon.SoDienThoai = "Free";
                        hoadon.MaPhong = maphong;
                        hoadon.MaChiNhanh = machinhanh;
                        BO_HuyPhong giaiphongphong = new BO_HuyPhong();
                        if(giaiphongphong.HuyPhong(hoadon) != -1)
                        {
                            DTO_HoaDon hoadon2 = new DTO_HoaDon();
                            hoadon2.MaHD = mahd;
                            BO_HuyPhong xoahoadon = new BO_HuyPhong();
                            if(xoahoadon.HuyHoaDon(hoadon2) != -1)
                            {
                                MessageBox.Show("Đã hủy phòng thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                GiaoDienKhachHang khachhang = new GiaoDienKhachHang();
                                khachhang.SDT = sdt;
                                khachhang.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lỗi khi xóa hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi giải phóng phòng, vui lòng thử lại !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng thanh toán hết dịch vụ của bạn trước khi hủy phòng !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
