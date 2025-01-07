using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q3
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Msg)
        {
            Console.WriteLine($"SMs to {Recipient}: {Msg}");
        }
    }
}
