using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleApp2020.Unit4
{
    /// <summary>
    /// This class has methods that will convert the number of miles 
    /// entered to feet, or the number of feet entered into miles
    /// 
    /// Author:  Dr Derek Peacock
    /// Module:  CO453
    /// Task:    4.1
    /// Updated: 04/Feb/2020
    /// </summary>
    public class T41_DistanceConverter
    {
        public const double FEET_IN_MILES = 1760 * 3;

        private double miles;
        private double feet;

        /// <summary>
        /// This method will prompt the user to enter the number of feet 
        /// or miles that they want to convert
        /// </summary>
        public double GetNumber(string prompt)
        {
            string value;
            Console.Write("Please enter the number of " + prompt + "> ");
            value = Console.ReadLine();

            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This method will take a number of miles and convert them to feet
        /// </summary>
        /// <returns>No of feet in miles</returns>
        public double ToFeet(double miles)
        {
            return miles * FEET_IN_MILES;
        }

        /// <summary>
        /// This method will take a number of feet and convert them to miles
        /// </summary>
        public double ToMiles(double feet)
        {
            return feet / FEET_IN_MILES;
        }
    }
}
