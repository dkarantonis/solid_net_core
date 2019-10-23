using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violating
{
    /// <summary>
    /// Class Plane implements IToy contract.
    /// </summary>
    class Plane : IToy
    {
        /// <summary>
        /// Plane Price instance property
        /// </summary>
        public double Price { get; }

        /// <summary> 
        /// Plane Constructor
        /// </summary> 
        public Plane(double price)
        {
            Console.WriteLine("New plane toy created!");
            Price = price;
        }

        /// <summary> 
        /// Plane Buy instance method (IToy contract)
        /// </summary> 
        public void Buy()
        {
            Console.WriteLine("Plane toy was bought for ${0}", Price);
        }

        /// <summary> 
        /// Plane Fly instance method (IToy contract)
        /// </summary> 
        public void Fly()
        {
            Console.WriteLine("Plane toy flies up in the air...");
        }

        /// <summary> 
        /// Plane Talk instance method (IToy contract)
        /// </summary> 
        public void Talk()
        {
            //throw new NotSupportedException("Plane toy has not been designed to talk.");
            Console.WriteLine("Plane toy has not been designed to talk.");
        }
    }
}
