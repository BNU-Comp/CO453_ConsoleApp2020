using CO453_ConsoleApp2020.Unit4;
using System;

namespace CO453_ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            TestBook();
        }

        private static void TestBook()
        {
            T42_Book book = new T42_Book();

            book.WriteChapter1();
            book.WriteChapter2();
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

            string[] choices = 
            { 
                "1. Convert Miles to Feet", 
                "2. Convert Feet to Miles",
                "3. Quit Program"
            };

            int choice = 0;

            do
            {
                choice = ConsoleUI.GetChoice(choices);

                if (choice == 1)
                {
                    double miles = converter.GetNumber("Miles");
                    double feet = converter.ToFeet(miles);

                    Console.WriteLine("No of Feet = " + feet);
                }
                else if (choice == 2)
                {
                    double feet = converter.GetNumber("Feet");
                    double miles = converter.ToMiles(feet);

                    Console.WriteLine("No of Miles = " + miles);
                }

            } while (choice != 3);

        }
    }
}
