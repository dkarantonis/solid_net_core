using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Violating
{
    /// <summary>
    /// Interface to be implemented by animals.
    /// </summary>
    interface IAnimal
    {
        /// <summary> 
        /// Name read-only property
        /// </summary> 
        String Name { get; }

        /// <summary> 
        /// Eat method
        /// </summary> 
        void Eat();
    }
}
