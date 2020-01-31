using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int mpg { get; set; }
        public int fuelLevel { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }

    }
}
