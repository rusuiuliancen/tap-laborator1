using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace P1
{
    internal static class Data
    {
        public static string Role1 = "R1";
        public static string Role2 = "R2";

        public static List<Admin> Admins = new List<Admin>();
        public static List<Visitor> Visitors = new List<Visitor>();

        public static void AddAdmin(Admin admin)
        {
            if (Admins.Contains(admin))
            {
                Console.WriteLine("Admin already exists.");
            }
            else
            {
                Admins.Add(admin);
                Console.WriteLine("Admin added.");
            }
        }

        public static void AddVisitor(Visitor visitor)
        {
            if (Visitors.Contains(visitor))
            {
                Console.WriteLine("Visitor already exsits.");
            }
            else
            {
                Visitors.Add(visitor);
                Console.WriteLine("Visitor added");
            }
        }

        public static void RemoveVisitor(Guid visitorId)
        {
            var visitor = Visitors.SingleOrDefault(x => x.Id == visitorId);

            if (visitor != null)
            {
                visitor.SetActive(false);
                Console.WriteLine("Visitor desactivated.");
            }
            else
            {
                Console.WriteLine("Visitor not found.");
            }
        }
    }
}
