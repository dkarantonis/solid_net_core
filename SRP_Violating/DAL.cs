using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Violating
{
    /// <summary>
    /// Class DAL (Data Access Layer)
    /// </summary>
    class DAL
    {
        /// <summary> 
        /// DAL Constructor
        /// </summary> 
        public DAL()
        {
            Console.WriteLine("New DAL object created!");
        }

        /// <summary>
        /// DAL InsertData public method
        /// </summary>
        public void InsertData()
        {
            Console.WriteLine("Open database connection");
            Console.WriteLine("Create and execute database query to insert data to the database");
            Console.WriteLine("Close database connection");

            Console.WriteLine("Logging data insertion completed sucessfully on {0}", DateTime.Now.ToLocalTime());

            Console.WriteLine("Send notification for the data insertion to the administrator of the system via SMS");
        }
    }
}
