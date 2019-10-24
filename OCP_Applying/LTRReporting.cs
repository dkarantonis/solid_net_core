using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Applying
{
    /// <summary>
    /// Class LTRReporting implements IReporting contract and prints Preprinted report types
    /// </summary>
    class LTRReporting : IReporting
    {
        /// <summary> 
        /// LTRReporting Constructor
        /// </summary> 
        public LTRReporting()
        {
            Console.WriteLine("New LTRReporting object created!");
        }

        /// <summary> 
        /// LTRReporting GenerateReport instance method (IReporting contract)
        /// </summary> 
        public void GenerateReport()
        {
            Console.WriteLine("Report generated as a Letter");
        }
    }
}
