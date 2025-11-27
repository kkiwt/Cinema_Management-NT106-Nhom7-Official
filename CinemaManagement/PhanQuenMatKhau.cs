using Newtonsoft.Json.Linq;
using Supabase;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supabase.Gotrue.Constants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CinemaManagement
{

    public partial class PhanQuenMatKhau : Form
    {
        private string maXacNhan; // Biến lưu mã xác nhận

        public PhanQuenMatKhau()
        {
            InitializeComponent();
        }

        private async void NutGuiMaDenEmail_Click(object sender, EventArgs e)
        {
            string Email = EmailPhucHoi.Text.Trim();

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo mã OTP 6 số
                Random rnd = new Random();
                maXacNhan = rnd.Next(100000, 999999).ToString();

                // Cấu hình SMTP (dùng Gmail)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("nguyenthaaihung111026@gmail.com", "m p k b s c v i i r o v h a d x"),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("nguyenthaaihung111026@gmail.com");
                mail.To.Add(Email);
                mail.Subject = "Mã xác nhận khôi phục mật khẩu";
                // Giữ lại nội dung email chi tiết hơn từ HEAD
                mail.Body = $"Mã xác nhận OTP của bạn là: {maXacNhan}\nMã có hiệu lực trong 5 phút.";

                // Gửi email
                smtp.Send(mail);

                string TrangThaiGuiMail = "📩 Mã OTP đã được gửi vào email!";
                MessageBox.Show(TrangThaiGuiMail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Giữ lại phần xử lý lỗi chi tiết của HEAD
                MessageBox.Show($"Lỗi khi yêu cầu đặt lại mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void NutXacNhan_Click(object sender, EventArgs e)
        {
            string nhapOTP = MaPhucHoi.Text.Trim();
            string Email = EmailPhucHoi.Text.Trim();

            if (string.IsNullOrWhiteSpace(MaPhucHoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (nhapOTP == maXacNhan)
                {
                    MessageBox.Show("Xác nhận thành công! Hãy đặt lại mật khẩu.",
                      "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 👉 Mở form đổi mật khẩu (Logic từ HEAD)
                    DoiMatKhau resetForm = new DoiMatKhau(Email);
                    this.Hide();
                    resetForm.Show();
                }
                else
                {
                    MessageBox.Show("Mã xác nhận không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xác nhận thất bại: {ex.Message}", "Lỗi Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PhanDangNhap dangNhap = new PhanDangNhap();
            dangNhap.Show();
            this.Hide();
        }
    }
}