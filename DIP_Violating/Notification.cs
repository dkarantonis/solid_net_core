using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Violating
{
    /// <summary>
    /// Class Notification
    /// </summary>
    class Notification
    {
        //private data membesr (tight-coupled dependency)
        private Email _email;
        private SMS _sms;

        /// <summary> 
        /// Notification Constructor
        /// </summary>
        public Notification()
        {
            Console.WriteLine("New notification object created!");

            //creates tight-coupled dependency between Email and Notifications classes violating DIP
            Email = new Email();
            //creates tight-coupled dependency between SMS and Notifications classes violating DIP
            SMS = new SMS();
        }

        /// <summary> 
        /// Notification public properties
        /// </summary>
        internal Email Email { get => _email; set => _email = value; }
        internal SMS SMS { get => _sms; set => _sms = value; }

        /// <summary> 
        /// Notification SendNotificationViaEmail instance method
        /// </summary> 
        public void SendNotificationViaEmail()
        {
            //send notification via Email
            Email.SendEmail();
        }

        /// <summary> 
        /// Notification SendNotificationViaSMS instance method
        /// </summary> 
        public void SendNotificationViaSMS()
        {
            //send notification via SMS
            SMS.SendSMS();
        }
    }
}
