using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Class dog implements IAnimal contract.
    /// </summary>
    class Dog : IAnimal
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
        /// <param name="name">Dog name</param> 
        public Dog(string name)
        {
            _name = name;
            Console.WriteLine("New dog with name {0} was borned!", _name);
        }

        /// <summary> 
        /// Dog Eat method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine(String.Format("{0} eats beef meat...", _name));
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
