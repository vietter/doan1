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
    public partial class DatPhong : Form
    {
        int GioDatPhong = DateTime.Now.Hour;
        int PhutDatPhong = DateTime.Now.Minute + 5;
        
       
        bool KT = false;
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

        private void DatPhong_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            pCheck.Visible = false;
            pDennie.Visible = false;
            btnDatPhong.Visible = false;
            lbKetQua.Visible = false;
            lbNoiO.Visible = false;
            lbThoiGianDatPhong.Visible = false;
            if(PhutDatPhong >= 60)
            {
                PhutDatPhong = PhutDatPhong - 60;
                GioDatPhong=GioDatPhong + 1;
            }
            string DinhDangPhut;
            string DinhDangGio;
            if(PhutDatPhong<10 )
            {
                DinhDangPhut = "0" + PhutDatPhong.ToString();
            }
            else
            {
                DinhDangPhut = PhutDatPhong.ToString();
            }
            if(GioDatPhong <10)
            {
                DinhDangGio = "0" + GioDatPhong.ToString();
            }
            else
            {
                DinhDangGio = GioDatPhong.ToString();
            }
            txtGioDatPhong.Text = DinhDangGio + DinhDangPhut ;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(KT == false)
            {
                
                if(dtpNgayDat.Text == dtpNgayTra.Text && txtGioDatPhong.Text == txtGioTraPhong.Text)
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
                    lbThoiGianDatPhong.Visible = true;
                }
                else
                {
                    
                }
                if(cbbDiaChi.Text =="")
                {
                    lbNoiO.Visible = true;
                   
                }
                else
                {
                    lbNoiO.Visible = false;
                }
                if(lbKetQua.Visible == false && lbNoiO.Visible == false)
                {
                    pDennie.Visible = false;
                    pTimKiem.Visible = true;
                }
                else
                {
                    pDennie.Visible = true;
                    pTimKiem.Visible = false;
                }
                if (lbKetQua.Visible == false && lbNoiO.Visible == false && lbThoiGianDatPhong.Visible == false)
                {
                    int GioTraPhong = int.Parse(txtGioTraPhong.Text.Substring(0, 2));
                    int PhutTraPhong = int.Parse(txtGioTraPhong.Text.Substring(3, 2));
                    TimeSpan ts = new TimeSpan();
                    int NgayDat = int.Parse(dtpNgayDat.Text.Substring(0, 2));
                    int ThangDat = int.Parse(dtpNgayDat.Text.Substring(3, 2));
                    int NamDat = int.Parse(dtpNgayDat.Text.Substring(6, 4));

                    int NgayTra = int.Parse(dtpNgayTra.Text.Substring(0, 2));
                    int ThangTra = int.Parse(dtpNgayTra.Text.Substring(3, 2));
                    int NamTra = int.Parse(dtpNgayTra.Text.Substring(6, 4));
                    DateTime NgayDatPhong = new DateTime(NamDat, ThangDat, NgayDat, GioDatPhong, PhutDatPhong, 0);
                    DateTime NgayTraPhong = new DateTime(NamTra, ThangTra, NgayTra);
                    ts = NgayTraPhong - NgayDatPhong;
                    if (ts.TotalDays < 0)
                    {
                        pTimKiem.Visible = false;
                        pDennie.Visible = true;
                        MessageBox.Show("Ngày Đặt Phòng không thể sau ngày Trả Phòng được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    if (NgayDatPhong.Day < DateTime.Now.Day)
                    {
                        pTimKiem.Visible = false;
                        pDennie.Visible = true;
                        MessageBox.Show("Bạn không thể đặt trong quá khứ được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
                                


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
    }
}
