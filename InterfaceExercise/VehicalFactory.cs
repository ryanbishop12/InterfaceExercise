using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class VehicalFactory
    {
        public static ICompanyVehicle GetVehicle(int i)
        {
            switch(i)
            {
                case 1:
                    return new Car();
                case 2:
                    return new Truck();
                case 3:
                    return new SUV();
                default:
                    return new Car();
            }
        }
    }
}
