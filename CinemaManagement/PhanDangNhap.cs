using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CinemaManagement
{
    public partial class PhanDangNhap : Form
    {
        public PhanDangNhap()
        {
            InitializeComponent();
        }

        // 🔒 Mã hóa SHA256
        public static string ToSha256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        // 🟢 Xử lý khi nhấn nút "Đăng nhập"
        private async void button1_Click(object sender, EventArgs e)
        {
            string username = TenDangNhap.Text.Trim();
            string password = MatKhau.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔐 Băm mật khẩu trước khi gửi
            string passwordHash = ToSha256(password);
            string message = $"LOGIN|{username}|{passwordHash}";

            try
            {
                NutDangNhap.Enabled = false;
                Cursor = Cursors.WaitCursor;

                ClientTCP client = new ClientTCP();
                string response = await client.SendMessageAsync(message);

                if (string.IsNullOrWhiteSpace(response))
                {
                    MessageBox.Show("Không nhận được phản hồi từ máy chủ.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🧩 Kiểm tra phản hồi từ server
                if (response.StartsWith("[LOGIN_SUCCESS]"))
                {
                    string[] parts = response.Split('|');

                    // Chuẩn dạng: [LOGIN_SUCCESS]|id|hoten|username|email|sdt|gioitinh|ngaysinh
                    if (parts.Length < 8)
                    {
                        MessageBox.Show("Phản hồi từ máy chủ không hợp lệ (thiếu dữ liệu).",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 🧠 Tạo đối tượng UserInfo
                    UserInfo currentUser = new UserInfo
                    {
                        IDUser = parts[1],
                        HoTen = parts[2],
                        Username = parts[3],
                        Email = parts[4],
                        SDT = parts[5],
                        GioiTinh = parts[6],
                        NgaySinh = DateTime.TryParse(parts[7], out DateTime ns) ? ns : DateTime.MinValue
                    };

                    MessageBox.Show($"Đăng nhập thành công!\nChào mừng {currentUser.HoTen}.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔄 Chuyển sang giao diện chính
                    var dashboard = new TrangChuChinh(currentUser);
                    this.Hide();
                    dashboard.Show();
                    dashboard.FormClosed += (s, args) => this.Close();
                }
                else if (response.StartsWith("LOGIN_FAILED") || response.StartsWith("[LOGIN_FAILED]"))
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.",
                        "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response.StartsWith("ERROR_LOGIN"))
                {
                    MessageBox.Show($"Lỗi xử lý từ máy chủ:\n{response}",
                        "Lỗi máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Phản hồi không xác định từ máy chủ:\n{response}",
                        "Không rõ phản hồi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến máy chủ.\nChi tiết: {ex.Message}",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NutDangNhap.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dangKy = new PhanDangKy();
            this.Hide();
            dangKy.Show();
            dangKy.FormClosed += (s, args) => this.Close();
        }

        private void PhanDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void LabelQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var quenmatkhau = new PhanQuenMatKhau();
            this.Hide();
            quenmatkhau.ShowDialog();


        }
    }
}
