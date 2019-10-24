using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Applying
{
    /// <summary>
    /// Class Notification
    /// </summary>
    class Notification
    {
        //private interface data member (loose-coupled dependency)
        private IMessenger _iMessenger;

        /// <summary> 
        /// Notification Constructor
        /// </summary>
        public Notification(IMessenger iMessenger)
        {
            //creates loose-coupled dependency applying DIP (dependency injection via constructor)
            _iMessenger = iMessenger;
        }

        /// <summary> 
        /// Notification SendNotification instance method
        /// </summary> 
        public void SendNotification()
        {
            //send notification via Email / SMS depending on object type injected via constructor
            _iMessenger.SendMessage();
        }
    }
}
