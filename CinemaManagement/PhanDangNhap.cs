// ===========================
// File: PhanDangNhap.cs
// ===========================
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanDangNhap : Form
    {
        public PhanDangNhap()
        {
            InitializeComponent();
        }

        public static string ToSha256(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = TenDangNhap.Text.Trim();
            string password = MatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.");
                return;
            }

            string passwordHash = ToSha256(password);

            try
            {
                ClientTCP client = new ClientTCP();
                string message = $"LOGIN|{username}|{passwordHash}";
                string response = await client.SendMessageAsync(message);

                if (response.StartsWith("[LOGIN_SUCCESS]"))
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    string[] parts = response.Split('|');
                    UserInfo CurrentUser = new UserInfo
                    {
                        HoTen = parts.Length > 1 ? parts[1] : "",
                        Username = parts.Length > 2 ? parts[2] : "",
                        Email = parts.Length > 3 ? parts[3] : "",
                        SDT = parts.Length > 4 ? parts[4] : "",
                        GioiTinh = parts.Length > 5 ? parts[5] : "",
                        NgaySinh = parts.Length > 6 && DateTime.TryParse(parts[6], out DateTime ns) ? ns : DateTime.MinValue
                    };

                    GiaoDienSauKhiDaDangNhapHoacDangKyXong dashboard = new GiaoDienSauKhiDaDangNhapHoacDangKyXong(CurrentUser);
                    this.Hide();
                    dashboard.Show();
                    dashboard.FormClosed += (s, args) => this.Close();
                }
                else if (response == "LOGIN_FAILED")
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                }
                else
                {
                    MessageBox.Show($"Lỗi từ server: {response}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối đến server: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangKy dangKy = new PhanDangKy();
            this.Hide();
            dangKy.Show();
            dangKy.FormClosed += (s, args) => this.Close();
        }
    }
}
