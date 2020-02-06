using CO453_ConsoleApp2020.Unit4;
using System;

namespace CO453_ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDistanceConverter();
            Console.ReadLine();
        }

        /// <summary>
        /// Task 4.1
        /// Test that the DistanceConverter can accurately convert
        /// any number of miles into feet and vice versa
        /// </summary>
        private static void TestDistanceConverter()
        {
            ConsoleUI.WriteTitle("Distance Converter", "Task 4.1");

            T41_DistanceConverter converter = new T41_DistanceConverter();

            double miles = converter.GetNumber("Miles");
            double feet = converter.ToFeet(miles);

            Console.WriteLine("No of Feet = " + feet);
        }
    }
}
