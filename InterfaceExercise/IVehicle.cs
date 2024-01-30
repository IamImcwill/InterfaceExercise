using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
      public int NumberOfDoors { get; set; } 
      public bool HasEngine { get; set; }
      public bool HasBumpers { get; set; }

    }
}
