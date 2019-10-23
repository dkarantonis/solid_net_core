using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Class cat implements IAnimal contract.
    /// </summary>
    class Cat : IAnimal
    {
        //_name private field
        private string _name;

        /// <summary>
        ///    Name read-only instance property
        /// </summary>
        public string Name  
        {
            get => _name;
        }

        /// <summary> 
        /// Constructor
        /// </summary> 
        /// <param name="name">Cat name</param> 
        public Cat(string name)
        {
            _name = name;
            Console.WriteLine("New cat with name {0} was borned!", _name);
        }

        /// <summary> 
        /// Eat instance method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine(String.Format("{0} eats fish...", _name));
        }

        /// <summary> 
        /// Μeow instance method
        /// </summary> 
        public void Μeow()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
