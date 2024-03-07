using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    internal interface INotification
    {
        void Send(string content, string dest);
    }
}
