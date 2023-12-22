using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles



            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();
   
            
            var car1 = new Car();
            car1.DriveVirtual();
            car1.DriveAbstract();
            car1.Make = "Kia";
            car1.Model = "Forte";
            car1.Year = 2020;
            var motorcycle1 = new Motorcycle();
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            motorcycle1.Make = "Suzuki";
            motorcycle1.Model = "GSX25OR ABS";
            motorcycle1.Year = 2024;

            Vehicle genericCar = new Car();
            Vehicle genericMotorcycle = new Motorcycle();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(genericCar);
            vehicles.Add(genericMotorcycle);




            // Call each of the drive methods for one car and one motorcycle
            motorcycle1.ListOfProperties();
            car1.ListOfProperties();
            genericCar.ListOfProperties();
            genericMotorcycle.ListOfProperties();
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            car1.DriveVirtual();
            car1.DriveAbstract();


            #endregion            
            Console.ReadLine();



        }
    }
}
