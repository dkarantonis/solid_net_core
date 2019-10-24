using System;

namespace SRP_Violating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SOLID Principles: Violating SRP case");
                Console.WriteLine();

                Console.WriteLine("Creating the DAL object...");
                Console.WriteLine();

                //create DAL object
                DAL dal = new DAL();
                Console.WriteLine();

                //insert data via DAL object
                //class DAL has many responsibilites, it is possible to change frequently in case even one of the responsibilities change, violating SRP
                dal.InsertData();

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
