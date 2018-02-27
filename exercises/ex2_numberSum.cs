using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will accept ten numbers from the user and return their sum*/

namespace project2_numSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10];                                           // Created an array 10 numbers long to hold the values
            Console.WriteLine("Please enter ten numbers to add together");          // Wrote out the instructions to the user
            int count = 0;                                                          // Initialized a counter for the while loop
            while (count<10)                                                        // This loop takes the array numArray and incrimentally
                {                                                                   //  goes through every element and assigns the user
                count++;                                                            //  input while adding 1 to the counter every loop
                Console.Write($"{count}: ");
                numArray[count-1] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine($"The sum of all the numbers is {numArray.Sum()}");   // Outputs the sum of the completed array
        }
    }
}
