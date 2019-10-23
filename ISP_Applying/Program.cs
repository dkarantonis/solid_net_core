using System;

namespace ISP_Applying
{
    class Program
    {
        static void Main()
        {
            try
            {

                Console.WriteLine("SOLID Principles: Applying ISP case");
                Console.WriteLine();

                Console.WriteLine("Creating the toys...");
                Console.WriteLine();

                //create a doll and a plane toys

                //create doll implementing IToy / ITalk contracts
                Doll dollToy = new Doll(50);
                //create plane implementing IToy / IFly contracts
                Plane planeToy = new Plane(250);

                Console.WriteLine();

                //buy doll that talks (does not implement unecessary Fly method)
                dollToy.Buy();
                dollToy.Talk();
                //dollToy.Fly(); not implemented method

                Console.WriteLine();

                //buy doll that flies (does not implement unecessary Talk method)
                planeToy.Buy();
                planeToy.Fly();
                //planeToy.Talk(); not implemented method

                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
