using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace SendMail.Models
{
    internal class Mail : BackgroundService
    {
        Timer timer;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            timer = new Timer(SendMail,null,TimeSpan.Zero,TimeSpan.FromSeconds(5));
        }

        private void SendMail(object obj)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.office365.com");
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host


                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress("nihadsoltanov@hotmail.com");

                newMail.To.Add("abbasovsamir718@gmail.com");// declare the email subject

                newMail.Subject = "My First Email"; // use HTML for the email body

                newMail.IsBodyHtml = true; newMail.Body = "<h1> This is my first Templated Email in C# </h1>";

                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 587;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential("nihadsoltanov@hotmail.com", "webbb222444-444222");

                client.Send(newMail); // Send the constructed mail
                Console.WriteLine("Email Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error -" + ex);
            }
        }
    }
}
