using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class VeDaDat : Form
    {
        public VeDaDat()
        {
            InitializeComponent();
        }

        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height)); //Hien thi menu tai khoan de chon 3 tien ich.
        }
    }
}
