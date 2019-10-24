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

                //create Notification to send email message
                Notification notificationEmail = new Notification(new Email());
                notificationEmail.SendNotification();

                //create Notification to send SMS message
                Notification notificationSMS = new Notification(new SMS());
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
