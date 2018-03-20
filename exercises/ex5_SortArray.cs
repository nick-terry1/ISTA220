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
                SortArray(count);
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

            // This method a user input array and puts the contents into numerical order.
            void SortArray(int length)
            {
                int element;            // 'element' is a place to save contents of userArray[i+1] which gets overwritten during the sort
                int changes = 1;        // Random positive integer. Keeps track of whether there were any changes or not
                // continues to loop until there arent any changes
                while (changes != 0)
                {
                    changes = 0;                                            // 'changes' is zero before the for loop which sorts starts
                    for (int i = 0; i < length - 1; i++)
                    {
                        // If the number to the right of it is bigger switch them and record that a change took place in 'changes'
                        if (userArray[i+1] < userArray[i])
                        {
                            element = userArray[i+1];
                            userArray[i + 1] = userArray[i];
                            userArray[i] = element;
                            changes++;
                        }
                    }
                }
                // prints out every element in userArray
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{userArray[j]} ");
                }
                Console.ReadLine();
            }
        }
    }
}