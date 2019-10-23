using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Applying
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
    }
}
