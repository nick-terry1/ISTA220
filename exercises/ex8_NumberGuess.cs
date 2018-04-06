using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_numberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            try
            {
                ConsoleKey mmChoice;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Pick an option 1-3");
                    Console.WriteLine("1) Bisection Algorithm Game (user input numbers)\n" +
                        "2) Human Guess Number Game (computer array, human guesses)\n" +
                        "3) Computer Guess Number Game (computer guesses your number)\n" +
                        "\n Press <esc> to exit the program\n");

                    mmChoice = Console.ReadKey().Key;

                    switch (mmChoice)
                    {
                        case ConsoleKey.D1:
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a list of integers to use the bisection algorithm on.\n" +
                                    "Enter each value seperated by a space. Press enter when finished.");
                                string[] input_temp = Console.ReadLine().Split(' ');
                                int[] input = Array.ConvertAll(input_temp, int.Parse);
                                Array.Sort(input);
                                Console.WriteLine("Now enter a number you want the computer to search for:");
                                int value = int.Parse(Console.ReadLine());
                                int guess = 0;
                                int n = Bisection(input, value, ref guess);
                                if (n == -1)
                                {
                                    Console.WriteLine("The number you selected is not in the list you provided.\n" +
                                        "Press enter to return to the main menu.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("The computer guessed {0} times that your number was {1}", guess, n);
                                    Console.ReadLine();
                                }
                                goto START;
                            }
                        case ConsoleKey.D2:
                            {
                                Console.Clear();
                                Console.WriteLine("We're going to play a game where I pick a number between 1 and 1000,\n" +
                                    "and you need to guess what it is! Dont worry, ill give you hints along the way.\n" +
                                    "Go ahead and start guessing!");
                                int guess = int.Parse(Console.ReadLine());
                                HumanGuessGame(guess);
                                goto START;
                            }
                        case ConsoleKey.D3:
                            {
                                Console.Clear();
                                Console.WriteLine("This game will have the computer try to guess your number! Remember the \n" +
                                    "number you pick must be between 1 and 100. So what number do you want?");
                                int pick = int.Parse(Console.ReadLine());
                                if ((pick > 100) || (pick < 1))
                                {
                                    Console.WriteLine("Your selection must be between 1 and 100! I warned you, now go back to the main menu!");
                                    Console.ReadKey();
                                    goto START;
                                }
                                int[] sample = new int[100];
                                for (int i = 0; i < 100; i++)
                                {
                                    sample[i] = i + 1;
                                }
                                int final = ComputerGuess(sample, pick);
                                Console.WriteLine($"I guessed the number - its {final}!\n" +
                                $"press enter to return to the main menu.");
                                Console.ReadLine();
                                goto START;
                            }
                    }
                }
                while (mmChoice != ConsoleKey.Escape);
            }
            catch (FormatException fEx)
            {
                Console.Clear();
                Console.WriteLine(fEx.Message + "\n press Enter to quit and try again");
                Console.ReadLine();
                goto START;
            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.WriteLine("One of the numbers you entered was too big. Keep the numbers below 2 billion please." +
                    "\n press <enter> to return to the main menu.");
                Console.ReadLine();
                goto START;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message + "\nPress enter to go back to the main menu");
                Console.ReadLine();
                goto START;
            }
        }

        public static int Bisection(int[] ar, int n, ref int guess)
        {
            guess++;
            int half = ar.Length / 2;

            if (ar.Length == 0)
            {
                return -1;
            }

            if (ar[half] != n)
            {
                if (ar[half] > n)
                {
                    int[] left = new int[half];
                    for (int i = 0; i < half; i++)
                    {
                        left[i] = ar[i];
                    }
                    return Bisection(left, n, ref guess);
                }
                else if (ar[half] < n)
                {
                    int[] right = new int[ar.Length - half - 1];
                    for (int i = 0; i < ar.Length - half - 1; i++)
                    {
                        right[i] = ar[half + 1 + i];
                    }
                    return Bisection(right, n, ref guess);
                }
            }
            return ar[half];
        }

        public static void HumanGuessGame(int guess)
        {
            int count = 1;
            int pick = new Random().Next(1, 1000);

            while (guess != pick)
            {
                if (guess > pick)
                {
                    Console.WriteLine("Your guess was too high! Guess again!");
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess < pick)
                {
                    Console.WriteLine("Your guess was too low! Guess again!");
                    guess = int.Parse(Console.ReadLine());
                }
                count++;
            }
            Console.WriteLine($"Correct! And it only took you {count} guesses too!\n" +
                $"Press enter to return to the main menu.");
            Console.ReadLine();
        }

        public static int ComputerGuess(int[] ar, int pick)
        {
            int half = ar.Length / 2;

            if (ar[half] != pick)
            {
                if (ar[half] > pick)
                {
                    int[] left = new int[half];
                    for (int i = 0; i < half; i++)
                    {
                        left[i] = ar[i];
                    }
                    Console.WriteLine($"\nI guess...{ar[half]}! Hmm a little high. At least\n" +
                        $"I've ruled it down to ");
                    foreach (int spot in left)
                    {
                        Console.Write("{0} ", spot);
                    }
                    Console.ReadLine();
                    return ComputerGuess(left, pick);
                }
                else if (ar[half] < pick)
                {
                    int[] right = new int[ar.Length - half - 1];
                    for (int i = 0; i < ar.Length - half - 1; i++)
                    {
                        right[i] = ar[half + 1 + i];
                    }
                    Console.WriteLine($"\nI guess...{ar[half]}! Hmm a little low. At least\n" +
                        $"I've ruled it down to ");
                    foreach (int spot in right)
                    {
                        Console.Write("{0} ", spot);
                    }
                    Console.ReadLine();
                    return ComputerGuess(right, pick);
                }
            }
            
            return ar[half];
        }
    }
}
