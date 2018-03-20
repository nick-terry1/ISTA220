using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: mar 20, 2018

/* This program will take a user input array of any length, prompt the user to pick a number of spaces to rotate it and which direction,
 * then print the results on screen. */


namespace ex5_CountandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // A,B,C are sample strings that I used to test the program before it was finished.
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int count = 0;

            // After prompting the user, the input is saved to a string array, seperated by spaces. Then that array is parsed to Int's
            Console.WriteLine("Enter a list of integers seperated by spaces");
            string[] user_temp = Console.ReadLine().Split(' ');
            int[] userArray = Array.ConvertAll(user_temp, Int32.Parse);

            // This try block will incriment the array until it gets out of range, then throws an exception
            try
            {
                // no conditional
                for (int i = 0; ; i++)
                {
                    int test = userArray[i];
                    count++; // saves the length of the array in count
                }
            }
            // The IndexOutofRangeException will inevitably be thrown and the method AddArray() is called when it is
            catch (IndexOutOfRangeException)
            {
                RotateArray(count);
            }

            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadLine();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }

            // This method rotates the array a given length (n) either left or right
            void RotateArray(int length)
            {
                Console.WriteLine("How many spaces would you like to rotate the array? ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Left or Right?");
                string lr = Console.ReadLine();

                // If the user types a choice that isnt one of these he should learn how to turn caps lock off
                if ((lr == "Right") || (lr == "right"))
                {
                    int[] rotatedArray = new int[length];
                    int r = 0;

                    // This loop runs until the original array reaches its final index.
                    for (int i = 0; i < length - n - 1; i++)                // original array bounds are array length - spaces rotated - 1.
                    {
                        rotatedArray[i] = userArray[length - n + i];        // The starting position for rotated array is the same as
                        Console.Write($"{rotatedArray[i]} ");               // the user input array at its final spot - rotated spots + i(0)
                        r++;                                                // Count the # of loops for the next loop condition
                    }

                    // This loop picks up where the last loop left off, but the starting position on the original array is now [0]
                    for (int j = 0; j < length - r; j++)
                    {
                        rotatedArray[r + j] = userArray[j];
                        Console.Write($"{rotatedArray[r + j]} ");
                    }

                    Console.ReadLine();
                }

                // This 'Left' block is the same as the 'Right' block but with two differences: the starting position for the original array
                // in the first for loop is now n + i and the condition to stop is length - n.
                if ((lr == "Left") || (lr == "left"))
                {
                    int[] rotatedArray = new int[length];
                    int r = 0;

                    for (int i = 0; i < length - n; i++)
                    {
                        rotatedArray[i] = userArray[i + n];
                        Console.Write($"{rotatedArray[i]} ");
                        r++;
                    }

                    for (int j = 0; j < length - r; j++)
                    {
                        rotatedArray[r + j] = userArray[j];
                        Console.Write($"{rotatedArray[r + j]} ");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}