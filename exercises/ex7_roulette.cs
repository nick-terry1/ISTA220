using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program simulates a roulette table by randomly picking a number between 0 and 36 and displays all
 * the winning bets that would pay out on that number */

namespace ex7_roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // These arrays are each column of the table
            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] middle = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            // This array has every number available and only these numbers are available for the value of 'ball'
            int[] all = new int[] { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
                , 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

            // These arrays are all the red and black numbers respectively
            int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            // ball is the 0-36 value of the all array taken by the index returned by the method GetRandom() 
            int ball = all[GetRandom()];
            Console.WriteLine("The ball landed on {0}.", ball);
            Console.WriteLine("\nWinning bets:");

            // testing for red or black
            if (red.Contains<int>(ball))
            {
                Console.WriteLine("Red");
            }

            else if (black.Contains<int>(ball))
            {
                Console.WriteLine("Black");
            }

            //testing for even or odd
            if ((ball % 2 == 0) && (ball != 0))
            {
                Console.WriteLine("Even");
            }

            else if (ball % 2 == 1)
            {
                Console.WriteLine("Odd");
            }

            // testing which dozen
            if ((ball > 0) && (ball < 13))
            {
                Console.WriteLine("1 to 12");
            }

            else if ((ball > 12) && (ball < 25))
            {
                Console.WriteLine("13 to 24");
            }

            else if (ball > 24)
            {
                Console.WriteLine("25 to 36");
            }

            // Testing which column, then finding all split bets, street bets, and corner bets that would be assosiated with that column
            if (left.Contains<int>(ball))
            {
                Console.WriteLine("Column 1");
                Console.WriteLine($"street bet {ball}/{ball + 1}/{ball + 2}");
                if (ball == 34)
                {
                    Console.WriteLine("split bets 31/34, 34/35\n" +
                        "corner bet 34/35/31/32");
                }

                else if (ball == 1)
                {
                    Console.WriteLine("split bets 1/2, 1/4\n" +
                        "corner bet 1/2/4/5");
                }
                else
                {
                    Console.WriteLine("split bets {0}/{1}, {0},{2}, {0}/{3}"
                        , ball, (ball + 1), (ball + 3), (ball - 3));
                    Console.WriteLine("corner bets {0}/{1}/{2}/{3}, {0}/{1}/{4}/{5}"
                        , ball, ball + 1, ball - 2, ball - 3, ball + 4, ball + 3);
                }
            }

            else if (middle.Contains<int>(ball))
            {
                Console.WriteLine("Column 2");
                Console.WriteLine($"street bet {ball - 1}/{ball}/{ball + 1}");
                if (ball == 35)
                {
                    Console.WriteLine("split bets 35/34, 35/32, 35/36\n" +
                        "corner bets 31/32/34/35, 32/33/35/36");
                }

                else if (ball == 2)
                {
                    Console.WriteLine("split bets 1/2, 2/5, 2/3\n" +
                        "corner bets 1/2/4/5, 2/3/5/6");
                }

                else
                {
                    Console.WriteLine("split bets {0}/{1}, {0}/{2}, {0}/{3}, {0}/{4}"
                        , ball, (ball + 1), (ball - 1), (ball - 3), (ball + 3));
                    Console.WriteLine("corner bets {0}/{1}/{2}/{3}, {0}/{1}/{4}/{5}, {0}/{6}/{7}/{2}, {0}/{6}/{5}/{8}"
                        , ball, ball - 1, ball - 3, ball - 4, ball + 2, ball + 3, ball + 1, ball - 2, ball + 4);
                }
            }

            else if (right.Contains<int>(ball))
            {
                Console.WriteLine("Column 3");
                Console.WriteLine($"street bet {ball - 2}/{ball - 1}/{ball}");
                if (ball == 3)
                {
                    Console.WriteLine("split bets 3/2, 3/6\n" +
                        "corner bet 2/3/5/6");
                }

                else if (ball == 36)
                {
                    Console.WriteLine("split bets 36/35, 36/33\n" +
                        "corner bet 32/33/35/36");
                }

                else
                {
                    Console.WriteLine("split bets {0}/{1}, {0}/{2}, {0}/{3}"
                        , ball, (ball - 1), (ball + 3), (ball - 3));
                    Console.WriteLine("corner bets {0}/{1}/{2}/{3}, {0}/{1}/{4}/{5}"
                        , ball, ball-1, ball-3, ball-4, ball+2, ball+3);
                }
            }

            // testing which half
            if ((ball > 0) && (ball < 19))
            {
                Console.WriteLine("1 to 18");
            }

            else if (ball > 18)
            {
                Console.WriteLine("19 to 36");
            }


            // This method returns a random number based on the current milliseconds after modulating it within the scope of roulette 
            // numbers, which would just be 37
            int GetRandom()
            {
                string r = DateTime.Now.Millisecond.ToString();
                int rand = int.Parse(r);
                rand %= 38; // only allows for remainders of 0 - 37 (corresponding to the all array's index)
                return rand;
            }
        }
    }
}
