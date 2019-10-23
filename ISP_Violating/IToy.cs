using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violating
{
    /// <summary>
    /// Interface to be implemented by toys.
    /// </summary>
    interface IToy
    {
        /// <summary> 
        /// Price read-only property
        /// </summary> 
        double Price { get; }

        /// <summary> 
        /// Buy method
        /// </summary> 
        void Buy();

        /// <summary> 
        /// Fly method
        /// </summary> 
        void Fly();

        /// <summary> 
        /// Talk method
        /// </summary> 
        void Talk();
    }
}
