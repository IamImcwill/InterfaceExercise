using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasATrunk { get; set; }
        public bool CoupeOrSedan { get; set; }
        
        
        public string Logo { get; set; }
        public string Name { get; set; }
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 4;
        public bool HasEngine { get ; set ; } = true;
        public bool HasBumpers { get; set; } = true;

        public void Drive() 
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
