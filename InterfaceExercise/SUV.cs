using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompanyVehicle
    {
        public string make { get; set; }
        public string logo { get; set; }
        public int mpg { get; set; }
        public int fuelLevel { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }
        public bool spareTire { get; set; }
        public int topSpeed { get; set; }
        public int bedLength { get; set; }
        public bool fourWheelDrive { get; set; }
        public bool hasTurbo { get; set; }
        public bool hasStripes { get; set; }
    }
}
