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
    public partial class SoLuong : Form
    {
        public SoLuong()
        {
            InitializeComponent();
        }
        public void DonVi(string donvi)
        {
            label1.Text = donvi;
        }
        public void soluong(ref int num)
        {
           num = int.Parse(dmUDNumber.SelectedItem.ToString()); 
        }
        private void SoLuong_Load(object sender, EventArgs e)
        {
            dmUDNumber.Text = "0";
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

      

        private void pbXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
