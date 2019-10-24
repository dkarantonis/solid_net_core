using System;

namespace DIP_Applying
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SOLID Principles: Applying DIP case");
                Console.WriteLine();

                Console.WriteLine("Creating the notification objects...");
                Console.WriteLine();

                //create Notifications objects
                Notification notificationEmail = new Notification(new Email());
                Notification notificationSMS = new Notification(new SMS());
                Console.WriteLine();

                //send email / sms messages
                notificationEmail.SendNotification();
                notificationSMS.SendNotification();

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
