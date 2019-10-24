using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Violating
{
    /// <summary>
    /// Class SMS
    /// </summary>
    class SMS
    {
        /// <summary> 
        /// SMS Constructor
        /// </summary> 
        public SMS()
        {
            Console.WriteLine("New SMS object created!");
        }

        /// <summary> 
        /// SMS Send instance method
        /// </summary>
        public void SendSMS()
        {
            Console.WriteLine("SMS message has been successfully sent");
        }
    }
}
