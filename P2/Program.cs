namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            INotification smsNotification = new SmsNotification();
            smsNotification.Send("content", "0788888");

            INotification emaiNotification = new EmailNotification();
            emaiNotification.Send("content", "iulian@centric.eu");

            INotification mailNotification = new MailNotification();
            mailNotification.Send("content", "Str Ploii nr 2");
        }
    }
}
