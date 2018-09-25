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
            txtGioTraPhong.ResetText();
            dtpNgayDat.ResetText();
            dtpNgayTra.ResetText();
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
            }
            if (lbKetQua.Visible == false && lbNoiO.Visible == false)
            {
                pDennie.Visible = false;
                pTimKiem.Visible = true;
            }
            else
            {
                pDennie.Visible = true;
                pTimKiem.Visible = false;
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
                    if (GioDatPhong >= 24 || PhutTraPhong >= 60 || GioTraPhong >=24 || PhutTraPhong >= 60)
                    {
                        pTimKiem.Visible = false;
                        pDennie.Visible = true;
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
                            pTimKiem.Visible = false;
                            pDennie.Visible = true;
                            MessageBox.Show("Ngày Đặt Phòng không thể sau ngày Trả Phòng được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            load();
                        }
                        else
                        {
                            if (NgayDatPhong.Day < DateTime.Now.Day)
                            {
                                pTimKiem.Visible = false;
                                pDennie.Visible = true;
                                MessageBox.Show("Bạn không thể đặt trong quá khứ được, vui lòng hãy chọn lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                load();

                            }
                            else
                            {
                                BO_DatPhong datphong = new BO_DatPhong();

                            }
                        }


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
    }
}
