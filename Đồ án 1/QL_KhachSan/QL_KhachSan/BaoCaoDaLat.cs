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
    }
}
