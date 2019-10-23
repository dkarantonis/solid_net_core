using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Class Cat implements IAnimal contract.
    /// </summary>
    class Cat : IAnimal
    {
        /// <summary>
        /// Cat Name read-only instance property
        /// </summary>
        public string Name { get; }

        /// <summary> 
        /// Cat Constructor
        /// </summary> 
        /// <param name="name">Cat name</param> 
        public Cat(string name)
        {
            Name = name;
            Console.WriteLine("New cat named {0} was borned!", Name);
        }

        /// <summary> 
        /// Cat Eat instance method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine("{0} eats fish...", Name);
        }

        /// <summary> 
        /// Cat Μeow instance method
        /// </summary> 
        public void Μeow()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
