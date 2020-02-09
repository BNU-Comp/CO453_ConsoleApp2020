﻿using CO453_ConsoleApp2020.Unit4;
using CO453_ConsoleApp2020.Unit5;

using System;

namespace CO453_ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter(); // 4.1
            //TestBook(); // 4.2 and 4.3
            
            //TestTournament(); // 5.1
            //TestSongs(); // 5.2
            TestMotelBooking(); // 5.6
        }

        /// <summary>
        /// A simple room booking system
        /// </summary>
        private static void TestMotelBooking()
        {
            T56_BatesMotel motel = new T56_BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1: motel.Book(1, 2);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Task 5.2
        /// </summary>
        private static void TestSongs()
        {
            T52_MP3Chart chart = new T52_MP3Chart();

            chart.ShowSongs();
            chart.GetVotes();
            chart.ShowVotes();
        }

        /// <summary>
        /// Task 5.1
        /// </summary>
        private static void TestTournament()
        {
            T51_Tournament tournament = new T51_Tournament();

            tournament.GetScores();

            tournament.ShowScores();
        }

        /// <summary>
        /// Task 4.2
        /// </summary>
        private static void TestBook()
        {
            T42_Book book = new T42_Book();

            string[] choices =
            {
                "1. Get Details",
                "2. Use Defaults" 
            };

            int choice = SimpleIO.GetChoice(choices);

            if(choice == 1)
            {
                book.GetDetails();
            }

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
            SimpleIO.WriteTitle("Distance Converter", "Task 4.1");

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
                choice = SimpleIO.GetChoice(choices);

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
