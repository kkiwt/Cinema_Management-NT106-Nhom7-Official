using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ServerAndService
{
    public class EmailService
    {
        public async Task SendOtp(string email, string otp)
        {
            var senderEmail = "nkiet0651@gmail.com";
            var appPassword = "obpjapgduwetufgp";  // 16 ký tự - KHÔNG khoảng trắng

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, appPassword)
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(email);
            mail.Subject = "Mã OTP khôi phục mật khẩu";
            mail.Body = $"Mã OTP của bạn là: {otp} (hiệu lực 5 phút).";

            await smtp.SendMailAsync(mail);
        }
    }
}
