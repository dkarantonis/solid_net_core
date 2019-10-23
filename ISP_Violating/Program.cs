using System;
using System.Collections.Generic;

namespace ISP_Violating
{
    class Program
    {
        static void Main()
        {
            try
            {

                Console.WriteLine("SOLID Principles: Violating ISP case");
                Console.WriteLine();

                Console.WriteLine("Creating the toys...");
                Console.WriteLine();

                //create a list of IToy
                List<IToy> toys = new List<IToy>();
                //add one of each toy implementing IToy contract
                toys.Add(new Doll(50));
                toys.Add(new Plane(250));

                Console.WriteLine();

                //iterate through toys list
                foreach (IToy toy in toys)
                {
                    //we have to buy one of the toys (IToy contract)
                    toy.Buy();

                    //we then can play the toy by flying or by talking
                    //note that not all toys support all methods and this is where the ISP violation comes in
                    toy.Fly();
                    toy.Talk();

                    Console.WriteLine();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
