using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Applying
{
    /// <summary>
    /// Class Doll implements IToy / ITalk contracts
    /// </summary>
    class Doll : IToy, ITalk
    {
        /// <summary>
        /// Doll Price read-only instance property
        /// </summary>
        public double Price { get; }

        /// <summary> 
        /// Doll Constructor
        /// </summary> 
        public Doll(double price)
        {
            Console.WriteLine("New doll toy created!");
            Price = price;
        }

        /// <summary> 
        /// Doll Buy instance method (IToy contract)
        /// </summary> 
        public void Buy()
        {
            Console.WriteLine("Doll toy was bought for ${0}", Price);
        }

        /// <summary> 
        /// Doll Talk instance method (IToy contract)
        /// </summary> 
        public void Talk()
        {
            Console.WriteLine("Doll toy says hello...");
        }
    }
}
