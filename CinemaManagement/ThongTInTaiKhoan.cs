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
    public partial class ThongTInTaiKhoan : Form
    {
        public ThongTInTaiKhoan()
        {
            InitializeComponent();
        }

        private UserInfo currentUser; // Biến lưu thông tin người dùng

        public ThongTInTaiKhoan(UserInfo user)
        {
            InitializeComponent();
            currentUser = user; // Lưu lại đối tượng UserInfo
        }


        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height)); //Hien thi menu tai khoan de chon 3 tien ich.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongTInTaiKhoan_Load(object sender, EventArgs e)
        {
            // Load thong tin cua user vao cac textbox

            tbHovaTen.Text = currentUser.HoTen;
            tbUsername.Text = currentUser.Username;
            tbEmail.Text = currentUser.Email;
            tbSDT.Text = currentUser.SDT;
            tbNgaySinh.Text = currentUser.NgaySinh.ToString("dd/MM/yyyy");
            ID.Text = currentUser.IDUser;


        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuTaiKhoan_Opening(object sender, CancelEventArgs e)
        {

        }


        private void DangXuat_Click(object sender, EventArgs e)
        {
            var dangNhap = new PhanDangNhap();
            this.Hide();
            dangNhap.Show();

        }
        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);
            this.Hide();
            thongTinTaiKhoan.ShowDialog();


        }

        private void PhimHot_Click(object sender, EventArgs e)
        {
            PhimHot phimhot = new PhimHot(this, currentUser); // 'this' là TrangChuChinh
            this.Hide();
            phimhot.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);
            this.Hide();
            thongTinTaiKhoan.ShowDialog();

        }
    }
}
