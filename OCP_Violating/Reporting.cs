using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Violating
{
    /// <summary>
    /// Class Reporting
    /// </summary>
    partial class Reporting
    {
        /// <summary> 
        /// Reporting Constructor
        /// </summary> 
        public Reporting()
        {
            Console.WriteLine("New Reporting object created!");
        }

        /// <summary>
        /// Reporting GenerateReport public method
        /// </summary>
        public void GenerateReport(ReportType reportType)
        {
            //Generate report base on report type
            //Each time a new report type should be implemented, the Reporting class should change, violating OCP
            switch(reportType)
            {
                case ReportType.PPF:
                    Console.WriteLine("Report generated as a Preprinted form");
                    break;
                case ReportType.LTR:
                    Console.WriteLine("Report generated as a Letter");
                    break;
                case ReportType.MEM:
                    Console.WriteLine("Report generated as a Memo");
                    break;
                case ReportType.MSC:
                    Console.WriteLine("Report generated as a Manuscript");
                    break;
                default:
                    throw new NotSupportedException("Report could not be genrated (Report type is not supported)");
            }
        }
    }
}
