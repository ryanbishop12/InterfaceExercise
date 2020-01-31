using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their value

            ICompanyVehicle BigBlue = VehicalFactory.GetVehicle(1);
            BigBlue.make = "Honda";
            BigBlue.logo = "H";
            BigBlue.mpg = 25;
            BigBlue.fuelLevel = 15;
            BigBlue.seats = 5;
            BigBlue.doors = 4;
            BigBlue.hasTurbo = false;
            BigBlue.hasStripes = false;

            ICompanyVehicle OldRed = VehicalFactory.GetVehicle(2);
            OldRed.make = "Ford";
            OldRed.logo = "Ford";
            OldRed.mpg = 15;
            OldRed.fuelLevel = 19;
            OldRed.seats = 3;
            OldRed.doors = 2;
            OldRed.bedLength = 6;
            OldRed.fourWheelDrive = true;

            ICompanyVehicle MrBlack = VehicalFactory.GetVehicle(3);
            MrBlack.make = "Ford";
            MrBlack.logo = "Ford";
            MrBlack.mpg = 15;
            MrBlack.fuelLevel = 19;
            MrBlack.seats = 3;
            MrBlack.doors = 2;
            MrBlack.spareTire = false;
            MrBlack.topSpeed = 110;

            Console.WriteLine("Big Blue make :");
            Console.WriteLine(BigBlue.make);
            Console.WriteLine("Big Blue logo :");
            Console.WriteLine(BigBlue.logo);
            Console.WriteLine("Big Blue mpg :");
            Console.WriteLine(BigBlue.mpg);
            Console.WriteLine("Big Blue fuel level :");
            Console.WriteLine(BigBlue.fuelLevel);
            Console.WriteLine("Big Blue seats :");
            Console.WriteLine(BigBlue.seats);
            Console.WriteLine("Big Blue doors :");
            Console.WriteLine(BigBlue.doors);
            Console.WriteLine("Does Big Blue have a turbo :");
            Console.WriteLine(BigBlue.hasTurbo);
            Console.WriteLine("Does Big Blue have stripes :");
            Console.WriteLine(BigBlue.hasStripes);
            Console.WriteLine();

            Console.WriteLine("Old Red make :");
            Console.WriteLine(OldRed.make);
            Console.WriteLine("Old Red logo :");
            Console.WriteLine(OldRed.logo);
            Console.WriteLine("Old Red mpg :");
            Console.WriteLine(OldRed.mpg);
            Console.WriteLine("Old Red fuel level :");
            Console.WriteLine(OldRed.fuelLevel);
            Console.WriteLine("Old Red seats :");
            Console.WriteLine(OldRed.seats);
            Console.WriteLine("Old Red doors :");
            Console.WriteLine(OldRed.doors);
            Console.WriteLine("Old Red bed length :");
            Console.WriteLine(OldRed.bedLength);
            Console.WriteLine("Is Old Red four wheel drive :");
            Console.WriteLine(OldRed.fourWheelDrive);
            Console.WriteLine();

            Console.WriteLine("Mr. Black make :");
            Console.WriteLine(MrBlack.make);
            Console.WriteLine("Mr. Black logo :");
            Console.WriteLine(MrBlack.logo);
            Console.WriteLine("Mr. Black mpg :");
            Console.WriteLine(MrBlack.mpg);
            Console.WriteLine("Mr. Black fuel level :");
            Console.WriteLine(MrBlack.fuelLevel);
            Console.WriteLine("Mr. Black seats :");
            Console.WriteLine(MrBlack.seats);
            Console.WriteLine("Mr. Black doors :");
            Console.WriteLine(MrBlack.doors);
            Console.WriteLine("Does Mr. Black have a spare tire :");
            Console.WriteLine(MrBlack.spareTire);
            Console.WriteLine("Mr. Black's top speed :");
            Console.WriteLine(MrBlack.topSpeed);
        }
    }
}
