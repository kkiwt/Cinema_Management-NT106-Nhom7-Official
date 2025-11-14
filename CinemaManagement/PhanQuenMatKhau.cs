using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CinemaManagement
{

    public partial class PhanQuenMatKhau : Form
    {
        private string maXacNhan; // Biến lưu mã xác nhận
        public PhanQuenMatKhau()
        {
            InitializeComponent();
        }

        private void NutGuiMaDenEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailPhucHoi.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Sinh mã ngẫu nhiên
                Random rnd = new Random();
                maXacNhan = rnd.Next(100000, 999999).ToString();

                // Cấu hình SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("your_email@gmail.com", "your_app_password");
                smtp.EnableSsl = true;

                // Tạo email
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress("your_email@gmail.com");
                mail.To.Add(EmailPhucHoi.Text);
                mail.Subject = "Mã xác nhận khôi phục mật khẩu";
                mail.Body = $"Mã xác nhận của bạn là: {maXacNhan}";

                // Gửi mail
                smtp.Send(mail);

                TrangThaiGuiMail.Text = "Mã đã được gửi đến email!";
            }
            catch (Exception ex)
            {
                TrangThaiGuiMail.Text = "Gửi mail thất bại!";
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void NutXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaPhucHoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MaPhucHoi.Text == maXacNhan)
            {
                MessageBox.Show("Xác nhận thành công! Bạn có thể đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Hiển thị form đổi mật khẩu
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
