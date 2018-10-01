using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class pPhong : UserControl
    {
        public pPhong()
        {
            InitializeComponent();
        }

        private void pPhong_Load(object sender, EventArgs e)
        {
            
        }
        public void TenPhong(string TenPhong, string MaPhong)
        {
            label.Text = TenPhong;
            picture.Name = MaPhong;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            TuyChonPhong chon = new TuyChonPhong();
            chon.MAPHONG = picture.Name;
            chon.ShowDialog();
            
        }
    }
}
