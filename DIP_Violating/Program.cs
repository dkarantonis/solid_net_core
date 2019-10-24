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

                //create Notification object
                Notification notification = new Notification();
                Console.WriteLine();

                //send email / sms message
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
