using System;

namespace OCP_Applying
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("SOLID Principles: Applying OCP case");
                Console.WriteLine();

                Console.WriteLine("Creating the reporting objects...");
                Console.WriteLine();

                //create Reporting objects
                //Each time a new report type should be implemented, a new Reporting class should be added not breaking existing class, applying OCP
                PPFReporting ppfReporting = new PPFReporting();
                LTRReporting ltrReporting = new LTRReporting();
                MEMReporting memReporting = new MEMReporting();
                MSCReporting mscReporting = new MSCReporting();

                Console.WriteLine();

                //generate reports for all supported types
                ppfReporting.GenerateReport();
                ltrReporting.GenerateReport();
                memReporting.GenerateReport();
                mscReporting.GenerateReport();

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
