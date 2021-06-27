using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        /*Create 2 members that are specific to each class
        * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
        *
        * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
        * 
        */
        public SUV()
        {

        }
        public SUV(int cargoHoldSize, bool isArmored, int numberOfWheels, int numberofDoors, string make, string model, int numDealerships, string companySponsors)
        {
            CargoHoldSize = cargoHoldSize;
            IsArmored = isArmored;
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberofDoors;
            Make = make;
            Model = model;
            NumberOfDealershipsInUSA = numDealerships;
            CompanySponsors = companySponsors;
        

        }
        public static int CargoHoldSize { get; set; }
        public static bool IsArmored { get; set; }
        
        public static int NumberOfWheels { get; set; }
        public static int NumberOfDoors { get; set; }
        public static string Make { get; set; }
        public static string Model { get; set; }

        public static int NumberOfDealershipsInUSA { get; set; }
        public static string CompanySponsors { get; set; }
    }
}
