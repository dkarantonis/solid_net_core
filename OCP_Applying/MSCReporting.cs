using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Applying
{
    /// <summary>
    /// Class MSCReporting implements IReporting contract and prints Preprinted report types
    /// </summary>
    class MSCReporting : IReporting
    {
        /// <summary> 
        /// MSCReporting Constructor
        /// </summary> 
        public MSCReporting()
        {
            Console.WriteLine("New MSCReporting object created!");
        }

        /// <summary> 
        /// MSCReporting GenerateReport instance method (IReporting contract)
        /// </summary> 
        public void GenerateReport()
        {
            Console.WriteLine("Report generated as a Manuscript");
        }
    }
}
