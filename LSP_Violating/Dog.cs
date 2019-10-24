using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Class Dog implements IAnimal contract
    /// </summary>
    class Dog : IAnimal
    {
        /// <summary>
        /// Dog Name read-only instance property
        /// </summary>
        public string Name { get; }

        /// <summary> 
        /// Dog Constructor
        /// </summary> 
        /// <param name="name">Dog name</param> 
        public Dog(string name)
        {
            Name = name;
            Console.WriteLine("New dog named {0} was borned!", Name);
        }

        /// <summary> 
        /// Dog Eat method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine("{0} eats beef meat...", Name);
        }

        /// <summary> 
        /// Dog Bark method
        /// </summary> 
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
