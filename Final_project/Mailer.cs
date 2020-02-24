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
        MailAddress toMailAddress = new MailAddress(Console.ReadLine());

        //public event EventHandler OrderPlaced;

        public void SendMailUponOrderPlacement()
        {
            using MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress);
            using SmtpClient smtpClient = new SmtpClient();
            mailMessage.Subject = "Order info";

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
