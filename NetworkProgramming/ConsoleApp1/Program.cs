using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace TestClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Khởi tạo email
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("test", "minhpy30@gmail.com"));
            email.To.Add(new MailboxAddress("Noah", "minhpy2004@gmail.com"));
            email.Subject = "Now I’m even sending emails from C#!";
            // Nội dung email
            var bodyBuilder = new BodyBuilder
            {
                TextBody = "Check out my C# SMTP email sent with MailKit and Mailtrap’s SMTP credentials"
            };

            // Đính kèm hình ảnh
            var imagePath = "C:\\Users\\DELL\\Videos\\BlueStacks-Pie64\\New folder\\123.jpg"; // Thay đổi đường dẫn đến hình ảnh của bạn
            bodyBuilder.Attachments.Add(imagePath);

            // Đính kèm tệp
            var filePath = "D:\\BAI TAP VE NHA.pdf"; // Thay đổi đường dẫn đến tệp của bạn
            bodyBuilder.Attachments.Add(filePath);
            email.Body = bodyBuilder.ToMessageBody();
            // Sử dụng SmtpClient để gửi email
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                // Xác thực nếu cần thiết
                smtp.Authenticate("minhpy30@gmail.com", "xbyg qdxb xpvf ryzb");

                smtp.Send(email);
                smtp.Disconnect(true);
                Console.WriteLine("Done!");
            }
        }
    }
}
