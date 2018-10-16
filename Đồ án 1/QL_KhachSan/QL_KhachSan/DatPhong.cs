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
        }
        private void TaoMaHD(string NhapMaChiNhanhVao, ref string MaHDmoi)
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaHD = NhapMaChiNhanhVao;
            BO_DatPhong MaHD = new BO_DatPhong();
            DataSet result = MaHD.KiemTraMaHD(hoadon);
            if(result.Tables.Count >0 && result.Tables[0].Rows.Count >0)
            {
                string NgayThangNam;
                string TenChiNhanh;
                int STTtrongNgay;
                chuoiMaHD = result.Tables[0].Rows[0][0].ToString();
                if(hoadon.MaHD =="HCM")
                {
                    TenChiNhanh = chuoiMaHD.Substring(0, 3);
                    NgayThangNam = chuoiMaHD.Substring(4, 8);
                    STTtrongNgay = int.Parse(chuoiMaHD.Substring(13, 3));
                }
                else
                {
                    TenChiNhanh = chuoiMaHD.Substring(0, 2);
                    NgayThangNam = chuoiMaHD.Substring(3, 8);
                    STTtrongNgay = int.Parse(chuoiMaHD.Substring(12, 3));

                }
                if (NgayThangNam == DateTime.Now.ToShortDateString())
                {
                    if(STTtrongNgay<9)
                    {
                        STTtrongNgay += 1;
                        string STT = "00" + STTtrongNgay.ToString();
                        MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
                    }
                    else
                    {
                        if(STTtrongNgay<99)
                        {
                            STTtrongNgay += 1;
                            string STT = "0" + STTtrongNgay.ToString();
                            MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
                        }
                        else
                        {
                            STTtrongNgay += 1;
                            string STT = STTtrongNgay.ToString();
                            MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
                        }
                    }
                }
                else
                {
                    NgayThangNam = DateTime.Now.ToShortDateString();
                    string STT = "001";
                    MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
                }
            }
            else
            {
                string TenChiNhanh = NhapMaChiNhanhVao;
                string NgayThangNam = DateTime.Now.ToShortDateString();

                string STT = "001";
                MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
            }

        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            btnDatPhong.Visible = false;
            btnKiemTra.Visible = true;
            txtGioTraPhong.ResetText();
            dtpNgayDat.ResetText();
            dtpNgayTra.ResetText();
            pTimKiem.Visible = true;
            pCheck.Visible = false;
            pDennie.Visible = false;
            btnDatPhong.Visible = false;
            lbKetQua.Visible = false;
            lbNoiO.Visible = false;
            lbThoiGianDatPhong.Visible = false;
            lbThoiGianTraPhong.Visible = false;
            txtGioDatPhong.ResetText();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            DTO_HoaDon phong = new DTO_HoaDon();
            TaoMaHD(MaHD, ref MaHDMoi);
            phong.MaHD = MaHDMoi;
            phong.MaPhong = MaPhong;
            int NgayDat = int.Parse(dtpNgayDat.Text.Substring(0, 2));
            int ThangDat = int.Parse(dtpNgayDat.Text.Substring(3, 2));
            int NamDat = int.Parse(dtpNgayDat.Text.Substring(6, 4));
            int GioDatPhong = int.Parse(txtGioDatPhong.Text.Substring(0, 2));
            int PhutDatPhong = int.Parse(txtGioDatPhong.Text.Substring(3, 2));
            int NgayTra = int.Parse(dtpNgayTra.Text.Substring(0, 2));
            int ThangTra = int.Parse(dtpNgayTra.Text.Substring(3, 2));
            int NamTra = int.Parse(dtpNgayTra.Text.Substring(6, 4));
            int GioTraPhong = int.Parse(txtGioTraPhong.Text.Substring(0, 2));
            int PhutTraPhong = int.Parse(txtGioTraPhong.Text.Substring(3, 2));
            DateTime NgayDatPhong1 = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
            DateTime NgayTraPhong1 = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
            phong.NgayDatPhong = NgayDatPhong1;
            phong.NgayTraPhong = NgayTraPhong1;
            if (cbbDiaChi.Text == "Đà Lạt- Khách sạn The New Star 1- địa chỉ: 69 Hồ Tùng Mậu, Phường 1, Thành Phố Đà Lạt, tỉnh Lâm Đồng")
            {
                phong.MaChiNhanh = "DL_TNS1";
            }
            else
            {
                if (cbbDiaChi.Text == "Hồ Chí Minh - Khách sạn The New Star 2- địa chỉ :1 Đồng Khởi, Bến Nghé, Quận 1, Thành Phố Hồ Chí Minh")
                {
                    phong.MaChiNhanh = "HCM_TNS2";
                }
                else
                {
                    if (cbbDiaChi.Text == "Đà Nẵng - Khách sạn The New Star 3- địa chỉ: 99 Võ Nguyên Giáp, Bắc Mỹ An, Ngũ Hành Sơn, Thành Phố Đà Nẵng")
                    {
                        phong.MaChiNhanh = "DN_TNS3";
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
            phong.SoDienThoai = sdt;
            phong.MaDV = "DV_THUEPHONG";
            phong.TenDichVu = "Thuê Phòng";
            TimeSpan ts = new TimeSpan();
            ts =  NgayTraPhong1 - NgayDatPhong1;
            phong.STT = 1;
            double count = ts.TotalDays;
            phong.SoLuong = (int)count+1;
            phong.ThanhTien = 400000 * phong.SoLuong;
            BO_DatPhong datphong = new BO_DatPhong();
            if(datphong.DatPhong(phong) != -1)
            {
                DTO_Phong phong1 = new DTO_Phong();
                phong1.SDT = sdt;
                phong1.MaPhong = MaPhong;
                phong1.MaChiNhanh = phong.MaChiNhanh;
                BO_DatPhong dungphong = new BO_DatPhong();
                if(dungphong.SuDungPhong(phong1) != -1)
                {
                    lbKetQua.Visible = false;
                    MessageBox.Show("Đặt phòng thành công - cảm ơn bạn đã sử dụng dịch vụ của chúng tôi ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    GiaoDienKhachHang KhachHang = new GiaoDienKhachHang();
                    KhachHang.SDT = sdt;
                    KhachHang.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Đặt phòng không thành công, vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                load();
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (dtpNgayDat.Text == dtpNgayTra.Text && txtGioDatPhong.Text == txtGioTraPhong.Text)
            {
                lbKetQua.Text = "Thời gian đặt phòng và \n thời gian trả phòng trùng nhau !!!";
                lbKetQua.Visible = true;
               
            }
            else
            {
                lbKetQua.Visible = false;
               
            }
            if (txtGioDatPhong.Text == "  :")
            {
                lbThoiGianDatPhong.Visible = true;
               
            }
            else
            {
                lbThoiGianDatPhong.Visible = false;
               
            }
            if (txtGioTraPhong.Text == "  :")
            {
                lbThoiGianTraPhong.Visible = true;
               
            }
            else
            {
                lbThoiGianTraPhong.Visible = false;
               
            }
            if (cbbDiaChi.Text == "")
            {
                lbNoiO.Visible = true;
                
            }
            else
            {
                lbNoiO.Visible = false;
                if (cbbDiaChi.Text == "Đà Lạt- Khách sạn The New Star 1- địa chỉ: 69 Hồ Tùng Mậu, Phường 1, Thành Phố Đà Lạt, tỉnh Lâm Đồng")
                {
                    MaHD = "DL";
                }
                else
                {
                    if (cbbDiaChi.Text == "Hồ Chí Minh - Khách sạn The New Star 2- địa chỉ :1 Đồng Khởi, Bến Nghé, Quận 1, Thành Phố Hồ Chí Minh")
                    {
                        MaHD = "HCM";
                    }
                    else
                    {
                        if (cbbDiaChi.Text == "Đà Nẵng - Khách sạn The New Star 3- địa chỉ: 99 Võ Nguyên Giáp, Bắc Mỹ An, Ngũ Hành Sơn, Thành Phố Đà Nẵng")
                        {
                            MaHD = "DN";
                        }
                        else
                        {
                            if (cbbDiaChi.Text == "Nha Trang- Khách sạn The New Star 4- địa chỉ: 50 Trần Phú, Lộc Thọ, Thành phố Nha Trang, Khánh Hòa")
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



            }

            if (lbKetQua.Visible == false && lbNoiO.Visible == false && lbThoiGianDatPhong.Visible == false && lbThoiGianTraPhong.Visible == false)
            {

                {

                    TimeSpan ts = new TimeSpan();
                    int NgayDat = int.Parse(dtpNgayDat.Text.Substring(0, 2));
                    int ThangDat = int.Parse(dtpNgayDat.Text.Substring(3, 2));
                    int NamDat = int.Parse(dtpNgayDat.Text.Substring(6, 4));
                    int GioDatPhong = int.Parse(txtGioDatPhong.Text.Substring(0, 2));
                    int PhutDatPhong = int.Parse(txtGioDatPhong.Text.Substring(3, 2));
                    int NgayTra = int.Parse(dtpNgayTra.Text.Substring(0, 2));
                    int ThangTra = int.Parse(dtpNgayTra.Text.Substring(3, 2));
                    int NamTra = int.Parse(dtpNgayTra.Text.Substring(6, 4));
                    int GioTraPhong = int.Parse(txtGioTraPhong.Text.Substring(0, 2));
                    int PhutTraPhong = int.Parse(txtGioTraPhong.Text.Substring(3, 2));
                    if (GioDatPhong >= 24 || PhutTraPhong >= 60 || GioTraPhong >= 24 || PhutTraPhong >= 60)
                    {
                        pDennie.Visible = true;
                        pCheck.Visible = false;
                        pTimKiem.Visible = false;
                        MessageBox.Show("Định dạng ngày giờ sai vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        load();


                    }
                    else
                    {
                        DateTime NgayDatPhong = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                        DateTime NgayTraPhong = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
                        ts = NgayTraPhong - NgayDatPhong;
                        if (ts.TotalDays < 0)
                        {
                            pDennie.Visible = true;
                            pCheck.Visible = false;
                            pTimKiem.Visible = false;
                            MessageBox.Show("Ngày Đặt Phòng không thể sau ngày Trả Phòng được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            load();
                        }
                        else
                        {
                            if (NgayDatPhong.Day < DateTime.Now.Day)
                            {
                                pDennie.Visible = true;
                                pCheck.Visible = false;
                                pTimKiem.Visible = false;
                                MessageBox.Show("Bạn không thể đặt trong quá khứ được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                load();

                            }
                            else
                            {
                                DTO_HoaDon phong = new DTO_HoaDon();
                                phong.MaChiNhanh = MaHD;
                                BO_DatPhong kiemtra = new BO_DatPhong();
                                string GiaTriMaPhong = null;
                                DataSet result = kiemtra.KiemTraPhongTrong(phong, ref GiaTriMaPhong);
                                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                                {
                                    lbKetQua.Visible = true;
                                    lbKetQua.ForeColor = Color.Blue;
                                    pDennie.Visible =false;
                                    pCheck.Visible = true;
                                    pTimKiem.Visible = false;
                                    lbKetQua.Text = "Hiện đang có phòng trống, bạn có muốn đặt phòng không ?";
                                    btnDatPhong.Visible = true;
                                    btnKiemTra.Visible = false;
                                    MaPhong = GiaTriMaPhong;

                                }
                                else
                                {
                                    pDennie.Visible = true;
                                    pCheck.Visible = false;
                                    pTimKiem.Visible = false;
                                    MessageBox.Show("Phòng của chi nhánh này đã hết, hãy liên hệ với nhân viên khi có phòng chúng tôi sẽ liên hệ lại bạn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                }
                            }
                        }
                    }

                }
            }
            else
            {
               
                    pDennie.Visible = true;
                    pCheck.Visible = false;
                    pTimKiem.Visible = false;
              
            }
          
               
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbThoiGian_Click(object sender, EventArgs e)
        {

        }

        private void txtGioDatPhong_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtGioDatPhong_Click(object sender, EventArgs e)
        {
            txtGioDatPhong.ResetText();
            txtGioDatPhong.Focus();
        }

        private void txtGioTraPhong_Click(object sender, EventArgs e)
        {
            txtGioTraPhong.ResetText();
            txtGioTraPhong.Focus();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienKhachHang khachhang = new GiaoDienKhachHang();
            khachhang.SDT = sdt;
            khachhang.ShowDialog();
            this.Close();
        }
    }
}
