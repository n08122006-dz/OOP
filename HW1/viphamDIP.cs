using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class viphamDIP
    {
        // Low-level Module (Concrete Detail)
        public class EmailSender
        {
            public void Send(string recipient, string message)
            {
                Console.WriteLine($"Gửi Email tới {recipient}: {message}");
            }
        }
        // High-level Module (Business Logic)
        public class NotificationService
        {
            private EmailSender _sender;
            public NotificationService()
            {
                this._sender = new EmailSender();
            }
            public void NotifyUser(string user, string msg)
            {
                Console.WriteLine($"[{user}] Đang xử lý thông báo...");
                this._sender.Send(user, msg);
            }
        }
    }
}