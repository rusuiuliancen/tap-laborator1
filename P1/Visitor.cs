using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Visitor : BaseUser
    {
        public Visitor(string name, string email, string password, string profilImg):base(name, email, password)
        {
            IsActive = true;
            ProfileImage = profilImg;
        }
        public string ProfileImage { get; set; }

        public bool IsActive { get; private set; }

        public void SetActive(bool active)
        {
            IsActive = active;
        }
    }
}
