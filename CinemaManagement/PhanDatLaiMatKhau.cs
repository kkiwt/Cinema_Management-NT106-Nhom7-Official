using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanDatLaiMatKhau : Form
    {
        public PhanDatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void NutXacNhan_Click(object sender, EventArgs e)
        {
            // Giả sử bạn có TextBox cho nhập lại mật khẩu mới tên là NhapLaiMatKhauMoiTextBox
            if (string.IsNullOrWhiteSpace(MatKhau.Text) ||
                string.IsNullOrWhiteSpace(MatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(NhapLaiMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(MatKhauMoi.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, chữ hoa, chữ thường, số và ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mật khẩu mới trùng nhau
            if (MatKhauMoi.Text != NhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

    }
}
