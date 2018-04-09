using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will do three things: play a game where the user picks the array for the computer to search through,
 * and the number to search for, randomly pick a number and let the user guess what it is, and let the user pick the
 * number and have the computer guess what number it is. */

// author: nick terry
// date: april 8, 2018

namespace ex8_numberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            // All paths end with a goto start to redo the main menu option.
            START:
            try
            {
                ConsoleKey mmChoice;

                // the user will continue to come back to the main menu WHILE the console key mmChoice isn't escape.
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
                                // the user is allowed to choose the array list and the number to search
                                Console.WriteLine("Please enter a list of integers to use the bisection algorithm on.\n" +
                                    "Enter each value seperated by a space. Press enter when finished.");
                                string[] input_temp = Console.ReadLine().Split(' ');
                                int[] input = Array.ConvertAll(input_temp, int.Parse);

                                // the array has to be sorted in order to use this method
                                Array.Sort(input);
                                Console.WriteLine("Now enter a number you want the computer to search for:");
                                int value = int.Parse(Console.ReadLine());
                                int guess = 0;

                                // method bisection needs to return two values - int n, and int guess so i used the ref keyword
                                int n = Bisection(input, value, ref guess);

                                // returning the value -1 means that 'value' wasnt in the array 'input'
                                if (n == -1)
                                {
                                    Console.WriteLine("The number you selected is not in the list you provided.\n" +
                                        "Press enter to return to the main menu.");
                                    Console.ReadLine();
                                }

                                // if 'value' was in the array provided it displays 'value' and the # of times it took to guess it 'guess'
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

                                // only the initial guess is passed to HumanGuessGame()
                                HumanGuessGame(guess);
                                goto START;
                            }
                        case ConsoleKey.D3:
                            {
                                Console.Clear();
                                Console.WriteLine("This game will have the computer try to guess your number! Remember the \n" +
                                    "number you pick must be between 1 and 100. So what number do you want?");

                                // The number must be between 1 and 100
                                int pick = int.Parse(Console.ReadLine());
                                if ((pick > 100) || (pick < 1))
                                {
                                    Console.WriteLine("Your selection must be between 1 and 100! I warned you, now go back to the main menu!");
                                    Console.ReadKey();
                                    goto START;
                                }

                                // populating the array 'sample' with values 1 - 100
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

            // if someone tries to input a letter when we only accept letters in this program
            catch (FormatException fEx)
            {
                Console.Clear();
                Console.WriteLine(fEx.Message + "\n press Enter to quit and try again");
                Console.ReadLine();
                goto START;
            }

            // if someone tries to enter a number beyond the bounds of int
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

            // keeping track of the number of guesses the computer does, which gets incrimented with each recursion.
            guess++;

            // the starting position for the search algorithm is the halfway point in the array.
            int half = ar.Length / 2;

            // if the program has iterated through all the values and the array has been whittled down to 0 entries
            // the number was not found in the array and returns -1.
            if (ar.Length == 0)
            {
                return -1;
            }

            // recursion is called if the number at the halfway point isnt the value we're looking for.
            if (ar[half] != n)
            {
                // if the number we're looking for is smaller than the halfway point we'll use recursion to call the program using
                // an array that represents everything to the left of 'n'.
                if (ar[half] > n)
                {
                    int[] left = new int[half];

                    // setting the values of the array 'left' with all the values to the left of the halfway point.
                    for (int i = 0; i < half; i++)
                    {
                        left[i] = ar[i];
                    }
                    return Bisection(left, n, ref guess);
                }

                // if 'n' is greater than the halfway point we call recursion using the new array 'right' 
                else if (ar[half] < n)
                {
                    int[] right = new int[ar.Length - half - 1];

                    // 'right' is set to all the values to the right of the halfway point in the original array
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
            // count is the number of times you had to guess. Obviously you cant guess less than once.
            int count = 1;

            // 'pick' represents a random number between 1 and 1000.
            int pick = new Random().Next(1, 1000);

            // this program will run for as long as the guess doesnt equal the value chosen by the above 'Random' Class.
            while (guess != pick)
            {
                // some hints to help if the number is greater or less than the guess.
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

        // this method is a lot like the method Bisection() but this one will post what the computers guess was and also picks 
        // a guess from an array thats only between 1 and 100.
        public static int ComputerGuess(int[] ar, int pick)
        {
            int half = ar.Length / 2;

            // if the halfway point is equal to the pick then it returns the halfway point. If not the program recursively
            // calls itself and passes and array that is either everything to the left or right of the halfway point
            // depending on whether its greater than or less than the halfway point.
            if (ar[half] != pick)
            {
                if (ar[half] > pick)
                {
                    int[] left = new int[half];

                    // instantiating an array 'left' with everything left of the halfway point.
                    for (int i = 0; i < half; i++)
                    {
                        left[i] = ar[i];
                    }
                    Console.WriteLine($"\nI guess...{ar[half]}! Hmm a little high. At least\n" +
                        $"I've ruled it down to ");

                    // this foreach loop prints every value in left to tell the user what the computer has ruled it down to
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

                    // instantiating the array 'right' with every value right of the halfway point.
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
