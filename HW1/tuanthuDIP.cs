using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class tuanthuDIP
    {
        public interface IMessageSender
        {
            void Send(string recipient, string message);
        }
        public class EmailSender : IMessageSender
        {
            public void Send(string recipient, string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[EMAIL] Gửi tới {recipient}: {message}");
                Console.ResetColor();
            }
        }
        public class SMSSender : IMessageSender
        {
            public void Send(string recipient, string message)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[SMS] Gửi tới {recipient}: {message}");
                Console.ResetColor();
            }
        }
        //High-level Module (Phụ thuộc vào Abstraction)
        public class NotificationService
        {
            private readonly IMessageSender _sender;
            //tuân thủ DIP qua Dependency Injection (Constructor Injection)
            public NotificationService(IMessageSender sender)
            {
                this._sender = sender;
            }
            public void NotifyUser(string user, string msg)
            {
                this._sender.Send(user, msg);
            }
        }
    }
}
