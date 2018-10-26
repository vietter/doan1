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
    public partial class BaoCaoDaLat : Form
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

        public BaoCaoDaLat()
        {
            InitializeComponent();
        }

        private void BaoCaoDaLat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCaoDL.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.BaoCaoDL.HoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void pbTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienQuanLi giaoDienQuanLi = new GiaoDienQuanLi();
            giaoDienQuanLi.MANV = manv;
            giaoDienQuanLi.TENCHINHANH = tenchinhanh;
            giaoDienQuanLi.MACHINHANH = machinhanh;
            giaoDienQuanLi.TENNV = tennv;
            giaoDienQuanLi.ShowDialog();
            this.Close();
        }
    }
}
