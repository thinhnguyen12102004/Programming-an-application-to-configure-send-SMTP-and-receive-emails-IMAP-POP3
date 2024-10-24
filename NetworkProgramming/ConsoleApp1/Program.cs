using System;

using System.Net;
using System.Net.Mail;

namespace TestClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            MailAddress to = new MailAddress("minhpy2004@gmail.com");
            MailAddress from = new MailAddress("minhpy30@gmail.com");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing out email sending";
            email.Body = "hello";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("minhpy30@gmail.com", "udgt gplx yogd bsen");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(email);
                Console.WriteLine("Email sent successfully!");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}