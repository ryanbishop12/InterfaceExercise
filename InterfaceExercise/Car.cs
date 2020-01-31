﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public string make { get; set; }
        public string logo { get; set; }
        public int mpg { get; set; }
        public int fuelLevel { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }
        public bool hasTurbo { get; set; }
        public bool hasStripes { get; set; }
    }
}
