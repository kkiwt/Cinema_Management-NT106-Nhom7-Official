using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanDatLaiMatKhau : Form
    {
        private string email;
        private string otp;

        public PhanDatLaiMatKhau(string emailPhucHoi, string maOtp)
        {
            InitializeComponent();
            email = emailPhucHoi;
            otp = maOtp;
        }

        private async void NutXacNhan_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string pass1 = MatKhauMoi.Text;
            string pass2 = MatKhau.Text;

            if (string.IsNullOrWhiteSpace(pass1) || string.IsNullOrWhiteSpace(pass2))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("2 mật khẩu không khớp!", "Lỗi");
                return;
            }

            if (!Regex.IsMatch(pass1, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                MessageBox.Show("Mật khẩu phải ít nhất 8 ký tự, có chữ hoa, thường, số và ký tự đặc biệt.");
                return;
            }

            string passHash = PhanDangNhap.ToSha256(pass1);

            ClientTCP client = new ClientTCP();
            string request = $"FORGOT_CONFIRM|{email}|{otp}|{passHash}";

            string response = await client.SendMessageAsync(request);
            Cursor = Cursors.Default;

            if (response == "RESET_SUCCESS")
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công");
                this.Hide();
                new PhanDangNhap().Show();
            }
            else if (response == "OTP_INVALID")
            {
                MessageBox.Show("OTP không đúng hoặc đã hết hạn!", "Lỗi");
            }
            else
            {
                MessageBox.Show("Lỗi server: " + response);
            }
        }
    }
}
