using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Admin : BaseUser
    {
        public string Type { get; set; }

        public Admin(string name, string email, string password, string type): base(name, email, password)
        {
            Type = type;
        }
    }
}
