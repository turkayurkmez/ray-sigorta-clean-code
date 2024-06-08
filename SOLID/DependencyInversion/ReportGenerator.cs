using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ReportGenerator
    {
        private ISender sender;

        public ReportGenerator(ISender sender)
        {
            this.sender = sender;       
        }

        public void Send(string to)
        {
            
            sender.Send(to);
        }
    }
    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Mail gönderildi");
        } 
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine( "Whatsapp ile.....");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram ile.....");
        }
    }
}

