using System;

namespace SRP_Applying
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SOLID Principles: Applying SRP case");
                Console.WriteLine();

                Console.WriteLine("Creating the data insertion objects...");
                Console.WriteLine();

                //create the data insertion objects
                DAL dal = new DAL();
                Logger logger = new Logger();
                Notification notification = new Notification();
                Console.WriteLine();

                //classes have one responsibility each, for any future change the relative responsibility class will be only affected, applying SRP
                //insert data to DB via DAL object
                dal.InsertData();
                //log the transaction
                logger.WriterLog();
                //notify the administrator of the system for the transaction via SMS
                notification.SendSMS();

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
