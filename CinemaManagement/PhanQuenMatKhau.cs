using System;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanQuenMatKhau : Form
    {
        public PhanQuenMatKhau()
        {
            InitializeComponent();
        }

        private async void NutGuiMaDenEmail_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string email = EmailPhucHoi.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClientTCP client = new ClientTCP();
            string message = $"FORGOT_REQUEST|{email}";
            string response = await client.SendMessageAsync(message);
            Cursor = Cursors.Default;
            if (response == "OTP_SENT")
            {
                TrangThaiGuiMail.Text = "📩 OTP đã được gửi vào email!";
                MessageBox.Show("Mã OTP đã được gửi! Vui lòng kiểm tra email.");
            }
            else if (response == "EMAIL_NOT_FOUND")
            {
                TrangThaiGuiMail.Text = "❌ Email không tồn tại!";
                MessageBox.Show("Email không có trong hệ thống.", "Lỗi");
            }
            else
            {
                TrangThaiGuiMail.Text = "❌ Lỗi server!";
                MessageBox.Show("Server trả về lỗi: " + response, "Lỗi");
            }
        }


        private async void NutXacNhan_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string otp = MaPhucHoi.Text.Trim();
            string email = EmailPhucHoi.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(otp))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mã OTP!", "Thông báo");
                Cursor = Cursors.Default;
                return;
            }

            // Gửi yêu cầu kiểm tra OTP đến server
            ClientTCP client = new ClientTCP();
            string request = $"CHECK_OTP|{email}|{otp}";
            string response = await client.SendMessageAsync(request);

            Cursor = Cursors.Default;

            if (response == "OTP_VALID")
            {
                // Mở form đặt lại mật khẩu
                PhanDatLaiMatKhau form = new PhanDatLaiMatKhau(email, otp);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("OTP không đúng hoặc đã hết hạn!", "Lỗi");
            }
        }




        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PhanDangNhap().Show();


        }
    }
}
