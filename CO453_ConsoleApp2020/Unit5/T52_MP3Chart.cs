using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleApp2020.Unit5
{
    public class T52_MP3Chart
    {
        public const int MAXN_SONGS = 10;
        private string[] chart;
        private int[] votes = new int[MAXN_SONGS];

        public T52_MP3Chart()
        {
            chart = new string[]
            {
                "Don't Start Now",
                "Dance Monkey",
                "Own It",
                "Blinding Lights",
                "The Box",
                "This is Real",
                "Good as Hell",
                "South of the Border",
                "Physical",
                "Post Malone"
            };
        }

        public void GetVotes()
        {

            SimpleIO.WriteTitle("Vote for UK Top 10 Chart Singles", "Task 5.2");
            Console.WriteLine("Enter 0 to quit");
            Console.WriteLine();

            int songNo = 0;
            bool quitVoting = false;

            do
            {
                songNo = SimpleIO.GetInt("Enter song no: ");

                if (songNo <= MAXN_SONGS && songNo >= 1)
                {
                    votes[songNo - 1]++;
                }
                else quitVoting = true;

            } while (quitVoting == false);
        }


        public void ShowVotes()
        {
            Console.Clear();
            SimpleIO.WriteTitle("Votes for UK Top 10 Chart Singles", "Task 5.2");

            for(int i = 0; i < MAXN_SONGS; i++)
            {
                string line = "Song " + (i + 1) + ": ";
                line = line + chart[i] + " has ";
                line = line + votes[i] + " votes";

                Console.WriteLine(line);
            }
        }

        public void ShowSongs()
        {
            SimpleIO.WriteTitle("UK Top 10 Chart Singles", "Task 5.2");

            int position = 0;

            foreach(string song in chart)
            {
                position++;
                Console.WriteLine("Song " + position + " is " + song);
            }
        }
    }
}
