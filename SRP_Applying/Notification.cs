using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Applying
{
    /// <summary>
    /// Class Notification
    /// </summary>
    class Notification
    {
        /// <summary> 
        /// Notification Constructor
        /// </summary> 
        public Notification()
        {
            Console.WriteLine("New Notification object created!");
        }

        /// <summary>
        /// Notification SendSMS public method
        /// </summary>
        public void SendSMS()
        {
            Console.WriteLine("Send notification for the data insertion to the administrator of the system via SMS");
        }
    }
}
