using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleApp2020
{
    /// <summary>
    /// This class will provide general methods to assist user
    /// input and output using the Console
    /// </summary>
    public static class ConsoleUI
    {
        public static void WriteTitle(string title, string task)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("  CO453 Class Exercises by Derek Peacock  ");
            Console.WriteLine("  " + task + " " + title);
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }
    }
}
