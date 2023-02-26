using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment06
{
    /// <summary>
    /// Car extends the Vehicle class
    /// </summary>
    internal class Car : Vehicle
    {
        /***** constructors section *****/
        // by default, a class has a default constructor that does not take any parameters
        // therefore, doesn't need to explicitly create one

        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInof()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine($"I don't want to disclose my information.");
        }
    }
}
