using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.BS_layer;
namespace QL_KhachSan
{
    public partial class FreeRoom : UserControl
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

        private string tenchinhanh;
        public string TENCHINHANH
        {
            set
            {
                tenchinhanh = value;
            }
        }

        private string maphongcu;
        public string MAPHONGCU
        {
            set
            {
                maphongcu = value;
            }
        }
        private string sdt;
        public string SDT
        {
            set
            {
                 sdt =value;
            }
        }
        private string tenphong;
        public string TENPHONG
        {
            set
            {
               tenphong=  value ;
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
        private string mahd;
        public string MAHD
        {
            set
            {
                mahd = value ;
            }
        }

        public FreeRoom()
        {
            InitializeComponent();
        }
        public void SetTenPhong(string tenphong)
        {
            label1.Text = tenphong;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Bạn có muốn đổi sang phòng " + tenphong + " chứ ?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                BO_DoiPhong giaiphongphong = new BO_DoiPhong();

                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.MaChiNhanh = machinhanh;
                hoadon.MaPhong = maphongcu;
                hoadon.SoDienThoai = "Free";
                if( giaiphongphong.DoiNguoiSuDung(hoadon) != -1)
                {
                    BO_DoiPhong doiphong = new BO_DoiPhong();
                    DTO_HoaDon hoadon1 = new DTO_HoaDon();
                    hoadon1.MaChiNhanh = machinhanh;
                    hoadon1.MaPhong = maphong;
                    hoadon1.SoDienThoai = sdt;
                    if(doiphong.DoiNguoiSuDung(hoadon1) != -1)
                    {
                        BO_DoiPhong doihoadon = new BO_DoiPhong();
                        DTO_HoaDon hoadon2 = new DTO_HoaDon();
                        hoadon2.MaPhong = maphong;
                        hoadon2.MaHD = mahd;
                        if(doihoadon.DoiHoaDon(hoadon2) != -1)
                        {
                            if(manv != null)
                            {
                                this.ParentForm.Hide();
                                GiaoDienQuanLi quanli = new GiaoDienQuanLi();
                                quanli.MANV = manv;
                                quanli.TENNV = tennv;
                                quanli.TENCHINHANH = tenchinhanh;
                                quanli.MACHINHANH = machinhanh;
                                quanli.ShowDialog();
                                this.ParentForm.Close();
                            }
                            else
                            {
                                this.ParentForm.Hide();
                                GiaoDienKhachHang khachhang = new GiaoDienKhachHang();
                                khachhang.SDT = sdt;
                                khachhang.ShowDialog();
                                this.ParentForm.Close();
                            }
                           

                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi đổi hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi đổi phòng mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi đổi phòng cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
           

        }
    }
}
