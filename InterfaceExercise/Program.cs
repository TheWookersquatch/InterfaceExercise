using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Now, create objects of your 3 classes and give their members values;
            Car sedan = new Car(15, false, 4, 4, "Toyota", "Camry", 1500, "International Olympic and Paralympic Committees");
            SUV suv = new SUV(25, true, 4, 4, "Chevrolet", "Tahoe", 3000, "Major League Baseball");
            Truck truck = new Truck(62, true, 4, 4, "Ford", "F-150", 3000, "National Football League");

            //Creatively display and organize their values
            VehicleChoice();
        }
        public static void VehicleChoice()
        {
            Console.WriteLine("Which vehicle do you want to learn more about?");
            Console.WriteLine($"A: Toyota Camry");
            Console.WriteLine($"B: Chevrolet Tahoe");
            Console.WriteLine($"C: Ford F-150");

            //if user chooses a, b, or c, the corresponding message will display about the vehicle. Otherwise, they will be prompted to enter a valid answer.
            while (true)
            {
                char input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                    case 'a':
                        Console.WriteLine($"The {Car.Make} {Car.Model} is a sedan and not a compact car. " +
                            $"It has {Car.NumberOfWheels} wheels, {Car.NumberOfDoors} doors, and a trunk space of {Car.TrunkSize} cubic feet." +
                            $" {Car.Make} is proud to sponsor the {Car.CompanySponsors} and there are about {Car.NumberOfDealershipsInUSA} {Car.Make} dealerships in the United States.");
                        break;

                    case 'b':
                        Console.WriteLine($"The {SUV.Make} {SUV.Model} can be used as an armored vehicle. " +
                            $"It has {SUV.NumberOfWheels} wheels, {SUV.NumberOfDoors} doors, and a cargo hold of {SUV.CargoHoldSize} cubic feet." +
                            $" {SUV.Make} is proud to sponsor the {SUV.CompanySponsors} and there are about {SUV.NumberOfDealershipsInUSA} {SUV.Make} dealerships in the United States.");
                        break;

                    case 'c':
                        Console.WriteLine($"The {Truck.Make} {Truck.Model} is an excellent choice for farm work. " +
                            $"It has {Truck.NumberOfWheels} wheels, {Truck.NumberOfDoors} doors, and an average bed size of {Truck.BedSize} cubic feet (depending on what options you choose)." +
                            $" {Truck.Make} is proud to sponsor the {Truck.CompanySponsors} and there are about {Truck.NumberOfDealershipsInUSA} {Truck.Make} dealerships in the United States.");
                        break;
                    default:
                        Console.WriteLine("That is not a valid entry. Please choose A, B, or C.");
                        continue;

                }
            }
        }
    }
}
