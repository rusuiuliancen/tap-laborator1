using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    internal class EmailNotification:INotification
    {
        public void Send(string content, string dest)
        {
            Console.WriteLine("email sending to: "+ dest);
        }
    }
}
