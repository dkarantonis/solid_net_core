using System;
using System.Collections.Generic;

namespace LSP_Violating
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
        
                Console.WriteLine("SOLID Principles: Violating LSP case");
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

                    //the following code will cause build errors coming from the compiler, since there is not way to resolve the concrete type of each animal
                    //animal.Meow();
                    //animal.Bark();
                    //animal.Oink();
                    //the following code will cause type casting errors during runtime, since there is not way to resolve the concrete type of each animal
                    //((Cat)animal).Μeow();
                    //((Dog)animal).Bark();
                    //((Pig)animal).Oink();

                    //we need to explicitely check for the concrete animal type
                    if (animal.GetType() == typeof(Cat))
                    {
                        //downcast is needed to call Meow method specific to Cat class
                        ((Cat)animal).Μeow();
                    }
                    else if (animal.GetType() == typeof(Dog))
                    {
                        //downcast is needed to call Bark method specific to Dog class
                        ((Dog)animal).Bark();
                    }
                    else if (animal.GetType() == typeof(Pig))
                    {
                        //downcast is needed to call Oink method specific to Pig class
                        ((Pig)animal).Oink();
                    }
                    else
                    {
                        throw new NotSupportedException("Animal type not supported");
                    }

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
