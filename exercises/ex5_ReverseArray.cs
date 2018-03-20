using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: mar 20, 2018

/* This program takes a user input array of integers and outputs the reverse order of it. */

namespace ex5_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // A,B,C are sample strings that I used to test the program before it was finished.
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            // User input array read as an array of strings, then converted to an array of integers.
            Console.WriteLine("Enter an array of integers seperated by spaces");
            string[] user_temp = Console.ReadLine().Split(' ');
            int[] userArray = Array.ConvertAll(user_temp, Int32.Parse);
            int count = 0;

            try
            {
                // no conditional
                for (int i = 0; ; i++)
                {
                    int test = userArray[i];
                    count++; // saves the length of the array in count
                }
            }
            // The IndexOutofRangeException will inevitably be thrown and the method PrintReverse() is called when it is
            catch (IndexOutOfRangeException)
            {
                PrintReverse();
            }

            // This for loop reads each location in the user input array starting with the last value and prints it
            void PrintReverse()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{userArray[count - i - 1]} ");
                }
                Console.ReadLine();
            }
        }
    }
}
