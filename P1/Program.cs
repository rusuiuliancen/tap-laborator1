namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var admin1 = new Admin("Iulian Rusu", "iulian.rusu@centric.eu","password1", Data.Role1);
            var admin2 = new Admin("Popescu Andrei", "popescu.andrei@centric.eu","password2", Data.Role2);

            Data.AddAdmin(admin1);
            Data.AddAdmin(admin2);

            Console.WriteLine("Total admins count: " + Data.Admins.Count);
            Console.WriteLine("R1 admins count: " + Data.Admins.Count(x => x.Type == Data.Role1));
            Console.WriteLine("R2 admins count: " + Data.Admins.Count(x => x.Type == Data.Role2));

            var visitor1 = new Visitor("Dan Danutz", "ddanutz@gmail.com", "", "img1");
            var visitor2 = new Visitor("Ion Ionutz", "ioni@gmail.com", "", "img2");
            var visitor3 = new Visitor("Iulian Pop", "iulianp@gmail.com", "", "img2");

            Data.AddVisitor(visitor1);
            Data.AddVisitor(visitor2);
            Data.AddVisitor(visitor3);
            Console.WriteLine("Total visitors count: " + Data.Visitors.Count(x=>x.IsActive));

            Data.RemoveVisitor(visitor1.Id);
            Data.RemoveVisitor(Guid.NewGuid());

            Console.WriteLine("Total visitors count: " + Data.Visitors.Count(x => x.IsActive));
        }
    }
}
