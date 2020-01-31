using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompanyVehicle
    {
        public string make { get; set; }
        public string logo { get; set; }
        public int mpg { get; set; }
        public int fuelLevel { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }
        public int bedLength { get; set; }
        public bool fourWheelDrive { get; set; }


    }
}
