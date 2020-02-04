using CO453_ConsoleApp2020.Unit4;
using System;

namespace CO453_ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("  Convert Miles to Feet by Derek   ");
            Console.WriteLine("===================================");
            Console.WriteLine();

            T41_DistanceConverter converter = new T41_DistanceConverter();

            double miles = converter.GetNumber("Miles");
            double feet = converter.ToFeet(miles);

            Console.WriteLine("No of Feet = " + feet);
            Console.ReadLine();

        }
    }
}
