using System;
using System.Net;
using System.Net.Mail;

namespace ProductivityTools.SendEmailGmail
{
    public static class Gmail
    {
        public static void Send(string from, string password, string to, string subject, string body)
        {
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(from);
                message.To.Add(new MailAddress(to));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true; 

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.UseDefaultCredentials = false; 
                    smtp.Credentials = new NetworkCredential(from, password); 

                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Send(message);
                }
            }
        }
    }
}
