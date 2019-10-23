using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Applying
{
    /// <summary>
    /// Class Pig implements IAnimal contract.
    /// </summary>
    class Pig : IAnimal
    {
        /// <summary>
        /// Pig Name read-only instance property
        /// </summary>
        public string Name { get; }

        /// <summary> 
        /// Pig Constructor
        /// </summary> 
        /// <param name="name">Pig name</param> 
        public Pig(string name)
        {
            Name = name;
            Console.WriteLine("New pig named {0} was borned!", Name);
        }

        /// <summary> 
        /// Pig Eat instance method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine("{0} eats almost everything...", Name);
        }

        /// <summary> 
        /// Pig MakeNoise instance method (IAnimal contract)
        /// </summary> 
        public void MakeNoise()
        {
            Console.WriteLine("Oink Oink");
        }
    }
}
