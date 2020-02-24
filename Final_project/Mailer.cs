using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Final_project
{
    class Mailer
    {
        MailAddress fromMailAddress = new MailAddress("testlera49@gmail.com", "Sushi inc.");

        public void SendMailUponOrderPlacement()
        {
            
            Console.WriteLine("Email: ");
            MailAddress toMailAddress = new MailAddress(Console.ReadLine());
        
            using MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress);
            using SmtpClient smtpClient = new SmtpClient();
            mailMessage.Subject = "Order status";

            mailMessage.Body = "Your order has been placed.";

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "StickyNotes12/");
            smtpClient.Send(mailMessage);
        }
    }   
}
