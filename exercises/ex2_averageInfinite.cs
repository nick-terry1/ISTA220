using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* This program takes an infinite amount of test scores and returns an average number grade,
 * and a matching letter grade after every entry. Program ends when user writes 'end' */

namespace project2_avgInfinateV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list to hold the unknown amount of test scores
            List<int> numList = new List<int>();
            int count = 0;
            double avg = 0;
            string userVar;
            char grade = 'U';

            Console.WriteLine("Please enter test values. Type 'end' when finished");
           
            // This while loop will continue to run until the physical memory is filled
            while (count < int.MaxValue)
            {
                count++;
                Console.Write($"n{count}:");
                userVar = Console.ReadLine();
                
                // Before anything, check to see if the user wants to exit...
                if (userVar == "end")
                {
                    return;
                }
                
                // ...Then check if the user goes outside the grade range and keep him there
                // until he gives a realistic value between 100 and 0.
                while ((int.Parse(userVar) > 100) || (int.Parse(userVar) < 0))
                {
                    Console.WriteLine("Please enter a value thats within 0 and 100");
                    userVar = Console.ReadLine();
                }

                //Finally if the value is a good one add it to the List 'numList' as an integer
                numList.Add(int.Parse(userVar));

                // Calculate the average value in the list
                avg = numList.Average();

                // This if else array will assign a letter grade to 'grade' depending on the average value 'avg'
                if (avg < 60)
                {
                    grade = 'F';
                }
                else if ((avg >= 60) && (avg < 70))
                {
                    grade = 'D';
                }
                else if ((avg >= 70) && (avg < 80))
                {
                    grade = 'C';
                }
                else if ((avg >= 80) && (avg < 90))
                {
                    grade = 'B';
                }
                else if (avg >= 90)
                {
                    grade = 'A';
                }

                // Print the average and grade to the console and repeat the loop
                Console.WriteLine($"The average grade is {avg} and the letter grade is {grade}");
            }
        }
    }
}
