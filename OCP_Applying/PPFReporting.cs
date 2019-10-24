using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Applying
{
    /// <summary>
    /// Class PPFReporting implements IReporting contract and prints Preprinted report types
    /// </summary>
    class PPFReporting : IReporting
    {
        /// <summary> 
        /// PPFReporting Constructor
        /// </summary> 
        public PPFReporting()
        {
            Console.WriteLine("New PPFReporting object created!");
        }

        /// <summary> 
        /// PPFReporting GenerateReport instance method (IReporting contract)
        /// </summary> 
        public void GenerateReport()
        {
            Console.WriteLine("Report generated as a Preprinted form");
        }
    }
}
