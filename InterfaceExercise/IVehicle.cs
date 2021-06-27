using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        /* Create 4 members that Car, Truck, & SUV all have in common.
        * Example: All vehicles have a number of wheels... for now..
        */
       
        public static int NumberOfWheels { get; set; } 
        public static int NumberOfDoors { get; set; }
        public static string Make { get; set; }
        public static string Model { get; set; }
    }
}
