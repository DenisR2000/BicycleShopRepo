using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BiicycleShopDb.Serises
{
    public class ServisMail
    {
        public static void SendMessage(string message, string mail)
        {
            try
            {
                MailMessage mail_message = new MailMessage();
                mail_message.IsBodyHtml = false;
                mail_message.Subject = "Покупка велосипеда!";
                mail_message.From = new MailAddress("admin@gmail.com", "Bicycles company");
                mail_message.To.Add(mail);
                mail_message.Body = message;
                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Credentials = new NetworkCredential("smitsonjimi@gmail.com", "tolik050103SAND");
                    client.Port = 587; //порт 587 (сервисы гугла) либо 465 (яндекс)
                    client.EnableSsl = true;
                    client.Send(mail_message);
                }
            }
            catch (Exception ex) { }
        }
    }
}
