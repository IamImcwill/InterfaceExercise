using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructions
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE!!!

            //Create 3 classes called Car , Truck , & SUV DONE!!!

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common. DONE!!!
             * Example: public int NumberOfWheels { get; set; } DONE!!!
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type. DONE!!!
             * Example: public string Logo { get; set; } DONE!!!
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class DONE!!!
             * Example for Car: public bool HasTrunk { get; set; } DONE!!!
             * Example for SUV: public int NumberOfSeats { get; set; } DONE!!!
             *
             *
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */
            #endregion
            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values


            #region Vehicles
            Car myFirstCar = new Car 
            { 
                Year = "2025", 
                Make = "Porsche",
                Model = "Panamera", 
                HasATrunk = true, 
                Logo = "Gold and Red Shield" 
            };

            Suv myFirstSuv = new Suv 
            { 
                Year = "2025",
                Make = "Mercedes-Benz",
                Model = "AMG 63 G-Wagon",
                HasACargoDoor = true,
                Logo = "Circle with 3 lines in it"
            };

            Truck myFirstTruck = new Truck 
            { 
                Year = "2025", 
                Make = "Ford", 
                Model = "Raptor",
                HasABed = true, 
                Logo = "Blue oval with Ford written in it" 
            };
            #endregion
            List<IVehicle> myList = new List<IVehicle>() 
            { 
               myFirstCar,
               myFirstSuv,
               myFirstTruck
            };
            foreach (IVehicle vehicle in myList) 
            {
                Console.WriteLine($"vehicle {vehicle.NumberOfWheels} {vehicle.NumberOfDoors} {vehicle.HasEngine} {vehicle.HasBumpers}");
            }
            Console.WriteLine($"{myFirstCar.Year} {myFirstCar.Make} {myFirstCar.Model} {myFirstCar.Logo}");
            Console.WriteLine($"{myFirstSuv.Year} {myFirstSuv.Make} {myFirstSuv.Model} {myFirstSuv.Logo}");
            Console.WriteLine($"{myFirstTruck.Year} {myFirstTruck.Make} {myFirstTruck.Model} {myFirstTruck.Logo}");

           
            


            


        }
    }
}
