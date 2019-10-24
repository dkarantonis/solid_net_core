using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Applying
{
    /// <summary>
    /// Interface to be implemented by entities sending messages
    /// </summary>
    interface IMessenger
    {
        /// <summary> 
        /// SendMessage method
        /// </summary>
        public void SendMessage();
    }
}
