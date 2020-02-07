using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleApp2020.Unit4
{
    /// <summary>
    /// This class ...
    /// 
    /// For Tasks 4.2 and 4.3 
    /// 
    /// Author      : Dr Derek Peacock
    /// Modified by : Student Name
    /// </summary>
    class T42_Book
    {
        // Attributes of Book

        private string author, name, town;
        private string animal, weapon, job;
        private string gender, attack, body;
        private string pronoun;

        public T42_Book()
        {
            author = "Derek ";
            name = "Sue ";
            town = "Watford ";
            animal = "fox ";
            weapon = "candlestick ";
            job = "blacksmith ";
            gender = "she "; pronoun = "her ";
            attack = "hit ";
            body = "head ";
        }

        /// <summary>
        /// Prompt the user for an answer as a string and return it
        /// </summary>
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// Get the details of the author, name, town, animal
        /// job and weapon used in the books stories
        /// </summary>
        public void GetDetails() // keep using ask() to get information
        {
            author = GetString("Please type your name : ");
            name = GetString("Please type a friend's name : ");
            town = GetString("Now give me the name of a town : ");
            animal = GetString("Now a type of animal : ");
            job = GetString("Now a type of job : ");
            weapon = GetString("And your weapon of choice : ");
        }

        /// <summary>
        /// This method creates a the first chapter of a story using 
        /// the attributes of the class
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();

            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("Chapter 1");
            Console.WriteLine("---------");

            Console.WriteLine("It was a dark night in " + town + " and " + name
                + " could hear " + animal + "s screaming in the distance.");

            Console.WriteLine(name + " staggered terrified through the streets of "
                + town + ", realising " + gender + " had been followed.");

            Console.WriteLine("In the shadow of a doorway, a demented " + job
                + " waited, clutching a menacing " + weapon);
        }

        /// <summary>
        /// This method creates a the second chapter of a story using 
        /// the attributes of the class
        /// </summary>
        public void WriteChapter2()
        {
            Console.WriteLine();
            Console.WriteLine("Chapter 2");
            Console.WriteLine("---------");

            Console.WriteLine("As " + gender + "passed the doorway, the " + job + attack 
                + pronoun + body  + " and " + gender + " fell to the ground.");

            Console.WriteLine(name + " then kicked out and brought the " + job + " down");

            Console.WriteLine(gender + "quickly got up and ran down the street in" 
                + " to the safety of the church");
        }
    }
}
