using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will take the average of ten test scores and output the value,
 * along with the accompanying letter grade */

namespace project2_avgTen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created an array 10 numbers long to hold the values
            int[] numArray = new int[10];                                          
            Console.WriteLine("Please enter ten numbers to average");
            // Initialized a counter for the while loop
            int count = 0;

            /* This while loop takes the array numArray and 
            steps through it, asking the user for the value, and incrimenting the count
            at each loop. */

            while (count < 10)                                                        
            {                                                                   
                count++;                                                           
                Console.Write($"{count}: ");
                numArray[count - 1] = int.Parse(Console.ReadLine());

                /* This nested while loop if a catch in case the user accidentally
                 * inserts a value greater than 100 or less than 0 which is impossible.
                 * It simply re-asks the user to enter a value using the same code as above */

                while ((numArray[count-1] < 0) || (numArray[count-1] > 100))
                {
                    Console.WriteLine("The number must be between 0 and 100. Please Give another number");
                    Console.Write($"{count}: ");
                    numArray[count - 1] = int.Parse(Console.ReadLine());
                }
            }
            // stores avgScore for use with following if statements
            double avgScore = numArray.Average();
            // Outputs the average of the completed array
            Console.WriteLine($"The average of all the numbers is {numArray.Average()}");   

            char grade;

            /* The following if else array finds the range in which the average score
             * lies and assigns and prints a letter grade that matches it */

            if (avgScore < 60)
            {
                grade = 'F';
                Console.WriteLine(grade);
            }
            else if ((avgScore >= 60) && (avgScore < 70))
            {
                grade = 'D';
                Console.WriteLine(grade);
            }
            else if ((avgScore >=70) && (avgScore < 80))
            {
                grade = 'C';
                Console.WriteLine(grade);
            }
            else if ((avgScore >= 80) && (avgScore < 90))
            {
                grade = 'B';
                Console.WriteLine(grade);
            }
            else if (avgScore >= 90)
            {
                grade = 'A';
                Console.WriteLine(grade);
            }
        }
    }
}

