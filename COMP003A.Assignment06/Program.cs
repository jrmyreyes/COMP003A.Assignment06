﻿/*
 * Author: Ron Jeremy Reyes
 * Course: CCOMP-003a
 * Purpose: Object-oriented programming concepts for week 6
 * 
 */
namespace COMP003A.Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Vehicle1");
            Vehicle vehicle1 = new Car();
            vehicle1.Brand = "Tesla";
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();

            PrintSeparator("vehicle2");
            Vehicle vehicle2 = new Car()
            {
                Brand = "Toyota",
                Model = "Supra",
                NumberOfWheels = 4,
            };
            vehicle2.GetInfo();
            Console.WriteLine("But you can still access my Properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");

            PrintSeparator("vehicle3");
            Vehicle vehicle3 = new Truck("GMC", "Sierra 1500 AT4", 6, 5.5);
            vehicle3.GetInfo();

            PrintSeparator("Vehicle4");
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckModel: "F-150 Raptor", sizeOfTruckBed: 5.5);
            vehicle4.GetInfo();
        }

        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}