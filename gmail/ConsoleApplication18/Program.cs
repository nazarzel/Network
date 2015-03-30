using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddr = Dns.GetHostAddresses("localhost")[1];
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("lalka", "123");//password not real
            try
            {
                MailMessage message = new MailMessage();
                message.To.Add("nazar.svyryd@gmail.com ");
                message.From = new MailAddress("lalka@gmail.com");
                message.Subject = "none";
                message.Body = "testing message";
                smtpClient.Send(message);
                Console.WriteLine("Message was sented\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
