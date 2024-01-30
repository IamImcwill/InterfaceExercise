using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Suv : ICompany, IVehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasAThirdRow { get; set; }
        public bool HasACargoDoor { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public bool HasEngine { get ; set ; }
        public bool HasBumpers { get ; set ; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

    }
}
