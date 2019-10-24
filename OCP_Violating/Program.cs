using System;

namespace OCP_Violating
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("SOLID Principles: Violating OCP case");
                Console.WriteLine();

                Console.WriteLine("Creating the reporting object...");
                Console.WriteLine();

                //create Reporting object
                Reporting reporting = new Reporting();
                Console.WriteLine();

                //generate reports for all supported types
                reporting.GenerateReport(Reporting.ReportType.PPF);
                reporting.GenerateReport(Reporting.ReportType.LTR);
                reporting.GenerateReport(Reporting.ReportType.MEM);
                reporting.GenerateReport(Reporting.ReportType.MSC);

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
