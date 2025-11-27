using BirdMessenger.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CinemaManagement
{
    public partial class DoiMatKhau : Form
    {
        private string EmailPhucHoi;
        public DoiMatKhau(string email)
        {
            InitializeComponent();
            EmailPhucHoi = email;
            if (txtMatKhauMoi != null) txtMatKhauMoi.PasswordChar = '*';
            if (txtXacNhanMK != null) txtXacNhanMK.PasswordChar = '*';
        }

        // hàm hash mk 
        public static string ToSha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async void NutXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMatKhau = txtXacNhanMK.Text;

            // --- 1. Kiểm tra tính hợp lệ dữ liệu ---
            if (string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu mới và xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate format mật khẩu
            if (!Regex.IsMatch(matKhauMoi, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash mật khẩu mới
            string matKhauMoiHash = ToSha256(matKhauMoi);



            // --- 2. Cập nhật mật khẩu ---
            try
            {
                // Gửi TCP lên server
                ClientTCP client = new ClientTCP();
                string message = $"RESET_PASSWORD|{EmailPhucHoi}|{matKhauMoiHash}";
                string response = (await client.SendMessageAsync(message)).Replace("\0", "").Trim();

                // Đóng Form này và chuyển về Form Đăng nhập

                if (response.Replace("\"", "") == "RESET_SUCCESS")
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new PhanDangNhap().Show();
                    return;
                }
                else if (response == "EMAIL_NOT_FOUND")
                {
                    MessageBox.Show("Email không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show($"Lỗi từ server: {response}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}. Vui lòng thử lại quy trình quên mật khẩu.", "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
