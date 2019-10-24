using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Applying
{
    /// <summary>
    /// Class MEMReporting implements IReporting contract and prints Preprinted report types
    /// </summary>
    class MEMReporting : IReporting
    {
        /// <summary> 
        /// MEMReporting Constructor
        /// </summary> 
        public MEMReporting()
        {
            Console.WriteLine("New MEMReporting object created!");
        }

        /// <summary> 
        /// MEMReporting GenerateReport instance method (IReporting contract)
        /// </summary> 
        public void GenerateReport()
        {
            Console.WriteLine("Report generated as a Memo");
        }
    }
}
