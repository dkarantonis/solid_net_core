using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Class pig implements IAnimal contract.
    /// </summary>
    class Pig : IAnimal
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
        /// <param name="name">Pig name</param> 
        public Pig(string name)
        {
            _name = name;
            Console.WriteLine("New pig with name {0} was borned!", _name);
        }
         
        /// <summary> 
        /// Pig Eat method (IAnimal contract)
        /// </summary> 
        public void Eat()
        {
            Console.WriteLine(String.Format("{0} and eats almost everything...", _name));
        }

        /// <summary> 
        /// Pig Oink method
        /// </summary> 
        public void Oink()
        {
            Console.WriteLine("Oink Oink");
        }
    }
}
