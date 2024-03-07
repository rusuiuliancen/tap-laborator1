using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    internal class SmsNotification: INotification
    {
        public void Send(string content, string dest)
        {
            Console.WriteLine("sms sending to: " + dest);
        }
    }
}
