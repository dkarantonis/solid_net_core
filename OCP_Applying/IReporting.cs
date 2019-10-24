using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Applying
{
    /// <summary>
    /// Interface to be implemented by objects that generate reports
    /// </summary>
    partial interface IReporting
    {
        /// <summary>
        /// GenerateReport method
        /// </summary>
        public void GenerateReport();
    }
}
