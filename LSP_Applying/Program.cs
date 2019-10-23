using System;
using System.Collections.Generic;

namespace LSP_Applying
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SOLID Principles: Applying LSP case");
                Console.WriteLine();

                Console.WriteLine("Creating the animals...");
                Console.WriteLine();

                //create a list of IAnimal
                List<IAnimal> animals = new List<IAnimal>();
                //add one of each animal implementing IAnimal contract providing a name via constructor parameter
                animals.Add(new Cat("Garfield"));
                animals.Add(new Dog("Pluto"));
                animals.Add(new Pig("Porky"));

                Console.WriteLine();

                //iterate through animals list
                foreach (IAnimal animal in animals)
                {
                    //get the name of each animal (IAnimal contract)
                    Console.WriteLine(String.Format("Hi {0}", animal.Name));

                    //each one of the animals have to eat (IAnimal contract)
                    animal.Eat();
                    //each one of the animals could make noise to eat (IAnimal contract)
                    //note that there is no longer need to check explicitely for each animal's concrete type,
                    //the compiler does this for us via polymorphism Object Oriented concept
                    animal.MakeNoise();

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
