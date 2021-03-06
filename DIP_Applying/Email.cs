﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Applying
{
    /// <summary>
    /// Class Email implements IMessenger contract
    /// </summary>
    class Email : IMessenger
    {
        /// <summary> 
        /// Email Constructor
        /// </summary> 
        public Email()
        {
            Console.WriteLine("New Email object created!");
        }

        /// <summary> 
        /// Email SendMessage instance method (IMessenger contract)
        /// </summary> 
        public void SendMessage()
        {
            Console.WriteLine("Email message has been successfully sent");
        }
    }
}
