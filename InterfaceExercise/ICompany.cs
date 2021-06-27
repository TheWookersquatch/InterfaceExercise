using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        //In ICompany

        /*Create 2 members that are specific to each every company
        * regardless of vehicle type.
        *
        *
        * Example: public string Logo { get; set; }
        */
        public static int NumberOfDealershipsInUSA { get; set; }
        public static string CompanySponsors { get; set; }

    }
}
