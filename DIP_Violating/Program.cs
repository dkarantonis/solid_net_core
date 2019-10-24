using System;

namespace DIP_Violating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SOLID Principles: Violating DIP case");
                Console.WriteLine();

                Console.WriteLine("Creating the notification object...");
                Console.WriteLine();

                //create Notification to send email / sms message
                Notification notification = new Notification();
                notification.SendNotificationViaEmail();
                notification.SendNotificationViaSMS();

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
