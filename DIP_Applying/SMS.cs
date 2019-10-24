using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Applying
{
    /// <summary>
    /// Class SMS implements IMessenger contract.
    /// </summary>
    class SMS : IMessenger
    {
        /// <summary> 
        /// SMS SendMessage instance method (IMessenger contract)
        /// </summary> 
        public void SendMessage()
        {
            Console.WriteLine("SMS message has been successfully sent");
        }
    }
}
