using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Violating
{
    /// <summary>
    /// Class Email
    /// </summary>
    class Email
    {
        /// <summary> 
        /// Email Constructor
        /// </summary> 
        public Email()
        {
            Console.WriteLine("New Email object created!");
        }

        /// <summary> 
        /// Email Send instance method
        /// </summary>
        public void SendEmail()
        {
            Console.WriteLine("Email message has been successfully sent");
        }
    }
}
