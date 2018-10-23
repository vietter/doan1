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
    public partial class QuenMatKhau : Form
    {

        public string SDT
        {
            set
            {
                sdt = value;
            }
        }
        private string sdt;
        private string tenkh;
        public string TENKH
        {
            set
            {
                tenkh = value;
            }
        }
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private string options;
       
        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            lbCauHoi.Visible = false;
            lbCMND.Visible = false;
            lbTraLoi.Visible = false;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (txtCMND.Text == "")
            {
                lbCMND.Visible = true;
            }
            else
            {
                lbCMND.Visible = false;
            }
            if (txtTraLoi.Text == "")
            {
                lbTraLoi.Visible = true;
            }
            else
            {
                lbTraLoi.Visible = false;
            }
            if (cbbCauHoi.Text == "")
            {
                lbCauHoi.Visible = true;
            }
            else
            {
                lbCauHoi.Visible = false;
            }
            if (lbCauHoi.Visible == false && lbCMND.Visible == false && lbTraLoi.Visible == false)
            {

                DTO_KhachHang khachhang = new DTO_KhachHang();
                khachhang.SDT = sdt;
                khachhang.CauHoiBiMat = cbbCauHoi.Text;
                khachhang.CMND = txtCMND.Text;
                khachhang.TraLoi = txtTraLoi.Text;
                BO_QuenMatKhau quen = new BO_QuenMatKhau();
                DataSet result = quen.KiemTraBaoMat(khachhang);

                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Xác nhận thông tin thành công, xin hãy nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK);
                    this.Hide();
                    DoiMatKhau doi = new DoiMatKhau();
                    doi.KIEMTRA = "QUENMATKHAU";
                    doi.SDT = sdt;
                    doi.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin sai, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }






        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void txtCMND_Click(object sender, EventArgs e)
        {
            txtCMND.ResetText();
            txtCMND.Focus();
        }
    }

}