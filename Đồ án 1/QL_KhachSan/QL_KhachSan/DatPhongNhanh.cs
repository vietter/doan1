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
    public partial class DatPhongNhanh : Form
    {
        private string options;
        public string OPTIONS
        {
            set
            {
                options = value;
            }
        }
        private string chuoiMaHD;
        private string chinhanh;
        public string CHINHANH
        {
            set
            {
                chinhanh = value;
            }
        }
        private string ngaydatphong;
        public string NGAYDATPHONG
        {
            set
            {
                ngaydatphong = value;
            }
        }
        private string ngaytraphong;
        public string NGAYTRAPHONG
        {
            set
            {
                ngaytraphong = value;
            }
        }
        private string tenvtchinhanh;
        public string TENVTCHINHANH
        {
            set
            {
                tenvtchinhanh = value;
            }
        }
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

        private string tenchinhanh;
        public string TENCHINHANH
        {
            set
            {
                tenchinhanh = value;
            }
        }

        private string mahd;
        public string MAHD
        {
            set
            {
                mahd = value;
            }
        }
        private string madv;
        public string MADV
        {
            set
            {
                madv = value;
            }
        }
        private int giatien;
        public int GIATIEN
        {
            set
            {
                giatien = value;
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
        private string tendv;
        public string TENDV
        {
            set
            {
                tendv = value;
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
        private string MaHDMoi;
        private string tenphong;
        public string TENPHONG
        {
            set
            {
                tenphong = value;
            }
        }
        public DatPhongNhanh()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;

            }
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;

            }
        }

        private void DatPhongNhanh_Load(object sender, EventArgs e)
        {
            if (sdt != null)
            {
                pl_dangnhap.Visible = false;
                txtSoDT.Text = sdt;
                txtSoDT.Enabled = false;
                DTO_KhachHang khachhang = new DTO_KhachHang();
                khachhang.SDT = txtSoDT.Text;
                BO_DangNhap laytenkh = new BO_DangNhap();
                laytenkh.KT_SDT(khachhang, ref tenkh);
                txt_Ten.Text = tenkh ;
                txt_Ten.Enabled = false;
                int NgayDat = int.Parse(ngaydatphong.Substring(0, 2));
                int ThangDat = int.Parse(ngaydatphong.Substring(3, 2));
                int NamDat = int.Parse(ngaydatphong.Substring(6, 4));
                int GioDatPhong = 12;
                int PhutDatPhong = 00;
                int NgayTra = int.Parse(ngaytraphong.Substring(0, 2));
                int ThangTra = int.Parse(ngaytraphong.Substring(3, 2));
                int NamTra = int.Parse(ngaytraphong.Substring(6, 4));
                int GioTraPhong = 12;
                int PhutTraPhong = 00;
                DateTime NgayDatPhong1 = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                DateTime NgayTraPhong1 = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
                dtpNgayDat.Value = NgayDatPhong1;
                dtpNgayTra.Value = NgayTraPhong1;
                lb_LoiSDT.Visible = false;
                lb_LoiTen.Visible = false;
                lb_Ten.Text = tenphong;

            }
            else
            {
                    int NgayDat = int.Parse(ngaydatphong.Substring(0, 2));
                    int ThangDat = int.Parse(ngaydatphong.Substring(3, 2));
                    int NamDat = int.Parse(ngaydatphong.Substring(6, 4));
                    int GioDatPhong = 12;
                    int PhutDatPhong = 00;
                    int NgayTra = int.Parse(ngaytraphong.Substring(0, 2));
                    int ThangTra = int.Parse(ngaytraphong.Substring(3, 2));
                    int NamTra = int.Parse(ngaytraphong.Substring(6, 4));
                    int GioTraPhong = 12;
                    int PhutTraPhong = 00;
                    DateTime NgayDatPhong1 = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                    DateTime NgayTraPhong1 = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
                    dtpNgayDat.Value = NgayDatPhong1;
                    dtpNgayTra.Value = NgayTraPhong1;
                    lb_LoiSDT.Visible = false;
                    lb_LoiTen.Visible = false;
                    lb_Ten.Text = tenphong;
                
               
            }
        }
        private void TaoMaHD(string NhapMaChiNhanhVao, ref string MaHDmoi)
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.MaHD = NhapMaChiNhanhVao;
            BO_DatPhong MaHD = new BO_DatPhong();
            DataSet result = MaHD.KiemTraMaHD(hoadon);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                string NgayThangNam;
                string TenChiNhanh;
                int STTtrongNgay;
                chuoiMaHD = result.Tables[0].Rows[0][0].ToString();
                if (hoadon.MaHD == "HCM")
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
                    if (STTtrongNgay < 9)
                    {
                        STTtrongNgay += 1;
                        string STT = "00" + STTtrongNgay.ToString();
                        MaHDmoi = TenChiNhanh + "-" + NgayThangNam + "-" + STT;
                    }
                    else
                    {
                        if (STTtrongNgay < 99)
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
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {

            if (txtSoDT.Text == "(+84) ")
            {
                lb_LoiSDT.Visible = true;
                lb_LoiSDT.Text = "Bạn chưa nhập  số điện thoại";

            }
            else
            {
                lb_LoiSDT.Visible = false;
            }
            if (txt_Ten.Text == "")
            {
                lb_LoiTen.Visible = true;
                lb_LoiTen.Text = "Bạn chưa điền tên";
            }
            else
            {
                lb_LoiTen.Visible = false;
            }
            if (lb_LoiTen.Visible == false && lb_LoiSDT.Visible == false)
            {
                DialogResult answer;
                answer = MessageBox.Show("Bạn có muốn đặt phòng chứ ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    BO_DatPhong datphong = new BO_DatPhong();
                    DTO_HoaDon phong = new DTO_HoaDon();
                    TaoMaHD(tenvtchinhanh, ref MaHDMoi);
                    phong.MaHD = MaHDMoi;
                    phong.MaPhong = maphong;
                    int NgayDat = int.Parse(dtpNgayDat.Text.Substring(0, 2));
                    int ThangDat = int.Parse(dtpNgayDat.Text.Substring(3, 2));
                    int NamDat = int.Parse(dtpNgayDat.Text.Substring(6, 4));
                    int GioDatPhong = 12;
                    int PhutDatPhong = 00;
                    int NgayTra = int.Parse(dtpNgayTra.Text.Substring(0, 2));
                    int ThangTra = int.Parse(dtpNgayTra.Text.Substring(3, 2));
                    int NamTra = int.Parse(dtpNgayTra.Text.Substring(6, 4));
                    int GioTraPhong = 12;
                    int PhutTraPhong = 00;
                    DateTime NgayDatPhong1 = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                    DateTime NgayTraPhong1 = new DateTime(NamTra, ThangTra, NgayTra, GioTraPhong, PhutTraPhong, 0);
                    phong.NgayDatPhong = NgayDatPhong1;
                    phong.NgayTraPhong = NgayTraPhong1;
                    phong.SoDienThoai = txtSoDT.Text;
                    phong.MaChiNhanh = machinhanh;
                    phong.MaDV = madv;
                    phong.TenDichVu = tendv;
                    phong.ThanhTien = giatien;
                    phong.DapUng = "Yes";
                    TimeSpan ts = new TimeSpan();
                    ts = NgayTraPhong1 - NgayDatPhong1;
                    phong.STT = 1;
                    double count = ts.TotalDays;
                    phong.SoLuong = (int)count + 1;
                    phong.ThanhTien = 400000 * phong.SoLuong;
                    BO_DatPhong datphongnhanh = new BO_DatPhong();
                    if (datphongnhanh.DatPhong(phong) != -1)
                    {
                        DTO_Phong phong1 = new DTO_Phong();
                        phong1.SDT = txtSoDT.Text;
                        phong1.MaPhong = maphong;
                        phong1.MaChiNhanh = machinhanh;
                        BO_DatPhong dungphong = new BO_DatPhong();
                        if (dungphong.SuDungPhong(phong1) != -1)
                        {

                            MessageBox.Show("Đặt phòng thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            
                            BO_DangNhap kiemtrakh = new BO_DangNhap();
                            DTO_KhachHang khachhang = new DTO_KhachHang();
                            khachhang.SDT = txtSoDT.Text;
                            DataSet result = kiemtrakh.KT_SDT(khachhang, ref tenkh);
                            if(result.Tables.Count >0 && result.Tables[0].Rows.Count >0)
                            {
                                

                            }
                            else
                            {
                                //Néu khách hàng đặt lần đầu
                                khachhang.TenKH = txt_Ten.Text;
                                khachhang.MatKhau = "";
                                khachhang.TichLuy = 0;
                                khachhang.CauHoiBiMat = "";
                                khachhang.CMND = "";
                                khachhang.TraLoi = "";
                                //lưu thông tin lại
                                BO_DangKi dangki = new BO_DangKi();
                                dangki.DangKi(khachhang);

                            }
                            XacNhan xacnhan = new XacNhan();
                            xacnhan.MAHD = MaHDMoi;
                            xacnhan.MACHINHANH = machinhanh;
                            xacnhan.MAPHONG = maphong;
                            xacnhan.TENPHONG = tenphong;
                            xacnhan.TENKH = txt_Ten.Text;
                            xacnhan.DANHXUNG = cbb_DanhXung.Text;
                            xacnhan.SDT = txtSoDT.Text;
                            xacnhan.NGAYDAT = dtpNgayDat.Text;
                            xacnhan.NGAYTRA = dtpNgayTra.Text;
                            xacnhan.GIATIEN = phong.ThanhTien;
                            xacnhan.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đặt phòng không thành công, vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void txtSoDT_Click(object sender, EventArgs e)
        {
            txtSoDT.Text = "";
        }

        private void txt_Ten_Click(object sender, EventArgs e)
        {
            txt_Ten.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();            
            dangnhap.ShowDialog();
            this.Close();
            
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKi dangki = new DangKi();           
            dangki.ShowDialog();
            this.Close();
        }
    }
}
