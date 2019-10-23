using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violating
{
    /// <summary>
    /// Class Doll implements IToy contract.
    /// </summary>
    class Doll : IToy
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
        /// Doll Fly instance method (IToy contract)
        /// </summary> 
        public void Fly()
        {
            Console.WriteLine("Doll toy has not been designed to fly");
            //throw new NotSupportedException("Doll toy has not been designed to fly");
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
