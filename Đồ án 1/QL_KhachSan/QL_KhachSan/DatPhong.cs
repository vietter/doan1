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
    public partial class DatPhong : Form
    {
        private string MaHDMoi;
        private string chuoiMaHD;
        private string MaHD;
        private string MaPhong;
        private string sdt;
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
            }
        }
        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        public DatPhong()
        {
          
            InitializeComponent();
            pl_phong.AutoScroll = false;
            pl_phong.HorizontalScroll.Enabled = false;
            pl_phong.HorizontalScroll.Visible = false;
            pl_phong.HorizontalScroll.Maximum = 0;
            pl_phong.AutoScroll = true;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            dtpNgayDat.MaxDate = DateTime.Now.AddDays(60);
            dtpNgayDat.MinDate = DateTime.Now;
            dtpNgayTra.MinDate = DateTime.Now.AddDays(1);
            cbb_SoNguoi.Text = "Tất Cả";


        }
        private void load()
        {
            pl_phong.Controls.Clear();
        }



        private void pTimKiem_Click(object sender, EventArgs e)
        {
            load();

            if (cbbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nơi ở", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (cbbDiaChi.Text == "Đà Lạt")
                {
                    MaHD = "DL";
                }
                else
                {
                    if (cbbDiaChi.Text == "Hồ Chí Minh")
                    {
                        MaHD = "HCM";
                    }
                    else
                    {
                        if (cbbDiaChi.Text == "Đà Nẵng")
                        {
                            MaHD = "DN";
                        }
                        else
                        {
                            if (cbbDiaChi.Text == "Nha Trang")
                            {
                                MaHD = "NT";
                            }
                            else
                            {
                                MaHD = "PQ";
                            }
                        }
                    }

                }
                if (dtpNgayDat.Text == dtpNgayTra.Text)
                {
                    MessageBox.Show("Ngày đặt và ngày trả trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime dtp1 = new DateTime();
                    DateTime dtp2 = new DateTime();
                    catchuoi(dtpNgayTra.Text, ref dtp1);
                    catchuoi(dtpNgayDat.Text, ref dtp2);
                    TimeSpan ts = new TimeSpan();
                    ts = dtp1 - dtp2;
                    if (ts.TotalDays < 0)
                    {
                        MessageBox.Show("Ngày Đặt không thể sau Ngày Trả được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cbb_SoNguoi.Text != "Tất Cả")
                        {
                            DTO_HoaDon hoadon = new DTO_HoaDon();
                            if (cbb_SoNguoi.Text == "1-2 người (2 giường đơn)")
                            {

                                hoadon.SoNguoi = 2;
                                hoadon.LoaiPhong = "Giường Đơn";
                            }
                            else
                            {
                                if (cbb_SoNguoi.Text == "2 người (giường đôi)")
                                {

                                    hoadon.SoNguoi = 2;
                                    hoadon.LoaiPhong = "Giường Đôi";
                                }
                                else
                                {
                                    if (cbb_SoNguoi.Text == "3-4 người (4 giường đơn)")
                                    {

                                        hoadon.SoNguoi = 4;
                                        hoadon.LoaiPhong = "Giường Đơn";
                                    }
                                    else
                                    {
                                        if (cbb_SoNguoi.Text == "3-4 người (2 giường đôi)")
                                        {

                                            hoadon.SoNguoi = 4;
                                            hoadon.LoaiPhong = "Giường Đôi";
                                        }
                                        else
                                        {
                                            if (cbb_SoNguoi.Text == "5-6 người (3 giường đôi)")
                                            {

                                                hoadon.SoNguoi = 6;
                                                hoadon.LoaiPhong = "Giường Đôi";
                                            }

                                        }
                                    }
                                }
                            }
                            hoadon.MaChiNhanh = MaHD;
                            Point vitribandau = new Point(5, 5);
                            BO_DatPhong kiemtra = new BO_DatPhong();
                            DataSet table = new DataSet();
                            table = kiemtra.ChonPhong(hoadon);
                            if (table.Tables[0].Rows.Count > 0)
                            {
                                for (int i = 0; i < table.Tables[0].Rows.Count; i++)
                                {
                                    DTO_HoaDon thongtinphong = new DTO_HoaDon();
                                    thongtinphong.MaPhong = table.Tables[0].Rows[i][0].ToString();
                                    thongtinphong.MaChiNhanh = table.Tables[0].Rows[i][1].ToString();
                                    //Kiểm tra trong phòng hiện tại có nằm trong hóa đơn không, nếu không thì phòng chưa từng được đặt
                                    DataSet KTPhongtrong = new DataSet();
                                    KTPhongtrong = kiemtra.kiemtratronghoadon(thongtinphong);
                                    if (KTPhongtrong.Tables[0].Rows.Count == 0)   //Phòng hiện chưa được sử dụng lần nào => phòng trống
                                    {
                                        if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "2")
                                        {
                                            giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                            hienthi.TENVTCHINHANH = MaHD;
                                            pl_phong.Controls.Add(hienthi);
                                            hienthi.Location = vitribandau;
                                            vitribandau.Y += 295;
                                        }
                                        else
                                        {
                                            if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "2")
                                            {
                                                giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                hienthi.TENVTCHINHANH = MaHD;
                                                pl_phong.Controls.Add(hienthi);
                                                hienthi.Location = vitribandau;
                                                vitribandau.Y += 295;
                                            }
                                            else
                                            {
                                                if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                {
                                                    giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    pl_phong.Controls.Add(hienthi);
                                                    hienthi.Location = vitribandau;
                                                    vitribandau.Y += 295;
                                                }
                                                else
                                                {
                                                    if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                    {
                                                        giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        pl_phong.Controls.Add(hienthi);
                                                        hienthi.Location = vitribandau;
                                                        vitribandau.Y += 295;
                                                    }
                                                    else
                                                    {
                                                        if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "6")
                                                        {
                                                            giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                            hienthi.TENVTCHINHANH = MaHD;
                                                            pl_phong.Controls.Add(hienthi);
                                                            hienthi.Location = vitribandau;
                                                            vitribandau.Y += 295;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //Nếu có phòng đang đc sử dụng => kiểm tra xem phòng đó có trùng ngày đặt hay không
                                        DateTime ngaydat = new DateTime();
                                        DateTime ngaytra = new DateTime();
                                        catchuoi(dtpNgayDat.Text, ref ngaydat);
                                        catchuoi(dtpNgayTra.Text, ref ngaytra);
                                        TimeSpan thoigiandat = new TimeSpan();
                                        thoigiandat = ngaytra - ngaydat;
                                        for (int k = 0; k < thoigiandat.Days; k++)
                                        {
                                            SoSanhNgayDat.Add(ngaydat);
                                            ngaydat = ngaydat.AddDays(1);
                                        }
                                        int count = 0;
                                        DTO_HoaDon kt = new DTO_HoaDon();
                                        kt.MaPhong = table.Tables[0].Rows[i][0].ToString();
                                        kt.MaChiNhanh = table.Tables[0].Rows[i][1].ToString();
                                        DataSet table1 = new DataSet();
                                        table1 = kiemtra.KiemTraNgayPhongDangDuocSuDung(kt);

                                        if (table1.Tables[0].Rows.Count > 0 && table1.Tables.Count > 0)
                                        {
                                            int demhd = table1.Tables[0].Rows.Count;
                                            for (int j = 0; j < demhd; j++)
                                            {
                                                DateTime Ngay1 = new DateTime(int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(6, 2)), int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(3, 2)), int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(0, 2)));
                                                DateTime Ngay2 = new DateTime(int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(6, 2)), int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(3, 2)), int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(0, 2)));

                                                TimeSpan khoangthoigiandat = new TimeSpan();
                                                khoangthoigiandat = Ngay2 - Ngay1;
                                                for (int t = 0; t < khoangthoigiandat.Days; t++)
                                                {
                                                    NgayDaDat.Add(Ngay1);
                                                    Ngay1 = Ngay1.AddDays(1);
                                                }
                                                foreach (DateTime day in NgayDaDat)
                                                {
                                                    foreach (DateTime day1 in SoSanhNgayDat)
                                                    {
                                                        if (day == day1)
                                                        {
                                                            count++;
                                                        }
                                                    }
                                                }
                                                NgayDaDat.Clear();
                                            }
                                            if (count == 0)   //Nếu không trùng ngày nào thì hiện lên

                                            {
                                                if (hoadon.LoaiPhong == "Giường Đơn" && hoadon.SoNguoi == 2)
                                                {
                                                    giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    pl_phong.Controls.Add(hienthi);
                                                    hienthi.Location = vitribandau;
                                                    vitribandau.Y += 295;
                                                }
                                                else
                                                {
                                                    if (hoadon.LoaiPhong == "Giường Đôi" && hoadon.SoNguoi == 2)
                                                    {
                                                        giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        pl_phong.Controls.Add(hienthi);
                                                        hienthi.Location = vitribandau;
                                                        vitribandau.Y += 295;
                                                    }
                                                    else
                                                    {
                                                        if (hoadon.LoaiPhong == "Giường Đơn" && hoadon.SoNguoi == 4)
                                                        {
                                                            giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                            hienthi.TENVTCHINHANH = MaHD;
                                                            pl_phong.Controls.Add(hienthi);
                                                            hienthi.Location = vitribandau;
                                                            vitribandau.Y += 295;
                                                        }
                                                        else
                                                        {
                                                            if (hoadon.LoaiPhong == "Giường Đôi" && hoadon.SoNguoi == 4)
                                                            {
                                                                giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                                hienthi.TENVTCHINHANH = MaHD;
                                                                pl_phong.Controls.Add(hienthi);
                                                                hienthi.Location = vitribandau;
                                                                vitribandau.Y += 295;
                                                            }
                                                            else
                                                            {
                                                                if (hoadon.LoaiPhong == "Giường Đôi" && hoadon.SoNguoi == 6)
                                                                {
                                                                    giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                                    hienthi.TENVTCHINHANH = MaHD;
                                                                    pl_phong.Controls.Add(hienthi);
                                                                    hienthi.Location = vitribandau;
                                                                    vitribandau.Y += 295;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            SoSanhNgayDat.Clear();
                        }
                        else
                        {
                            Point vitribandau = new Point(5, 5);
                            DTO_HoaDon hoadon = new DTO_HoaDon();
                            hoadon.MaChiNhanh = MaHD;
                            BO_DatPhong kiemtra = new BO_DatPhong();
                            DataSet table = kiemtra.showall(hoadon);
                            if (table.Tables[0].Rows.Count > 0)
                            {
                                for (int i = 0; i < table.Tables[0].Rows.Count; i++)
                                {
                                    DTO_HoaDon thongtinphong = new DTO_HoaDon();
                                    thongtinphong.MaPhong = table.Tables[0].Rows[i][0].ToString();
                                    thongtinphong.MaChiNhanh = table.Tables[0].Rows[i][1].ToString();
                                    //Kiểm tra trong phòng hiện tại có nằm trong hóa đơn không, nếu không thì phòng chưa từng được đặt
                                    DataSet KTPhongtrong = new DataSet();
                                    KTPhongtrong = kiemtra.kiemtratronghoadon(thongtinphong);
                                    if (KTPhongtrong.Tables[0].Rows.Count == 0)
                                    {
                                        if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "2")
                                        {
                                            giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                            hienthi.TENVTCHINHANH = MaHD;
                                            pl_phong.Controls.Add(hienthi);
                                            hienthi.Location = vitribandau;
                                            vitribandau.Y += 295;
                                        }
                                        else
                                        {
                                            if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "2")
                                            {
                                                giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                hienthi.TENVTCHINHANH = MaHD;
                                                pl_phong.Controls.Add(hienthi);
                                                hienthi.Location = vitribandau;
                                                vitribandau.Y += 295;
                                            }
                                            else
                                            {
                                                if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                {
                                                    giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    pl_phong.Controls.Add(hienthi);
                                                    hienthi.Location = vitribandau;
                                                    vitribandau.Y += 295;
                                                }
                                                else
                                                {
                                                    if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                    {
                                                        giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        pl_phong.Controls.Add(hienthi);
                                                        hienthi.Location = vitribandau;
                                                        vitribandau.Y += 295;
                                                    }
                                                    else
                                                    {
                                                        if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "6")
                                                        {
                                                            giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                            hienthi.TENVTCHINHANH = MaHD;
                                                            pl_phong.Controls.Add(hienthi);
                                                            hienthi.Location = vitribandau;
                                                            vitribandau.Y += 295;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        DateTime ngaydat = new DateTime();
                                        DateTime ngaytra = new DateTime();
                                        catchuoi(dtpNgayDat.Text, ref ngaydat);
                                        catchuoi(dtpNgayTra.Text, ref ngaytra);
                                        TimeSpan thoigiandat = new TimeSpan();
                                        thoigiandat = ngaytra - ngaydat;
                                        for (int k = 0; k < thoigiandat.Days; k++)
                                        {
                                            SoSanhNgayDat.Add(ngaydat);
                                            ngaydat = ngaydat.AddDays(1);
                                        }
                                        int count = 0;
                                        DTO_HoaDon kt = new DTO_HoaDon();
                                        kt.MaPhong = table.Tables[0].Rows[i][0].ToString();
                                        kt.MaChiNhanh = table.Tables[0].Rows[i][1].ToString();
                                        DataSet table1 = new DataSet();
                                        table1 = kiemtra.KiemTraNgayPhongDangDuocSuDung(kt);
                                        if (table1.Tables[0].Rows.Count > 0 && table1.Tables.Count > 0)
                                        {
                                            int demhd = table1.Tables[0].Rows.Count;
                                            for (int j = 0; j < demhd; j++)
                                            {
                                                DateTime Ngay1 = new DateTime(int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(6,2)),int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(3,2)),int.Parse(table1.Tables[0].Rows[j][8].ToString().Substring(0,2)));
                                                DateTime Ngay2 = new DateTime(int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(6,2)), int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(3, 2)), int.Parse(table1.Tables[0].Rows[j][9].ToString().Substring(0, 2)));
                                                
                                                TimeSpan khoangthoigiandat = new TimeSpan();
                                                khoangthoigiandat = Ngay2 - Ngay1;
                                                for (int t = 0; t < khoangthoigiandat.Days; t++)
                                                {
                                                    NgayDaDat.Add(Ngay1);
                                                    Ngay1 = Ngay1.AddDays(1);
                                                }
                                                foreach (DateTime day in NgayDaDat)
                                                {
                                                    foreach (DateTime day1 in SoSanhNgayDat)
                                                    {
                                                        if (day == day1)
                                                        {
                                                            count++;
                                                        }
                                                    }
                                                }
                                                NgayDaDat.Clear();
                                            }
                                        }
                                        if (count == 0)
                                        {
                                            if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "2")
                                            {
                                                giuongdon2nguoi hienthi = new giuongdon2nguoi();
                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                hienthi.TENVTCHINHANH = MaHD;
                                                pl_phong.Controls.Add(hienthi);
                                                hienthi.Location = vitribandau;
                                                vitribandau.Y += 295;
                                            }
                                            else
                                            {
                                                if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "2")
                                                {
                                                    giuongdoi2nguoi hienthi = new giuongdoi2nguoi();
                                                    hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                    hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                    hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                    hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                    hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                    hienthi.TENVTCHINHANH = MaHD;
                                                    pl_phong.Controls.Add(hienthi);
                                                    hienthi.Location = vitribandau;
                                                    vitribandau.Y += 295;
                                                }
                                                else
                                                {
                                                    if (table.Tables[0].Rows[i][3].ToString() == "Giường Đơn" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                    {
                                                        giuongdon4nguoi hienthi = new giuongdon4nguoi();
                                                        hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                        hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                        hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                        hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                        hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                        hienthi.TENVTCHINHANH = MaHD;
                                                        pl_phong.Controls.Add(hienthi);
                                                        hienthi.Location = vitribandau;
                                                        vitribandau.Y += 295;
                                                    }
                                                    else
                                                    {
                                                        if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "4")
                                                        {
                                                            giuongdoi4nguoi hienthi = new giuongdoi4nguoi();
                                                            hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                            hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                            hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                            hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                            hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                            hienthi.TENVTCHINHANH = MaHD;
                                                            pl_phong.Controls.Add(hienthi);
                                                            hienthi.Location = vitribandau;
                                                            vitribandau.Y += 295;
                                                        }
                                                        else
                                                        {
                                                            if (table.Tables[0].Rows[i][3].ToString() == "Giường Đôi" && table.Tables[0].Rows[i][4].ToString() == "6")
                                                            {
                                                                giuongdoi6nguoi hienthi = new giuongdoi6nguoi();
                                                                hienthi.MAPHONG = table.Tables[0].Rows[i][0].ToString();
                                                                hienthi.MACHINHANH = table.Tables[0].Rows[i][1].ToString();
                                                                hienthi.TENPHONG = table.Tables[0].Rows[i][2].ToString();
                                                                hienthi.NGAYDATPHONG = dtpNgayDat.Text;
                                                                hienthi.NGAYTRAPHONG = dtpNgayTra.Text;
                                                                hienthi.TENVTCHINHANH = MaHD;
                                                                pl_phong.Controls.Add(hienthi);
                                                                hienthi.Location = vitribandau;
                                                                vitribandau.Y += 295;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                }
                            }
                            SoSanhNgayDat.Clear();

                        }
                    }
                }
            
        }
        private void catchuoi(string chuoi, ref DateTime ngay)
        {
            int Ngay = int.Parse(chuoi.Substring(0, 2));
            int Thang = int.Parse(chuoi.Substring(3, 2));
            int Nam = int.Parse(chuoi.Substring(8, 2));
            ngay = new DateTime(Nam,Thang,Ngay);
        }
        private List<DateTime> SoSanhNgayDat = new List<DateTime>();
        private List<DateTime> NgayDaDat = new List<DateTime>();
 
       

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi dangki = new DangKi();
            dangki.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
