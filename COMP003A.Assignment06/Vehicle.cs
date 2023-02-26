using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment06
{
    /// <summary>
    /// Abstracts describe a contract but doesnot provide a full implementation of the contract
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        /***** fields section *****/
        // not: in almost all programming languages, youwould typically pair a field with a property
        // not a requirement in c# because it offers auto-property
        private string _brand;
        private string _model;
        private int _numberofWheels;

        /***** constructors section *****/
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor that takes three parameters; brand, model, numberOfWheels
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="numberOfWheels"></param>
        /// <returns></returns>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        /***** properties section *****/
        /// <summary>
        /// Retrieve/Store Brand information
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/Store Model information
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retrieve/Store Number of Wheels information
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberofWheels; }
            set { _numberofWheels = value; }
        }

        /***** methods section *****/
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }
}
