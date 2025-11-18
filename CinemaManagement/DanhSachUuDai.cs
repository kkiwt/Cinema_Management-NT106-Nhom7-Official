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
    public partial class DanhSachUuDai : Form
    {
        public DanhSachUuDai()
        {
            InitializeComponent();
        }

        private void DanhSachUuDai_Load(object sender, EventArgs e)
        {

        }

        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height)); //Hien thi menu tai khoan de chon 3 tien ich.
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongtintaikhoan = new ThongTInTaiKhoan();
            thongtintaikhoan.ShowDialog();
            this.Close();
        }

        private void VeDaDat_Click(object sender, EventArgs e)
        {

        }
    }
}
