using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment06
{
    /// <summary>
    /// Interfaces are contracts that the inheriting class has to implement
    /// </summary>
    internal interface IVehicle
    {
        /// <summary>
        /// this method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();
    }
}
