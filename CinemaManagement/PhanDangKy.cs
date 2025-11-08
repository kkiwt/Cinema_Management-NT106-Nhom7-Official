// ===========================
// File: PhanDangKy.cs
// ===========================
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
namespace CinemaManagement
{
    public partial class PhanDangKy : Form
    {
        public PhanDangKy()
        {
            InitializeComponent();
        }

        public static string ToSha256(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async void NutDangKy_Click(object sender, EventArgs e)
        {
            string Name = HoTen.Text.Trim();
            string TenDangNhap = Username.Text.Trim();
            string SDT = SoDienThoai.Text.Trim();
            string E_mail = Email.Text.Trim();
            string MatKhauGoc = MatKhau.Text;
            string XacNhanMK = XacNhanMatKhau.Text;
            string Sex = GioiTinh.SelectedItem?.ToString();
            DateTime NgaySinh = NgayThangNamSinh.Value.Date;

            // --- Validation ---
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(TenDangNhap) ||
                string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(E_mail) ||
                string.IsNullOrEmpty(MatKhauGoc) || string.IsNullOrEmpty(XacNhanMK) ||
                string.IsNullOrEmpty(Sex))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(Name, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                MessageBox.Show("Họ tên không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(SDT, @"^(0\d{9}|\+84\d{9})$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(E_mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(MatKhauGoc, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }

            if (MatKhauGoc != XacNhanMK)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
                return;
            }

            if (NgaySinh > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.");
                return;
            }

            string MatKhauDaHash = ToSha256(MatKhauGoc);

            try
            {
                ClientTCP client = new ClientTCP();
                string message = $"REGISTER|{Name}|{TenDangNhap}|{MatKhauDaHash}|{E_mail}|{Sex}|{NgaySinh:yyyy-MM-dd}|{SDT}";
                string response = await client.SendMessageAsync(message);
                string cleanresponse = response.Replace("[", "")
                                            .Replace("]", "")
                                            .Replace("\"", "")
                                            .Trim(); 
                // Message bi dong trong dinh dang JSON nen loi, kieu nhu [REGISTER_SUCCESS]


                this.Invoke((MethodInvoker)delegate
                {
                    if (cleanresponse == "REGISTER_SUCCESS")
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thành công");

                        UserInfo newUser = new UserInfo
                        {
                            HoTen = Name,
                            Username = TenDangNhap,
                            SDT = SDT,
                            Email = E_mail,
                            GioiTinh = Sex,
                            NgaySinh = NgaySinh
                        };

                        var dashboard = new GiaoDienSauKhiDaDangNhapHoacDangKyXong(newUser);
                        this.Hide();
                        dashboard.Show();
                    }
                    else if (cleanresponse == "USERNAME_EXISTS")
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi");
                    }
                    else if (cleanresponse == "EMAIL_EXISTS")
                    {
                        MessageBox.Show("Email đã được đăng ký.", "Lỗi");
                    }
                    else
                    {
                        MessageBox.Show($"Raw response: [{response}]\nLength: {response.Length}", "DEBUG");

                        string asciiCodes = "";
                        foreach (char c in response)
                        {
                            asciiCodes += ((int)c) + " ";
                        }

                        MessageBox.Show($"ASCII Codes:\n{asciiCodes}", "DEBUG ASCII");


                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show($"Lỗi gửi dữ liệu đến server: {ex.Message}", "Lỗi");
                }));
            }
        }

        private void NutDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangNhap dangNhap = new PhanDangNhap();
            this.Hide();
            dangNhap.Show();
            dangNhap.FormClosed += (s, args) => this.Close();
        }
    }
}
