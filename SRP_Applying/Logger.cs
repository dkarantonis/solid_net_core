using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Applying
{
    /// <summary>
    /// Class Logger
    /// </summary>
    class Logger
    {
        /// <summary> 
        /// Logger Constructor
        /// </summary> 
        public Logger()
        {
            Console.WriteLine("New Logger object created!");
        }

        /// <summary>
        /// Logger WriterLog public method
        /// </summary>
        public void WriterLog()
        {
            Console.WriteLine("Logging data insertion completed sucessfully on {0}", DateTime.Now.ToLocalTime());
        }
    }
}
