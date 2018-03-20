using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: mar 20, 2018

    /* This program takes an integer array that is user input of any size and prints out the size of the array,
 * the sum of all the integers in the array, and the mean value of all the values. */

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
                AddArray(userArray);
            }
            
            // the AddArray method adds all the integers up, averages them, and prints the result
            void AddArray(int[] arr)
            {
                int sum = 0;
                // this loop steps through the array and stops at the length count
                for (int j = 0; j < count; j++)
                {
                    sum += arr[j];
                }
                int avg = sum / count;

                // prints length, sum, and average of the array
                Console.WriteLine("Lenth:{0} Sum: {1} Mean: {2}", count, sum, avg);
                Console.ReadLine();
            }
        }
    }
}
